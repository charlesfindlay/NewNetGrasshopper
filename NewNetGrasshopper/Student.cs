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
        private int programPoints;
        private int totalPoints;
        private int helperPoints;
        
        public enum Levels
        {
            Beginner,
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
            currentRank = Levels.Beginner;
            totalPoints = 0;
        }

        // Adding points due to completing programs
        public void addProgramPoints(int pointsToAdd) // pointsToAdd is user input variable on # of programs completed
        {
            programPoints += pointsToAdd;
            RankChangeCheck();
        }

        private void RankChangeCheck()
        {
            totalPoints = programPoints + helperPoints;
            if (totalPoints >= 25)
                currentRank = Levels.Jedi;
            else if (totalPoints >= 20)
                currentRank = Levels.Ninja;
            else if (totalPoints >= 15)
                currentRank = Levels.RockStar;
            else if (totalPoints >= 10)
                currentRank = Levels.Journeyman;
            else if (totalPoints >= 5)
                currentRank = Levels.Grasshopper;
        }

        public void HelpfulStudent()
        {
            helperPoints += 10;
            RankChangeCheck();
        }


    } // Ends Student Class    
} // Ends Namespace
