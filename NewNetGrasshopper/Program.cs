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
        }
    }

    public class Student
    {
        private Levels currentRank;
        private int currentPoints;
        
        public enum Levels
        {
            Grasshopper,
            Journeyman,
            RockStar,
            Ninja,
            Jedi
        }
        public Levels level
        {
            get { return currentRank; }
        }
        
        //Constructor for Student class
        public Student()
        {
            currentRank = Levels.Grasshopper;
        }
    }



}
