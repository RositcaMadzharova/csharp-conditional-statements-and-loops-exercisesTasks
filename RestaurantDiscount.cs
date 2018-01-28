using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeoples = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallType = null;
            int hallPrice = 0;

            if (countOfPeoples <= 50)
            {
                hallType = "Small Hall";
                hallPrice = 2500;
            }
            else if (countOfPeoples > 50 && countOfPeoples <= 100)
            {
                hallType = "Terrace";
                hallPrice = 5000;
            }
            else if (countOfPeoples > 100 && countOfPeoples <= 120)
            {
                hallType = "Great Hall";
                hallPrice = 7500;
            }
            int discount = 0;
            int packagePrice = 0;

            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 5;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 10;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                discount = 15;
            }

            if (hallPrice != 0)

            {

                int totalPrice = hallPrice + packagePrice;

                double totalDiscount = totalPrice / 100.0 * discount;

                double pricePerPerson = (totalPrice - totalDiscount) / countOfPeoples;

                Console.WriteLine($"We can offer you the {hallType}");

                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

            }

            else Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}
