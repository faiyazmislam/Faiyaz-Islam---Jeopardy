using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class Question
    {
        String query;
        int point;
        String answer;

        public Question(String query, int point, String answer)
        {
            this.query = query;
            this.point = point;
            this.answer = answer;
        }

        public String Query { get; set; }
        public int Point { get; set; }
        public String Answer { get; set; }
    }
}
