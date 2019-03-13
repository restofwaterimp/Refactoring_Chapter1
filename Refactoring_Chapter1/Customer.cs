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
            string result = "Rental Record for" + GetName() + "\n";

            foreach(var rent in this._rentals)
            {
                result += "\t" + rent.GetMovie().GetTile() + "\t" + rent.GetCharge().ToString() + "\n";
            }

            result += "Amount owed is " + GetTotalCharge().ToString() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints().ToString() + "frequent renter points";
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

        private int GetTotalFrequentRenterPoints()
        {
            int result = 0;
            foreach (var rent in this._rentals)
            {
  
                result += rent.GetFrequentRenterPoints();
            }
            return result;
        }

    }
}

