using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Choose_Your_Class
{
    public class HandwashStation

    {
        public int WaterLevel { get; set; } = 70;
        public int SoapLevel { get; set; } = 50;
        public int TowelQuantity { get; set; } = 100;
        public bool HandsWet { get; set; } = false;
        public int HandsDirty { get; set; } = 10;
        public void RunFaucets()
        {
            HandsWet = true;
            WaterLevel -= 10;
            Console.WriteLine("You ran the faucets!");
        }
        public void PumpSoap()
        {
            SoapLevel -= 5;
            HandsDirty -= 5;
            Console.WriteLine("Here's some soap for you! Scrub up!");
            
        }
        public void PullTowels()
        {
            TowelQuantity -= 10;
            Console.WriteLine(" You grabbed down some towels! Don't go crazy!");
        }
        public void UseDryer()
        {
            if (HandsWet)
            {
                Console.WriteLine("You used the dryer!Man, it blows hot!");
                HandsWet = false;
            }
            else
            {
                Console.WriteLine("Your hands are dry!");
            }
        }
        public void RefillSupplies()
        {
            SoapLevel = 50;
            TowelQuantity = 100;
            Console.WriteLine("You refilled everything! You're a peach!");
        }
    }
    
     
    
    
    
    
}
