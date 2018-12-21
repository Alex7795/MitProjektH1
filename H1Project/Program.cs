using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MitProjektH1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database = H1Project;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM Cars";

            MySqlCommand commandsDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandsDatabase.ExecuteReader();

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
                    "+ Decent handling \n" +
                    "- Slow acceleration \n" +
                    "- Poor topspeed \n" +
                    "\n" +
                    "Car 2: Porsche 911 4 seater \n" +
                    "+ Fast acceleration \n" +
                    "+ High topspeed \n" +
                    "+ Great comfort in the front \n" +
                    "+ Great handling \n" +
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
                    "- Not the greatest handling \n" +
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
                        methods.Questions("SELECT * FROM Cars WHERE ID = 1");
                        Console.ReadKey();
                        break;
                    case "2":
                        porscheIsRunning = true;
                        Console.WriteLine("You've chosen the Porsche");
                        methods.Questions("SELECT * FROM Cars WHERE ID = 2");
                        Console.ReadKey();
                        break;
                    case "3":
                        teslaIsRunning = true;
                        Console.WriteLine("You've chosen the Tesla");
                        methods.Questions("SELECT * FROM Cars WHERE ID = 3");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Are you sure you picked a number from 1-3?");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();

            }
        }
    }

    class methods
    {
        public void Questions(string query)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database = H1Project;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandsDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandsDatabase.ExecuteReader();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You're driving down a road, suddenly a car comes blasting from your right \n" +
                "What is your reaction? \n" +
                "\n" +
                "1. Quickly gas up and try to prevent getting hit \n" +
                "2. Brake and pray he swerves around you, or manages to brake in time");

            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    reader.Read();
                    if (reader.GetInt32(5) > 50)
                    {
                        Console.WriteLine("Smart moves, your car was fast enough to speed out of the trouble!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your car doesnt accelerate fast enough, your family trip ends in misery");
                        return;
                    }

                case "2":
                    reader.Read();
                    if (reader.GetInt32(8) > 50)
                    {
                        Console.WriteLine("The guy driving was DUI. But since you chose a car with good safety points \n" +
                            "You're all still alive! However the trip took an extra 6 hours to complete");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("The guy driving was DUI. Your cars safety rating isn't great \n" +
                            "Your family trip ends in misery");
                        Console.ReadKey();
                        return;
                    }
                default:
                    Console.WriteLine("Are you sure you picked a number from 1-3?");
                    Console.ReadKey();
                    break;

            }

            Console.WriteLine("You've started to overtake another car. It's dark and you realize that the oncoming cars light is out \n" +
            "What is your reaction? \n" +
            "\n" +
            "1. Speed up and quickly get in front of the car you were overtaking \n" +
            "2. Try to brake and reposition yourself behind the car you were overtaking \n" +
            "3. Try to swerve left into the ditch and that way evade the oncoming car");

            string input2 = Console.ReadLine();
            Console.Clear();
            switch (input2)
            {
                case "1":
                    reader.Read();
                    if (reader.GetInt32(5) > 89)
                    {
                        Console.WriteLine("Man that was close, The guy almost hit you! luckily your acceleration saved you and your family");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your car isn't fast enough, and you hit the oncomiong car head on \n" +
                            "Your family trip ends in misery");
                        return;
                    }

                case "2":
                    reader.Read();
                    if (reader.GetInt32(9) > 60)
                    {
                        Console.WriteLine("You chose the right car for this manouver! Your cars handling is great \n" +
                            "and you therefore manages to brake and get in behind the car in safety");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your cars handling is too poor, and you therefore didn't make it in time");
                        Console.ReadKey();
                        return;
                    }

                case "3":
                    Console.WriteLine("Why did you think the ditch was a good option? \n" +
                        "You hit a huge rock and totalled your car. \n" +
                        "Your family trip ends in misery");
                    Console.ReadKey();
                    return;

            }
            Console.Clear();
            Console.WriteLine("you've missed the gastank/chargingstation you wanted to pull in at \n" +
                "your fuel/battery gauge is low. \n" +
                "what do you do? \n" +
                "\n" +
                "1. Keep driving until you meet another gas station \n" +
                "2. Take the next exit on the freeway, turn around, and go back \n" +
                "3. Ignores the fuel/battery gauge");

            string input3 = Console.ReadLine();
            Console.Clear();
            switch (input3)
            {
                case "1":
                    reader.Read();
                    if (reader.GetInt32(7) > 50)
                    {
                        Console.WriteLine("You managed to find another gasstation before you ran out. \n" +
                            "You may continue your trip.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your car ran out of fuel! you and the family is now stuck in the middle of the freeway. \n" +
                            "a guy behind you haven't seen you and smashes his truck right in the rear of your car \n" +
                            "Your family trip ends in misery");
                        return;
                    }

                case "2":
                    {
                        Console.WriteLine("Good call! Better be safe than sorry");
                        Console.ReadKey();
                        break;
                    }

                case "3":
                    Console.WriteLine("Why would you ignore your fuelgauge? You've run out of fuel \n" +
                        "A truck who's driver is on the phone, haven't seen you standing still on the freeway \n" +
                        "Your family trip ends in misery");
                    Console.ReadKey();
                    return;
            }
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
        public int handling = 70;
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
        public int handling = 100;
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
        public int handling = 45;
    }
}