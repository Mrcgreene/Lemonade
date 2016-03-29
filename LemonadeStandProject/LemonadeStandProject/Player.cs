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

        public double CupSellPrice()
        {
            Console.WriteLine("How much will you sell a cup of lemonade for?");
            lemonadeCupCharge = Convert.ToInt32(Console.ReadLine());
            return lemonadeCupCharge;
        }
        

        
    }
}
