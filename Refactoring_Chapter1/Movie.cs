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
    }
}
