using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movies.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Movies.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Movies.Controllers
{
    public class RateController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        private static List<Movies.Models.Film> moviesList;

        private IRateRepository _repository;

        private IHostingEnvironment _environment;
        public RateController(IRateRepository repository, IHostingEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            if (moviesList == null)
            {
                string SwapiFilmsObject = await GetFilms();
                mapJsonToFilmObjects(JObject.Parse(SwapiFilmsObject));
            }
            FillRatesToFilms();
            return View(moviesList);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Film film = moviesList.Find((x) => x.id == id);
            return View("RateFilm", film);
        }

        [HttpPost]
        public IActionResult Details(int userRate, int id)
        {
            Rate rate = new Rate();
            rate.RateValue = userRate;
            rate.FilmId = id;
            _repository.CreateRate(rate);
            FillRatesToFilms();
            return View("Index", moviesList);
        }

        private void FillRatesToFilms()
        {
            foreach (var film in moviesList)
            {
                List<int> ratesList = new List<int>();
                var rates = _repository.RatesForFilm(film.id);

                foreach (var rate in rates)
                {
                    film.rates.Add(rate.RateValue);
                }

            }
        }


        private void mapJsonToFilmObjects(JObject objectFromApi)
        {
            var filmsJson = objectFromApi.Last.First;

            foreach (var film in filmsJson)
            {
                string title = film.SelectToken("title").Value<string>();
                string opening_crawl = film.SelectToken("opening_crawl").Value<string>();
                string producer = film.SelectToken("producer").Value<string>();
                string director = film.SelectToken("director").Value<string>();
                string release_date = film.SelectToken("release_date").Value<string>();
                string episode_id = film.SelectToken("episode_id").Value<string>();
                int id = Convert.ToInt32(episode_id);

                DateTime releaseDate = Convert.ToDateTime(release_date);


                moviesList.Add(new Film(id, title, opening_crawl, director, producer, releaseDate));
            }


        }

        private async Task<string> GetFilms()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var stringTask = client.GetStringAsync("https://swapi.dev/api/films/");

            return await stringTask;
        }
    }
}
