using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Chapter1
{
    class Rental
    {
        private Movie _movie;
        private int _daysRented;

        public Rental(Movie movie, int daysRented)
        {
            this._movie = movie;
            this._daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return _daysRented;
        }

        public Movie GetMovie()
        {
            return _movie;
        }

        public double GetCharge()
        {
            return _movie.GetCharge(_daysRented);
        }

        public int GetFrequentRenterPoints()
        {
            if ((GetMovie().GetPriceCode() == Movie.NEW_RELEASE) && GetDaysRented() > 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
