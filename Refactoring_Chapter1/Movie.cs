using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Chapter1
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private string _title;
        private int _priceCode;

        public Movie(string title, int priceCode)
        {
            this._title = title;
            this._priceCode = priceCode;
        }

        public int GetPriceCode()
        {
            return _priceCode;
        }

        public void GetPriceCode(int arg)
        {
            _priceCode = arg;
        }

        public string GetTile()
        {
            return this._title;
        }

        public double GetCharge(int daysRented)
        {
            double result = 0;
            switch (GetPriceCode())
            {
                case Movie.REGULAR:
                    result += 2;
                    if (daysRented > 2)
                    {
                        result += (daysRented - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    result += daysRented * 3;
                    break;
                case Movie.CHILDRENS:
                    result += 1.5;
                    if (daysRented > 3)
                    {
                        result += (daysRented - 3) * 1.5;
                    }
                    break;
                default:
                    break;
            }

            return 0;
        }

       public int GetFrequentRenterPoints(int daysRented)
        {
            if ((GetPriceCode() == Movie.NEW_RELEASE) && daysRented> 1)
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
