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
            int frequentRenterPoints = 0;

            string result = "Rental Record for" + GetName() + "\n";

            foreach(var rent in this._rentals)
            {
                frequentRenterPoints += rent.GetFrequentRenterPoints();

                result += "\t" + rent.GetMovie().GetTile() + "\t" + rent.GetCharge().ToString() + "\n";
            }

            result += "Amount owed is " + GetTotalCharge().ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + "frequent renter points";
            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;
                        
            foreach (var rent in this._rentals)
            {
                 result += rent.GetCharge();
            }
            return result;
        }

    }
}

