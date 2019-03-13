using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Chapter1
{
   abstract class Price
    {
        public abstract int GetPriceCode();
    }

    class ChildrensPrece : Price
    {
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }
    }

    class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }
    }

    class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }
    }
}
