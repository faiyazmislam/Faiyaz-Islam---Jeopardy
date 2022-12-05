using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    public class Player
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public int PlayerScore { get; set; } 
        public string ChosenCategory { get; set; }
        public int ChosenPoint { get; set; }

        public Player(int id, String name)
        {
            this.Id = id;  
            this.Name = name;
            this.PlayerScore = 0;
            this.ChosenCategory = null;
            this.ChosenPoint = 0;
        }
    }
}
