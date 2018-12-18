using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitProjektH1
{
    class Program
    {
        static void Main(string[] args)
        {
            methods methods = new methods();
            bool kiaIsRunning = false;
            bool porscheIsRunning = false;
            bool teslaIsRunning = false;
            bool isRunning = true;
            while (isRunning)
            { 
            Console.WriteLine("You and your family has decided that you wanna go on a roadtrip \n" +
                "but before you go, you have to make a few choices. \n" +
                "Your family consists of you, your wife and your two kids at the age of 10 \n" +
                "\n" +
                "You have to choose between 3 cars. Each with their own advantages and disadvantages \n" +
                "\n" +
                "Car 1: Kia Ceed stationcar \n" +
                "+ Lots of space for packing \n" +
                "+ Decent comfort \n" +
                "+ Good km/l \n" +
                "+ High safety rating \n" +
                "- Slow acceleration \n" +
                "- Poor topspeed \n" +
                "\n" +
                "Car 2: Porsche 911 4 seater \n" +
                "+ Fast acceleration \n" +
                "+ High topspeed \n" +
                "+ Great comfort in the front \n" +
                "- Low security in safety test\n" +
                "- Very bad comfort in the back \n" +
                "- Poor km/l \n" +
                "- Poor packing space \n" +
                "\n" +
                "Car 3: Tesla Model X \n" +
                "+ Fast acceleration \n" +
                "+ Decent topspeed \n" +
                "+ Great comfort front and back \n" +
                "+ Great packing space \n" +
                "+ Great rating in safety test \n" +
                "- Charging takes a long time \n" +
                "- Few places to charge \n" +
                "- If you run out of power it can be tough to get access to a chargingstation");
            Console.ReadKey();
            Console.Clear();
                Console.WriteLine("Which car would you like to drive? \n" +
                    "Car 1: Kia Ceed \n" +
                    "Car 2: Porsche \n" +
                    "Car 3: Tesla \n" +
                    "\n" +
                    "Please enter 1, 2 or 3");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        kiaIsRunning = true;
                        Console.WriteLine("You've chosen the Kia");
                        break;
                    case "2":
                        porscheIsRunning = true;
                        Console.WriteLine("You've chosen the Porsche");
                        break;
                    case "3":
                        teslaIsRunning = true;
                        Console.WriteLine("You've chosen the Tesla");
                        break;
                    default:
                        Console.WriteLine("Are you sure you picked a number from 1-3?");
                        break;
                }



            }
        }
    }

    class methods
    {
        public void TBoned()
        {
            Console.WriteLine("You're driving down a road, suddenly a car comes blasting from your right \n" +
                "The car havn't seen you and is about to hit you \n" +
                "What is your reaction? \n" +
                "\n" +
                "Quickly gas up and try to prevent getting hit \n" +
                "Brake'n pray he doesnt hit you");
        }
    }


    class Kia
    {
        public int packingSpace = 75;
        public int comfortFront = 70;
        public int comfortBack = 60;
        public int acceleration = 40;
        public int topSpeed = 40;
        public int gasTank = 60;
        public int safety = 75;
    }
    class Porsche
    {
        public int acceleration = 90;
        public int topSpeed = 100;
        public int comfortFront = 80;
        public int comfortBack = 20;
        public int packingSpace = 20;
        public int gasTank = 35;
        public int safety = 45;
    }
    class Tesla
    {
        public int acceleration = 95;
        public int topSpeed = 85;
        public int comfortFront = 80;
        public int comfortBack = 80;
        public int packingSpace = 100;
        public int battery = 100;
        public int safety = 90;
    }
}

