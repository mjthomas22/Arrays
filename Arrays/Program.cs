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
            ////declaring an array without initalinzing
            //int[] myFirstArray;

            ////declaring and intializing a second array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };

            //// declare and intialize a char array with the letters of your last name.
            //char[] myCharArray = { 'T', 'h', 'o', 'm', 'a', 's' };

            ////I want my console to print three elements of my array

            //Console.WriteLine(myCharArray[0]);
            //Console.WriteLine(myCharArray[3]);
            //Console.WriteLine(myCharArray[1]);

            ////create the following arrays and print using the correct index numbers
            ////Array of top ten vacations spots, print the first and last

            //String[] topVacation = { "Rome", "Cancun", "London", "Miami", "Orlando", "San Franciso", "Mytle Beach", "Branson", "Paris", "New York" };

            //Console.WriteLine(topVacation[0]);
            //Console.WriteLine(topVacation[9]);

            ////Array of ages of three children you know print each childs age

            //int[] childsAges = { 6, 1, 3 };
            //Console.WriteLine(childsAges[0]);
            //Console.WriteLine(childsAges[1]);
            //Console.WriteLine(childsAges[2]);
            ////Array of GPAs on a 4.0 scale of 8 students - you don't have to print

            //double[] gpa = { 1, 1.2, 2, 4, 3.5, 3, 2.8, 3.2 };

            ////Array of of the first letter of 4 of your classmates names that are sitting near you print all four on the same line

            //char[] firstLetter = { 'C', 'J', 'S', 'M' };
            //Console.WriteLine("{0}, {1}, {2}, {3}",firstLetter[0], firstLetter[1], firstLetter[2], firstLetter[3]);

            ////dataType[] nameOfArray = new dataType[#ofElements]; 
            //int[] numberOfSeats = new int[21]; 
            //string[] studentsInClass = new string[21];

            ////nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student");
            //studentsInClass[1] = Console.ReadLine();

            //Console.WriteLine("Please enter the age of the person in the first seat");
            //int[] ageOfStudents = new int[21];
            //ageOfStudents[0] = int.Parse (Console.ReadLine());

            //string[] restuarantsInMall = { "Subway", "Dunkin Donuts", "Saki", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restuarantsInMall.Length);

            ////For Review
            //int[] intVariable;
            // //Declare array when i know the elements
            //char[] letterInFirstName = { 'D', 'a', 'n', 'i', 'e', 'l' };
            ////Decalre and intiaize when I do not know the elements
            //string[] unKnown = new string[5];

            ////To Practice using .Length, create a char array of letter in your middle name
            //// and print # of chars to the console.

            //char[] middleName = { 'J', 'o', 's', 'e', 'p', 'h' };
            //Console.WriteLine(middleName.Length);

            ////decalre and intialize a string array.
            ////using a length property, print the second to last element in the array

            //string[] food = { "pizza", "wings", "burgers", "hotdogs" };
            //int number = food.Length;
            //Console.WriteLine(food[number - 2]);

            ////Index of is a method used to search an array for a specified value and returns the index postion of the first matching value found

            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array for a specified vaulue and returns the index position of the last matching value found
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver,1985));

            ////Reverse Method
            //int[] palindrome = { 1, 2, 3, 4, 5, 6, 7, };
            //Console.WriteLine(palindrome[0]);
            //Array.Reverse(palindrome);
            //Console.WriteLine(palindrome[0]);

            //Sort 
            //Will sort numbers in an arrat from lowest to highest
            //Will sort char's and strings in alphabetical order from A-Z
            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            //Declare and initialize a string array of first names. Choose a name to find a print Index of.
            string[] firstNames = { "Mike", "Frank", "Steve", "Beth", "Carl" };
            Console.WriteLine(Array.IndexOf(firstNames, "Steve"));

            //Create an array of lucky numbers. Each number should repeat at least once. Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 7, 13, 16, 34, 12, 23, 23, 12, 13, 34, 7, 16 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 12));

            //Create an array of alphabet characters. Print the first index of the array. Now reverse the array and print the first index.
            char[] alpha = { 'a', 'd', 'f', 'r', 'e' };
            Console.WriteLine(alpha[0]);
            Array.Reverse(alpha);
            Console.WriteLine(alpha[0]);

            //Create an array of student names in random order. Order the students’ names using the sort method. Print the first and last students’ names.
            string[] studentNames = { "Michael Thomas", "Jason Lee", "Bruce Wayne", "General Lee", "Steve Martin" };
            Array.Sort(studentNames);
            Console.WriteLine("{0}, {1}", studentNames[0], studentNames[studentNames.Length - 1]);

            //Ask 10 people for their favorite numbers and create an array of those numbers. Order the numbers using the sort method. Print the first and last numbers.
            int[] favoriteNumbers = { 13, 12, 67, 34, 12, 54, 234, 1, };
            Array.Sort(favoriteNumbers);
            Console.WriteLine("{0},{1}", favoriteNumbers[0],favoriteNumbers[firstNames.Length - 1]);
        }
    }
}
