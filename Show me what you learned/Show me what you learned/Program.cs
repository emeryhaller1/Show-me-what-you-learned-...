using System;
using System.Collections.Generic;
using System.IO;

namespace Show_me_what_you_learned
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE
            //Sarah is a TA for a 9th grade English teacher named Mrs. Smith. 
            //Mrs. Smith wants Sarah to create a platform in which the students can view their English grade and whether or not they have 
            //taken the mandatory state final yet.


            double grade;
            string answer;
            string input;



            Student Student1 = new Student();

            Console.WriteLine("Hello! Welcome to the portal for Mrs. Smith's English Class.");
            Console.WriteLine("Please enter your last name.");
            Student1.LastName = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your first name.");
            Student1.FirstName = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your studentID.");
            Student1.StudentID = Convert.ToInt32(Console.ReadLine());

            {
                Console.WriteLine("Have you taken the state test? yes or no");
                string USERINPUT = Console.ReadLine();

                if (USERINPUT == "yes")
                {
                    Student1.StateTest = true;
                }
                else
                {
                    Student1.StateTest = false;
                }
            }


            {
                Console.WriteLine("Please enter in your number grade for the class.");
                grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 90)
                {
                    Student1.EnglishGrade = "A";
                }
                else if (grade >= 80)
                {
                    Student1.EnglishGrade = "B";
                }
                else if (grade >= 70)
                {
                    Student1.EnglishGrade = "C";
                }
                else if (grade >= 60)
                {
                    Student1.EnglishGrade = "D";
                }
                else if (grade >= 0)
                {
                    Student1.EnglishGrade = "F";
                }
                else
                {
                    Student1.EnglishGrade = "N/A";
                }

            }
            Console.WriteLine($"Hello {Student1.FirstName} {Student1.LastName}, ({Student1.StudentID})");
            Console.WriteLine($"\nTaken the state test (Y/N): {Student1.StateTest}");
            Console.WriteLine($"\nGrade in Mrs.Smith's English Class: {Student1.EnglishGrade}");



            //PART THREE
            //The last request Mrs. Smith makes is that Sarah also allows students to input as many of their favorite snacks as they would like. 
            //The program should keep asking the students for snacks until they indicate they are done.
            //After they indicate they are done the program should output a random number to represent the students place in line for yearbook signing. 


            string SNACKINPUT;
            string SNACK;

            do
            {
                Console.WriteLine("Hello! Please enter a snack you love!");
                SNACK = Console.ReadLine();
                Student1.AddSnacks(SNACK);

                Console.WriteLine("Would you like to enter another snack? yes or no.");
                SNACKINPUT = Console.ReadLine();

            } while (SNACKINPUT == "yes");

            Student1.DisplaySnacks();




            //PART TWO
            // Mrs.Smith also wants the program to ask the student to enter in the word of the week.
            //The program must output to the user the word in reverse and in the color green.
            //Additionally, all the vowels in the user’s word must be replaced with “!”. 

            Console.WriteLine("Please enter the word of the week!");
            input = Console.ReadLine().ToLower();

            int reverseWORD = input.Length;


            Console.WriteLine(reverseWORD);

            input = input.Replace("a", "!").Replace("e", "!").Replace("i", "!").Replace("o", "!").Replace("u", "!");

            Console.WriteLine($"{input}");


            //Part FOUR

            Console.WriteLine("You are almost done! Yearbook sign up is next week, so we are going to assign you a spot to go!");

            Random rand = new Random();
            int randomNBR = rand.Next(1, 20); //there are 19 people in this class

            Console.WriteLine($"Your spot in line for yearbook signing is {randomNBR} out of 19!!");


            //Part FIVE
            //Answer this question correct about Mrs. Smith for bonus points!
            Console.WriteLine("Answer the question below about Mrs. Smith for BONUS POINTS!");
            Console.WriteLine("Mrs.Smith's favorite color is red. true or false");
            string CorrectAnswer = Console.ReadLine();

            double Points = 0;
            if (CorrectAnswer.ToLower() == "true")
            {
                Points = Points + 1;
            }
            else if (CorrectAnswer.ToLower() == "false")
            {
                Points = Points + 0;
            }
            else
            {
                Console.WriteLine("Sorry, your input is not valid.");
                Environment.Exit(-1);
            }

            Console.WriteLine($"You earned {Points.ToString("G0")} bonus points toward your final!");


            //Part SIX

            string[] linesOfFile = File.ReadAllLines("MISexcelEC.csv");

            for (int i = 1; i < linesOfFile.Length; i++)
            {
                string currentLineOfFile = linesOfFile[i].ToLower();
                //StudentID,LastName,FirstName,EnglishGrade,StateTest(Y/N)

                string[] pieces = currentLineOfFile.Split(",");

                string FirstName = pieces[2];

                string LastName = pieces[1];
                double ID= Convert.ToInt32(pieces[0]);
                string EngGrade = pieces[3];
                string StateTest = pieces[4];

                Console.WriteLine($"{LastName}, {FirstName}({ID}) - ENG Grade:{EngGrade}. State Test(Y/N): {StateTest}.");

              
            }

        }
    }
}






