using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class Question
    {
        //String query;
        //int point;
        //String answer;

        public String Query { get; set; }
        public int PointValue { get; set; }
        public String Answer { get; set; }

        public Question() { }

        public Question(String query, int pointValue, String answer)
        {
            this.Query = query;
            this.PointValue = pointValue;
            this.Answer = answer;
        }
    }
}
