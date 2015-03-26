using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNetGrasshopper
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointToAdd = new int();
            Student myStudent = new Student();

            Console.WriteLine("You are a lowly Beginner .NET student.");
            Console.Write("How many programs did you write today? ");
            pointToAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("The work you did today makes you a {0} level student", myStudent.level);


        }
    }

    
}
