using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4pd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            navigationBar();
        }
        static void menu()
        {
            Console.WriteLine("1-Add Ship");
            Console.WriteLine("2-View Ship Position");
            Console.WriteLine("3-vView Ship Serial Number");
            Console.WriteLine("4-Change Shipo Position ");
            Console.WriteLine("5-Exit ");
        }

        static int getOption()
        {
            Console.WriteLine("Enter Option ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static void navigationBar()
        {
            List<Ship> ships = new List<Ship>();
            int opt = getOption();
            while (opt != 5)
            {
                if (opt == 1)
                {
                    addShip(ships);
                }
                else if (opt == 2)
                {
                    viewShipPosition(ships);
                }
                else if (opt == 3)
                {
                    viewSerialNumber(ships);
                }
                else if (opt == 4)
                {
                    changeShipPosition(ships);
                }
                Console.Clear();
                menu();
                opt = getOption();
            }
        }
        static void addShip(List<Ship> ships)
        {
            Console.WriteLine("add ship work ");
            Console.WriteLine("Enter Ship Number ");
            String shipNumber = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude ");
            Console.WriteLine("Enter latitude Degree ");
            int lattitudeDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter latitude Minute ");
            float lattitudeMinute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter latitude Direction ");
            String Direction = Console.ReadLine();
            char lattitudeDirection = Direction[0];
            //data for lattitude
            Angle lattitude = new Angle(lattitudeDegree, lattitudeMinute, lattitudeDirection);
             Console.WriteLine(lattitude.displayAngleValue());

            Console.WriteLine("Enter Ship Logitude ");
            Console.WriteLine("Enter logitude Degree ");
            int logitudeDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter latitude Minute ");
            float logitudeMinute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter logitude Direction ");
            String logDirection = Console.ReadLine();
            char logitutudeDirection = logDirection[0];
            //data for logitude
            Angle logitutde = new Angle(logitudeDegree, logitudeMinute, logitutudeDirection);


            Ship s1 = new Ship(shipNumber, lattitude, logitutde);
            ships.Add(s1);

        }

       static void viewShipPosition(List<Ship> ships)
        {
            Console.WriteLine("Enter serial Nunebr ");
            String serialNumebr = Console.ReadLine();
           bool exist= serialNumberExist(ships, serialNumebr);
            if (exist)
            {
                foreach (Ship ship in ships)
                {
                    if (ship.shipNumber == serialNumebr)
                    {
                      String post= ship.shipPosition(ship.lattitude, ship.longitude);
                        Console.WriteLine(post);
                    }
                }
            }
           
        }
        static bool serialNumberExist(List<Ship> shipList, String shipNumber)
        {
            foreach (Ship ships in shipList)
            {
                if (ships.shipNumber == shipNumber)
                {
                    return true;
                }
            }
            return false;
        }
        static void viewSerialNumber(List<Ship> ships)
        {
            foreach (Ship ship in ships)
            {
               Console.WriteLine(ship.shipPosition(ship.lattitude, ship.longitude));
                Console.WriteLine("serial number "+ship.shipNumber);
            }
            Console.ReadKey();
        }
        static void changeShipPosition(List<Ship> ships)
        {
            Console.WriteLine("Enter the serial number ");
            String serialNumber = Console.ReadLine();
            bool exist = serialNumberExist(ships, serialNumber);
            if (exist)
            {
                foreach(Ship ship in ships)
                {
                    //fetch the specific object
                    if (ship.shipNumber == serialNumber)
                    {
                        Console.WriteLine("Data for lattitude ");
                        Console.WriteLine("Enter degree lattitude ");
                        ship.lattitude.degree = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter minute lattitude ");
                        ship.lattitude.minutes = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter direciton lattitude ");
                        String dir = Console.ReadLine();
                        char lattitdeDirection = dir[0];
                        ship.lattitude.direction = lattitdeDirection;

                        Console.WriteLine("Data for logitude ");
                        Console.WriteLine("Enter degree lognitude ");
                        ship.longitude.degree = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter minute lognitude ");
                        ship.longitude.minutes = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter direciton lattitude ");
                        String dir2 = Console.ReadLine();
                        char lattitdeDirection2 = dir2[0];
                        ship.lattitude.direction = lattitdeDirection2;



                    }
                }
            }
            else
            {
                Console.WriteLine("Enter correct Serial number ");
            }
        }
    }
}
