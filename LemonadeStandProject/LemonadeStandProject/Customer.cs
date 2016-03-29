using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        public bool lemonadePurchase;
        public int goodMood;
        public int numberOfVisitors;
        public double moneyTakenIn;
        public int numberofCupsBought;
        public double lemonadeCupCharge;

        public Customer()
        {
            CustomerStats();
        }
        private void CustomerStats()
        {
            Random rand = new Random();
            goodMood = rand.Next(10);
        }

        public List<Customer> GenerateCustomers(int numberOfCustomers)
        {
            List<Customer> visitors = new List<Customer>();
            for(int person = 0; person < numberOfCustomers; person++)
            {
                visitors.Add(new Customer());
            }
            return visitors;
        }

        public double BuyCupLemonade()
        {
            //Console.WriteLine("How many cups would you like to buy at " + lemonadeCupCharge + "?");
            numberofCupsBought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(lemonadeCupCharge * numberofCupsBought);
            return moneyTakenIn;
        }

        public void PurchaseProbability()
        {
            //algor for cost and weather factors in purchasing
        }

    }
}
