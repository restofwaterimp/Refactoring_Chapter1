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
            double result = 0;
            switch (GetMovie().GetPriceCode())
            {
                case Movie.REGULAR:
                    result += 2;
                    if (GetDaysRented() > 2)
                    {
                        result += (GetDaysRented() - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    result += GetDaysRented() * 3;
                    break;
                case Movie.CHILDRENS:
                    result += 1.5;
                    if (GetDaysRented() > 3)
                    {
                        result += (GetDaysRented() - 3) * 1.5;
                    }
                    break;
                default:
                    break;
            }

            return 0;
        }
    }
}
