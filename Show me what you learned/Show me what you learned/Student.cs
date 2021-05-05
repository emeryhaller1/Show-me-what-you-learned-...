using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Show_me_what_you_learned
{
    public class Student
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public bool StateTest { get; set; }
        public string EnglishGrade { get; set; }
        public List<string> FavoriteSnacks { get; set; }


        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentID = 0;
            StateTest = false;
            EnglishGrade = string.Empty;
            FavoriteSnacks = new List<string>();
        }

        public Student(int studentID)
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentID = studentID;
            StateTest = false;
            EnglishGrade = string.Empty;
            FavoriteSnacks = new List<string>();
        }

        public Student(string FIRSTname, string LASTname)
        {
            FirstName = FIRSTname;
            LastName = LASTname;
            StudentID = 0;
            StateTest = false;
            EnglishGrade = string.Empty;
            FavoriteSnacks = new List<string>();
        }

        public override string ToString()
        {
            string results = $" Hello {FirstName} {LastName}, ({StudentID}). Taken the state test (Y/N): {StateTest}.";

            if (StateTest)
            {
                results += "Yes";
            }
            else
            {
                results += "No";
            }

            return results;
        }

        public void DisplaySnacks()
        {
            foreach (string Snack in FavoriteSnacks)
            {
                Console.WriteLine(Snack);
            }
        }

        public void AddSnacks(string newSnack)
        {
            FavoriteSnacks.Add(newSnack);
        }

    }
}
