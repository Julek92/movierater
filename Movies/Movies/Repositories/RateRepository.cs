using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;

namespace Movies.Repositories
{
    public class RateRepository : IRateRepository
    {
        private RateContext _context;

        public RateRepository(RateContext context)
        {
            _context = context;
        }

        public void CreateRate(Rate rate)
        {                
            _context.Add(rate); 
            _context.SaveChanges();            
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public IQueryable<Rate> RatesForFilm(int filmId)
        {
            var ratesQuery = from b in _context.Rate
                                where (b.FilmId == filmId)
                                select b;

            return ratesQuery;
        }

    }
}
