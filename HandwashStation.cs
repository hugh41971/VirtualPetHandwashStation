using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Choose_Your_Class
{
    public class HandwashStation

    {
        public string Faucets { get; set; }
        public int SoapDispenser { get; set; } = 50;
        public int TowelDispenser { get; set; } = 100;
        public string BlowDryer { get; set; }
        
        public void RunFaucets()
        {
            Console.WriteLine("You ran the faucets!");
        }
        public void PumpSoap()
        {
            SoapDispenser -= 5;
            Console.WriteLine("Here's some soap for you! Scrub up!");
            
        }
        public void PullTowels()
        {
            TowelDispenser -= 10;
            Console.WriteLine(" You grabbed down some towels! Don't go crazy!");
        }
        public void UseDryer()
        {
            Console.WriteLine("You used the dryer!Man, it blows hot!");
        }
        public void RefillSupplies()
        {
            SoapDispenser = 50;
            TowelDispenser = 100;
            Console.WriteLine("You refilled everything! You're a peach!");
        }
    }
    
     
    
    
    
    
}
