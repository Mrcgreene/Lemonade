using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Game
    {

        public int decisionToPlay;

        public void Gulp()
        {
            Game kickStart = new Game();
            kickStart.Greeting();
            kickStart.GameInstruction();
            kickStart.ItemizedList();
            kickStart.WeatherPrediction();
            kickStart.StoreVisit();
            Console.ReadLine();
            kickStart.PlayerSetPrice();
            
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome to Quiet Meadows Community Lemonade Stand");
            Console.WriteLine("This is a game that you try and make a profit from selling lemonade.");
            Console.WriteLine("Let's see how your decisions affect this small business");
            Console.WriteLine("Do you care to try? (1) Yes, (2) No");
            decisionToPlay = Convert.ToInt32(Console.ReadLine());
            if(decisionToPlay == 2)
            {
                Console.WriteLine("Maybe another time when you are ready.");
                Environment.Exit(0);
            }
        }

        public void GameInstruction()
        {
            Console.WriteLine("Check the weather, visit the community store and purchase the ingredients you need for your stand.");
            Console.WriteLine("You have 7 days to sell your lemonade, manage your money for purchasing more supplies.");
            Console.WriteLine("Remember the weather may affect the outcome along the way.");
            Console.WriteLine("If you're ready to begin, press ENTER");
            Console.ReadLine();
        }

        public void WeatherPrediction()
        {
            Weather myView = new Weather();
            myView.randomizeTemperature();
        }

        public void ItemizedList()
        {
            Inventory goodies = new Inventory();
            Console.WriteLine("Note: One pitcher will make 10 cups of lemonade.");
            Console.WriteLine("You currently have " + goodies.CalculateMixLeft() + " " + "cups of mixture to use.");
            Console.WriteLine("Your remaining money is: " + "$" + goodies.CalculateBalance());
            Console.ReadLine(); 
        }

        public void StoreVisit()
        {
            Store shoppingCart = new Store();
            shoppingCart.MixturePurchased();
            shoppingCart.MixtureTotal();
        }

        public void PlayerSetPrice()
        {
            Player settingPriceOfCup = new Player();
            settingPriceOfCup.CupSellPrice();
       }
         public void SellSimulation()
        {
            //24 second counter to simulate time between days done here how?
        }





        //create exit/end game option that remains available at all times

        //need to be able to capture popularity based on satisfaction over course of days played


        /*if balance reachs 0, display game over message with recursion function to and message 
        "would you like to try again y/n?" until yes is selected to use start game function or no to exit game*/
    }
}
