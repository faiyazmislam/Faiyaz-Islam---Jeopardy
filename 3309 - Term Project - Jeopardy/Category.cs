using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class Category
    {
        String categoryName;
        List<Question> questionList;

        public Category(string categoryName, List<Question> questionList)
        {
            this.categoryName = categoryName;
            this.questionList = questionList;
        }

        public String CategoryName { get; set; }
        public List<Question> QuestionList { get; set; }

        public Question FindQuestion(int point) //note: in a list of question, point is an identification
        {
            foreach (Question question in questionList)
            {
                if(question.Point == point) { return question; }
            }
            return null;
        }
    }
}
