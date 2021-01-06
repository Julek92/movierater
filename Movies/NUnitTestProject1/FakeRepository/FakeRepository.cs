using Movies.Models;
using Movies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTestProject1.FakeRepository
{
    public class FakeRepository : IRateRepository
    {
        public void CreateRate(Rate rate)
        {
        }

        public IQueryable<Rate> RatesForFilm(int filmId)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
        }
    }
}
