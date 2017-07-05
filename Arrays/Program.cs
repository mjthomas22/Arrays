using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initalinzing
            int[] myFirstArray;

            //declaring and intializing a second array
            string[] myStringArray = { "First", "Second", "Third", "Fourth" };

            // declare and intialize a char array with the letters of your last name.
            char[] myCharArray = { 'T', 'h', 'o', 'm', 'a', 's' };

            //I want my console to print three elements of my array

            Console.WriteLine(myCharArray[0]);
            Console.WriteLine(myCharArray[3]);
            Console.WriteLine(myCharArray[1]);

            //create the following arrays and print using the correct index numbers
            //Array of top ten vacations spots, print the first and last

            String[] topVacation = { "Rome", "Cancun", "London", "Miami", "Orlando", "San Franciso", "Mytle Beach", "Branson", "Paris", "New York" };

            Console.WriteLine(topVacation[0]);
            Console.WriteLine(topVacation[9]);

            //Array of ages of three children you know print each childs age

            int[] childsAges = { 6, 1, 3 };
            Console.WriteLine(childsAges[0]);
            Console.WriteLine(childsAges[1]);
            Console.WriteLine(childsAges[2]);
            //Array of GPAs on a 4.0 scale of 8 students - you don't have to print

            double[] gpa = { 1, 1.2, 2, 4, 3.5, 3, 2.8, 3.2 };

            //Array of of the first letter of 4 of your classmates names that are sitting near you print all four on the same line

            char[] firstLetter = { 'C', 'J', 'S', 'M' };
            Console.WriteLine("{0}, {1}, {2}, {3}",firstLetter[0], firstLetter[1], firstLetter[2], firstLetter[3]);



        }
    }
}
