using System;
using System.Collections.Generic;
using System.Globalization;
using System.Timers;
using ZooSim.Common;
using static ZooSim.Common.RandomNumber;

namespace ZooSim.App
{
    class Program
    {
        private static int hourCounter;
        static CultureInfo cult = new CultureInfo("en-GB");
        static bool allDead = true;

        // Create a List and add the animals

        static List<Animal> animals = new List<Animal>
        {
            new Elephant { Name = "Nellie", Type = "Elephant", Health = 100 },
            new Elephant { Name = "Dumbo", Type = "Elephant", Health = 100 },
            new Elephant { Name = "Trumpy", Type = "Elephant", Health = 100 },
            new Elephant { Name = "Babar", Type = "Elephant", Health = 100 },
            new Elephant { Name = "Elmer", Type = "Elephant", Health = 100 },

            new Giraffe { Name = "Gerry", Type = "Giraffe", Health = 100 },
            new Giraffe { Name = "Lofty", Type = "Giraffe", Health = 100 },
            new Giraffe { Name = "Leggy", Type = "Giraffe", Health = 100 },
            new Giraffe { Name = "Necky", Type = "Giraffe", Health = 100 },
            new Giraffe { Name = "Geoffrey", Type = "Giraffe", Health = 100 },

            new Monkey { Name = "Cheeta", Type = "Monkey", Health = 100 },
            new Monkey { Name = "Abu", Type = "Monkey", Health = 100 },
            new Monkey { Name = "Rafiki", Type = "Monkey", Health = 100 },
            new Monkey { Name = "George", Type = "Monkey", Health = 100 },
            new Monkey { Name = "Albert", Type = "Monkey", Health = 100 }
        };

        static Timer zooTimer = new Timer();

        static public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            allDead = true;

            // Retard the health for each animal in the list and then check for life
            for (int i = animals.Count-1; i >=0; i--)
            {
                
                if (animals[i].IsAlive())
                {
                    allDead = false;

                    animals[i].Retard(GetRandom(HealthAction.Reduce));

                    Console.Write(animals[i].Name + " the " + animals[i].Type + " has " + (animals[i].Health / 100).ToString("P02", cult) + " health, ");

                    Console.WriteLine(animals[i].Name + " is " + (animals[i].IsAlive() ? "alive" : "dead"));

                }
            }

            hourCounter += 1;
            Console.WriteLine("Current Zoo time is " + DateTime.Now.AddHours(hourCounter).ToShortTimeString());

            if (allDead == true)
            {
                zooTimer.Stop();
                Console.WriteLine("Sadly all the animals are dead, the zoo is now closed");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.Name + " the " + animal.Type + " has " + (animal.Health / 100).ToString("P02", cult) + " health, ");
                }                
            }
        }

        static void Main(string[] args)
        {

            //start the clock
            
            //zooTimer.Elapsed += delegate { OnTimedEvent(); };
            zooTimer.Elapsed += OnTimedEvent;
            zooTimer.Interval = 5000;
            zooTimer.Enabled = true;

            // run the main loop
            do
            {
                // iterate while no keys are pressed
                while (!Console.KeyAvailable)
                {
                    // do nothing
                }

                // key now pressed - which was it?
                var keyPressed = Console.ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.F:
                        Console.WriteLine("Feeding animals...");
                        foreach (var animal in animals)
                        {
                            animal.FeedMe(GetRandom(HealthAction.Boost));
                        }
                        break;

                    default:
                        break;
                }
            } while (allDead == false);

            return;       

        }

    }
}
