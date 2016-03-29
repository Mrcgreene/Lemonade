using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Player
    {
        public double lemonadeCupCharge;
        public string inputCupCost;

        public double CupSellPrice()
        {
            Console.WriteLine("How much will you sell a cup of lemonade for?");
            lemonadeCupCharge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ice cold lemonade for sale at " + "$"+lemonadeCupCharge + " " + "a cup!!!");
            Console.ReadLine();
            return lemonadeCupCharge;
        }
        


        
    }
}
