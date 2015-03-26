using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNetGrasshopper
{
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
            currentPoints = 0;
        }

        // Adding points due to completing programs
        public void addProgramPoints(int pointsToAdd) // pointsToAdd is user input variable on # of programs completed
        {
            currentPoints += pointsToAdd;
            RankChangeCheck(currentPoints);
        }

        private void RankChangeCheck(int points)
        {
            if (points >= 20)
                currentRank = Levels.Jedi;
            else if (points >= 15)
                currentRank = Levels.Ninja;
            else if (points >= 10)
                currentRank = Levels.RockStar;
            else if (points >= 5)
                currentRank = Levels.Journeyman;
        }



    } // Ends Student Class    
} // Ends Namespace
