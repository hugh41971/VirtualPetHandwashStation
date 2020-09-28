using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            HandwashStation stationOne = new HandwashStation();
            Console.WriteLine("Hello!");
            Console.WriteLine("You've just had a long,fun day playing with that nifty Virtual Pet you just made!");
            Console.WriteLine("Those little scamps sure are fun. But so messy! Robots especially - oil everywhere!");
            Console.WriteLine("Let's use our handy - dandy Virtual Handwash Station to clean you up");
            Console.WriteLine("Would you like to :");
            Console.WriteLine("1.Run the faucets?");
            Console.WriteLine("2.Get some soap from the dispenser?");
            Console.WriteLine("3.Use some towels?");
            Console.WriteLine("4.Use the blow dryer?");
            Console.WriteLine("5.Refill the soap and towels before you go?");
            Console.WriteLine("6.Do nothing and live your life your way?");

            int response = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (response == 1)
                {
                    stationOne.RunFaucets();
                    break;
                }
                else if (response == 2)
                {
                    stationOne.PumpSoap();
                    break;
                }
                else if (response == 3)
                {
                    stationOne.PullTowels();
                    break;
                }
                else if (response == 4)
                {
                    stationOne.UseDryer();
                    break;
                }
                else if (response == 5)
                {
                    stationOne.RefillSupplies();
                    break;
                }
                else
                {
                    Console.WriteLine("You do you, man. Rock on!");
                    break;
                }

            }
            Console.WriteLine();
                
                    
                
                    
            




        }

    }
}

