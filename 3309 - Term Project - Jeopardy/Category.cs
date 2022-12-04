using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    public class Category
    {
        public String CategoryName { get; set; }
        public List<Question> QuestionList { get; set; }

        public Category() { }

        public Category(string categoryName, List<Question> questionList)
        {
            this.CategoryName = categoryName;
            this.QuestionList = questionList;
        }

        public Question FindQuestion(int point) //note: in a list of question, point is an identification
        {
            foreach (Question question in QuestionList)
            {
                if(question.PointValue == point) { return question; }
            }
            return null;
        }
    }
}
