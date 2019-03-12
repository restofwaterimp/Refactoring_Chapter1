using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Chapter1
{
    class Customer
    {

        private string _name;
        private List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            this._name = name;
        }

        public void AddRental(Rental rental)
        {
            this._rentals.Add(rental);
        }

        public string GetName()
        {
            return this._name;
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;

            string result = "Rental Record for" + GetName() + "\n";

            foreach(var rent in this._rentals)
            {
                frequentRenterPoints++;

                if((rent.GetMovie().GetPriceCode() == Movie.NEW_RELEASE) &&
                    rent.GetDaysRented() > 1)
                {
                    frequentRenterPoints++;
                }

                result += "\t" + rent.GetMovie().GetTile() + "\t" + rent.GetCharge().ToString() + "\n";
                totalAmount += rent.GetCharge();
            }

            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + "frequent renter points";
            return result;
        }
    }
}

