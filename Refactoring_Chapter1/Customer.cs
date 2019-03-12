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
                double thisAmount = 0;

                thisAmount = AmountFor(rent);
                
                frequentRenterPoints++;

                if((rent.GetMovie().GetPriceCode() == Movie.NEW_RELEASE) &&
                    rent.GetDaysRented() > 1)
                {
                    frequentRenterPoints++;
                }

                result += "\t" + rent.GetMovie().GetTile() + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + "frequent renter points";
            return result;
        }

        private double AmountFor(Rental rent)
        {
            double thisAmount = 0;
            switch (rent.GetMovie().GetPriceCode())
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (rent.GetDaysRented() > 2)
                    {
                        thisAmount += (rent.GetDaysRented() - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += rent.GetDaysRented() * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (rent.GetDaysRented() > 3)
                    {
                        thisAmount += (rent.GetDaysRented() - 3) * 1.5;
                    }
                    break;
                default:
                    break;
            }

            return thisAmount;
        }
    }
}
