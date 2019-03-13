using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;

namespace Refactoring_Chapter1
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private string _title;
        private Price _price;

        public Movie(string title, int priceCode)
        {
            this._title = title;
            SetPriceCode(priceCode);
        }

        public int GetPriceCode()
        {
            return _price.GetPriceCode();
        }

        public void SetPriceCode(int arg)
        {
            switch (arg)
            {
                case REGULAR:
                    _price = new RegularPrice();
                    break;
                case CHILDRENS:
                    _price = new ChildrensPrece();
                    break;
                case NEW_RELEASE:
                    _price = new NewReleasePrice();
                    break;
                default:
                    throw new ArgumentException("Invalid charge Code!");
            }
        }

        public string GetTile()
        {
            return this._title;
        }

        public double GetCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
        }

       public int GetFrequentRenterPoints(int daysRented)
        {
            return _price.GetFrequentRenterPoints(daysRented);
        }


    }
}
