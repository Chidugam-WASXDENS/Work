using System;
using System.Runtime.InteropServices;

namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int allowed_height = 140;
            //int allowed_age = 11;

            //Console.WriteLine("How old are you");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("How tall are you?");
            //int height = int.Parse(Console.ReadLine());

            //if (age < allowed_age || height < allowed_height)
            //{
            //    Console.WriteLine("You cannot go on this ride");

            //}
            //else
            //{
            //    Console.WriteLine("You are allowed on this ride, have fun!");
            //}

            //Console.WriteLine("What is the total cost of your items???");
            //double price = double.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have a membership? Press Y or N");
            //string membership = Console.ReadLine();
            //if (membership == "Y")
            //{
            //    Console.WriteLine("Your price is reduced by 20%");
            //    price = price * 0.8;
            //    price = Math.Round(price, 2);
            //}
            //else
            //{
            //    Console.WriteLine("Your price is not reduced");
            //}
            //Console.WriteLine("Your total price is " + price);

            Console.WriteLine("Do you want me to calculate the area of a square or a circle? Type square or circle";
            string shape = Console.ReadLine();
                if ( shape == "circle")
            {
                Console.WriteLine("What is the radius of the circle");
                double radius = double.Parse(Console.ReadLine());
                double c_area = radius * radius * 3.142;
                Console.WriteLine("The area of your circle is: " + c_area+" cm2");
            }   else if ( shape == "square")
            {
                Console.WriteLine("What is the length of the square?");
                double length = double.Parse(Console.ReadLine());
                double s_area = length * length;
                Console.WriteLine("The area of your circle is " + s_area+ " cm2"
            }





        }
    }
}
