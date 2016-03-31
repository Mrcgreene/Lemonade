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
            for (int person = 0; person < numberOfCustomers; person++)
            {
                visitors.Add(new Customer());
            }
            return visitors;
        }

        

        

        
    }
}

 

