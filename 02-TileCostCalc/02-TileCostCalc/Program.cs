using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TileCostCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask if user is measuring tile for a Trianglur room, rectangle, or Circular
            Console.WriteLine("Welcome to the Tile Cost Calcualtor Application!");
            Console.WriteLine("Here we will evaluate the cost of your tile, and the dimsions of the room.");
            Console.WriteLine("You will find out the total cost of the Tile, and the Sq Feet of the room you are in. \n \n ");
            Console.WriteLine("Is your room a Rectangle/Square, Triangle or a Circle?");
            Console.WriteLine("For Triangle Enter: Triangle");
            Console.WriteLine("For a Square/Rectangle Enter: Rectangle");
            Console.WriteLine("For a Circular room Enter: Circle");
            string userInput = Console.ReadLine();
            string input = userInput.ToLower();
            
            //Get input from user 
            //Pending Users input execute either Rectangle, Tri, or Cir
            //Return total sq feet, and cost of tile
            //Draw a Square or Tri or Cir

        }
    }
}
