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

        // Create a List and add the animals

        static List<Animal> animals = new List<Animal>
        {
            new Elephant { Name = "Nellie" },
            new Elephant { Name = "Dumbo" },
            new Elephant { Name = "Trumpy" },
            new Elephant { Name = "Babar" },
            new Elephant { Name = "Elmer" },
                                            
            new Giraffe { Name = "Gerry" },
            new Giraffe { Name = "Lofty" },
            new Giraffe { Name = "Leggy" },
            new Giraffe { Name = "Necky" },
            new Giraffe { Name = "Geoffrey" },
                                            
            new Monkey { Name = "Cheeta" },
            new Monkey { Name = "Abu" },
            new Monkey { Name = "Rafiki" },
            new Monkey { Name = "George" },
            new Monkey { Name = "Albert" }
        };

        static Timer zooTimer = new Timer();

        static public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {

            // Retard the health for each animal in the list and then check for life
            for (int i = animals.Count - 1; i >= 0; i--)
            {

                if (animals[i].IsAlive())
                {

                    animals[i].Retard(GetRandom(HealthAction.Reduce));

                    Console.Write(animals[i].Name + " the " + animals[i].Type + " has " + (animals[i].Health / 100).ToString("P02", cult) + " health, ");

                    if (animals[i].IsAlive())
                    {
                        Console.WriteLine(animals[i].Name + " is alive");
                    }
                    else
                    {
                        Console.WriteLine(animals[i].Name + " is dead");
                        animals.RemoveAt(i);
                    }
                }
            }

            hourCounter += 1;
            Console.WriteLine("Current Zoo time is " + DateTime.Now.AddHours(hourCounter).ToShortTimeString());
            Console.WriteLine("");

            if (animals.Count == 0)
            {
                zooTimer.Stop();
                Console.WriteLine("Sadly all the animals are dead, the zoo is now closed");
                Console.WriteLine("Press any key to Exit...");
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
            } while (animals.Count != 0);

            return;       

        }

    }
}
