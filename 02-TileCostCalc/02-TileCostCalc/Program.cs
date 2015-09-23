using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02_TileCostCalc
{
    class Program
    {
        public static string GetRectangleMeasurements(decimal cost)
        {

            Console.WriteLine("Enter your Width of side 1 (Example: 100 feet)");
            string width1 = Console.ReadLine();
            width1 = jeffToolBox.RemoveLetters(width1);

            decimal width1Len = jeffToolBox.StringtoDecimal(width1);

            Console.WriteLine("Enter your Length of side 2 (Example: 100 feet)");
            string length1 = Console.ReadLine();
            length1 = jeffToolBox.RemoveLetters(width1);
            decimal length1Len = jeffToolBox.StringtoDecimal(length1);

            string finalMeasurement = jeffToolBox.RectangleMath(width1Len, length1Len, cost);

            string message = "The total cost to Tile your floor is " + finalMeasurement +
                " and your total Sq Ft is " + jeffToolBox.RectangleSqFt(width1Len, length1Len) +"sqft.";

            return message;
        }
        static void Main(string[] args)
        {
            //Ask if user is measuring tile for a Trianglur room, rectangle, or Circular
            Console.WriteLine("Welcome to the Tile Cost Calcualtor Application!");

            Console.WriteLine("Here we will evaluate the cost of your tile, and the dimsions of the room.");
            Console.WriteLine("You will find out the total cost of the Tile, and the Sq Feet of the room you are in. \n \n ");

            Console.WriteLine("Enter the cost of your tile per foot");
            string tileCostInput = Console.ReadLine();
            tileCostInput = jeffToolBox.RemoveLetters(tileCostInput.Replace("$", string.Empty));

            decimal tileCost = jeffToolBox.StringtoDecimal(tileCostInput);

            Console.WriteLine("Your tile cost per sq foot is: " + jeffToolBox.DecimalToDollar(tileCost) + ".");


            Console.WriteLine("Is your room a Rectangle/Square, Triangle or a Circle? \n");
            Console.WriteLine("For Triangle Enter: Triangle");
            Console.WriteLine("For a Square/Rectangle Enter: Rectangle");
            Console.WriteLine("For a Circular room Enter: Circle");
            //Get input from user

            while (true)
            {
                try
                {


                    string userInput = Console.ReadLine();
                    string input = userInput.ToLower();

                    //Pending Users input execute either Rectangle, Tri, or Cir
                    switch (input)
                    {
                        case "rectangle":
                            string message = GetRectangleMeasurements(tileCost);
                            Console.WriteLine(message);
                            Console.ReadLine();
                            break;
                        case "triangle":
                            ;
                            break;
                        case "circular":
                            ;
                            break;
                        default:
                            Console.WriteLine("Invalid input, please check your spelling... foo.");
                            break;
                    }

                }
                catch
                {
                    

                }

                //Return total sq feet, and cost of tile
                //Draw a Square or Tri or Cir

                Console.WriteLine("Exit? (y/n)");
                string uservalue = Console.ReadLine();

                if (uservalue == "y")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
