using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Repositories
{
    public interface IRateRepository
    {
        void CreateRate(Rate rate);
        void SaveChanges();
        IQueryable<Rate> RatesForFilm(int filmId);

    }
}
