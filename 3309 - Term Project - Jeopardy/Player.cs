using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class Player
    {
        int id;
        String name;
        int points;
        String chosenCategory;
        int chosenPoint;
        String answer;

        public Player(int id, String name)
        {
            this.id = id;  
            this.name = name;
            this.points = 0;
            this.chosenCategory = null;
            this.chosenPoint = 0;
            this.answer = null;
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public int Points { get; set; } 
        public string ChosenCategory { get; set; }
        public int ChosenPoint { get; set; }
        public String Answer { get; set; }
    }
}
