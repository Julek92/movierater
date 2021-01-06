using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Film
    {
        public int id;
        public string title;
        public string openingCrawl;
        public string director;
        public string producer;
        public DateTime releaseDate;
        public List<int> rates;
        public int userRate { get; set; }


        public Film(int id, string title, string openingCrawl, string director, string producer, DateTime releaseDate)
        {
            this.id = id;
            this.title = title;
            this.openingCrawl = openingCrawl;
            this.director = director;
            this.producer = producer;
            this.releaseDate = releaseDate;
            rates = new List<int>();
        }
    }
}
