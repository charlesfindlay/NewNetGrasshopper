using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNetGrasshopper
{
    class Program
    {
        static List<Student> studentsNames = new List<Student>();

        static void Main(string[] args)
        {
            int pointToAdd = new int();            
            AddStudents();
            string userName = Console.ReadLine();

            Student myStudent = FindName(userName); //studentsNames.Find(s => s.name == userName);


            Console.WriteLine("{0}, you are a lowly Beginner .NET student.", myStudent.name);
            Console.Write("How many programs did you write today? ");
            pointToAdd = int.Parse(Console.ReadLine());

            myStudent.addProgramPoints(pointToAdd);
            Console.WriteLine("The programs you wrote today makes you a {0} level student", myStudent.level);
            Console.WriteLine();
            
            Console.Write("Did you help a fellow student today? (y or n): ");
            string helpful = Console.ReadLine();
             int helpfulPoints = 0;
            if (helpful == "y")
            {
                myStudent.HelpfulStudent();
                helpfulPoints = 10;
            }

            Console.WriteLine();
            Console.WriteLine("Today you earned:");
            Console.WriteLine("{0} program writing points", pointToAdd);
            Console.WriteLine("{0} classmate helping points", helpfulPoints);
            Console.WriteLine("For a total of {0} points today", pointToAdd + helpfulPoints);
            Console.WriteLine();            
            
            // todayRank = myStudent.level.ToString();
            if (myStudent.level.ToString() == "Jedi")
            {
                Console.WriteLine("You have mastered .NET by becoming a jedi and may now know the BIG secret.");
                Console.WriteLine("You live in the matrix, and this computer is your father.");
            }
            else
                Console.WriteLine("Your final rank for today is {0}", myStudent.level);
        }

        public static Student FindName(string name)
        {
            foreach (var student in studentsNames)
                if (student.name == name)
                    return student;
            return null;
        }

        public static void AddStudents()
        {
            string[] fNames = { "Charles", "Seth", "Jonathan", "Keonna", "Mark" };            
            foreach (string item in fNames)
            {
                Student myStudent = new Student(item);
                myStudent.name = item;
                studentsNames.Add(myStudent); //add current student name to list
            }
        }


    } // End Program Class

    

    
}
