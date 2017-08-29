using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            //DataType[] nameOfArray = { elements };
            //initialize array below
            //int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            //Console.WriteLine(students[4]);
            //Console.WriteLine(students[0]);

            //create an array of top 10 vacation spots
            //print out the 1st and last
            //string[] vacationSpots = { "Hawaii", "Saint Lucia", "Aruba", "Alaska", "Mexico", "Japan", "Califronia", "Florida", "Toronto", "Chicago" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);
            //Console.WriteLine(vacationSpots[vacationSpots.Length - 1]);

            //create an array of ages of 3 children
            //print each childs age
            //int[] children = { 3, 2, 5 };
            //Console.WriteLine(children[0]);
            //Console.WriteLine(children[1]);
            //Console.WriteLine(children[2]);

            //GPA on 4.0 scale of 8 students
            //When you DON'T KNOW the elements of your array up front
            //dataT ype[] nameOfArray = new dataType[#ofElements]; 
            //float[] gpa = new float[8];
            //gpa[0] = 4.0f;
            //gpa[1] = 3.5f;
            //gpa[3] = 3.0f;

            //first letter of your peers names who are sitting near year
            //char[] letter = { 'b', 'a', 'j' };
            //Console.WriteLine(letter);

            //Declare and Initialize an array for the days of the week
            //string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


            ////Declare and Initialize an array of student ages using the NEW keyword
            //int[] studentAges = new int[3];
            //studentAges[0] = 15;
            //studentAges[1] = 25;
            //studentAges[2] = 28;

            //Console.WriteLine(daysOfTheWeek.Length);
            //daysOfTheWeek.SetValue("Funday", 0);
            //Console.WriteLine(daysOfTheWeek[0]);

            string[] birthMonths = { "December", "July", "May", "July" };
            Console.WriteLine(Array.IndexOf(birthMonths, "May"));
            Console.WriteLine(Array.LastIndexOf(birthMonths, "July"));

            //int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            //Console.WriteLine(numbers[0]);
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length-1]);

            //Declare and initialize a string array of first names.Choose a name to find and print the IndexOf.
            //string[] firstNames = { "Sonja", "SaVon", "Damon", "Patricia" };
            //Console.WriteLine(Array.IndexOf(firstNames, "SaVon"));
            //Console.WriteLine(Array.LastIndexOf(firstNames, "Damon"));
            string[] firstNames = new string[5];
            firstNames[0] = "Sonja";
            firstNames[1] = "SaVon";
            firstNames[2] = "Damon";
            firstNames[3] = "Pat";
            firstNames[3] = "Patricia";

            Console.WriteLine(Array.IndexOf(firstNames, "Patricia"));
           
           //Create an array of lucky numbers. Each number should repeat at least once.
            //Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 46, 17, 39, 18, 46, 17, 39, 18 };
            Array.Sort(luckyNumbers);
            Console.WriteLine(luckyNumbers[luckyNumbers.Length - 1]);

            //Create an array of alphabet characters. Print the first index of the array.
            //Now reverse the array and print the first index.
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(alphabet[0]);
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet[0]);

            //Create an array of student names in random order. Order the students’ names using the sort method.
            //Print the first and last students’ names.
            //string[] studentsInClass = { "Dana", "Moreen", "Jody", "Ray", "adam" };
            //Console.WriteLine(studentsInClass[0]);
            //Array.Sort(studentsInClass);
            //Console.WriteLine(studentsInClass[0]);

            int[] favNumbers = { 15, 7, 22, 5, 43, 45, 23, 3, 42, 17 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0] + " " + favNumbers[favNumbers.Length - 1]);


            //Ask 10 people for their favorite numbers and create an array of those numbers.
            //Order the numbers using the sort method.Print the first and last numbers.


        }
    }
}
