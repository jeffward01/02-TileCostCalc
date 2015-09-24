using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace _02_TileCostCalc
{
    class Program
    {

        public static void RestartQuestion()
        {

            Console.WriteLine("\n \n \n \n Program Completed... Retry? (yes/no)");

            string usersub = Console.ReadLine();
            string userconSub = usersub.ToLower();

            if (userconSub == "no")
            {
                Environment.Exit(0);
            }

            else if (userconSub == "yes")
            {



            }
            else { }
            while (userconSub != "yes" && userconSub != "no")
            {


                Console.WriteLine("\n \n \n \n Program Completed... Retry? (yes/no)");

                string user2sub = Console.ReadLine();
                string u1serconSub = user2sub.ToLower();

                if (u1serconSub == "no")
                {
                    Environment.Exit(0);
                }

                else if (u1serconSub == "yes")
                {
                    Console.WriteLine("Press Enter to exit and then reload your application");
                    Console.ReadLine();
                    Environment.Exit(0);
                }


            }
        }

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
                " and your total Sq Ft is " + jeffToolBox.RectangleSqFt(width1Len, length1Len) + "sqft.";

            return message;

                 
        }

        private void Main()
        {
            throw new NotImplementedException();
        }

        public static void  Intro()
        {
            Console.WriteLine("Welcome to the Tile Cost Calcualtor Application!");

            Console.WriteLine("Here we will evaluate the cost of your tile, and the dimsions of the room.");
            Console.WriteLine("You will find out the total cost of the Tile, and the Sq Feet of the room you are in. \n \n \n ");
            Console.WriteLine("Press enter to begin... ");


        }




        static void Main(string[] args)
        {

            //Ask if user is measuring tile for a Trianglur room, rectangle, or Circular
            Intro();
            Console.ReadLine();


            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n \n \n For a Rectangle/Scqure Room Your in luck! \n \n \n \n This software can help you, otherwise.. take a hike! \n \n \n \n Press Enter to Move on...");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Enter the cost of your tile per sq foot");


                    string tileCostInput = Console.ReadLine();
                    tileCostInput =  jeffToolBox.RemoveSpecialCharacters(jeffToolBox.RemoveLetters(tileCostInput.Replace("$", string.Empty)));
                    
                    //Check to see if numbers are present
                    //in not present get mad
                    if (tileCostInput == "")
                    {

                    //Error
                    Console.Clear();
                    Console.WriteLine( tileCostInput + "You did not enter a number.  Please enter a number a try again.  \n \n \n \n Press Enter to restart");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    //restrat program


                    }
                
                                  
                decimal tileCost = jeffToolBox.StringtoDecimal(tileCostInput);



                Console.WriteLine("\n \n Your tile cost per sq foot is: " + jeffToolBox.DecimalToDollar(tileCost) + ".\n");
          

                
                //Get input from user

              
                    try
                    {


                    string userInput = "rectangle";
                        string input = userInput.ToLower();

                        //Pending Users input execute either Rectangle, Tri, or Cir
                        switch (input)
                        {
                            case "rectangle":
                                string message = GetRectangleMeasurements(tileCost);
                            //insert quit or restart func
                                Console.WriteLine(message);
                                Console.ReadLine();
                            Console.WriteLine("Continue? (yes/no)");
                            string usersub = Console.ReadLine();
                            string userconSub = usersub.ToLower();

                            if (userconSub == "no")
                            {
                                Environment.Exit(0);
                            }


                            break;
                            case "triangle":
                                ;
                                break;
                            case "circular":
                                ;
                                break;
                            default:
                            
                            Console.WriteLine("-------------------\n "+input+" does not compute... \n");
                                Console.WriteLine("Invalid input, please check your spelling... foo \n \n Please spell correctly and try again. \n \n Press Enter to Restart");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    }
                    catch
                    {
                    Console.WriteLine("Continue? (yes/no)");
                    string usersub = Console.ReadLine();
                    string userconSub = usersub.ToLower();

                    if (userconSub == "no")
                    {
                        Environment.Exit(0);
                    }

                    Console.Clear();


                }

                //Return total sq feet, and cost of tile
                //Draw a Square or Tri or Cir
               
                
                    

                    
                        
                     

                    }
                }
              
                }
            }
        