using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3309___Term_Project___Jeopardy;
using System.Collections.Generic;

namespace Jeopardy___Unit_Testing
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void TestCategory() //test default empty constructor
        {
            //Testing Category object with NO data
            Category category = new Category();
            Assert.IsNotNull(category);
            Assert.AreEqual(null, category.CategoryName);
            Assert.AreEqual(null, category.QuestionList);

            //Testing Category object with data
            String theCategoryName = "Music";
            List<Question> theQuestionList = new List<Question>();
            category.CategoryName = theCategoryName;
            category.QuestionList = theQuestionList;
            Assert.AreEqual("Music", category.CategoryName);
            Assert.AreEqual(theQuestionList, category.QuestionList);
            Assert.AreEqual(0, category.QuestionList.Count);

            Question question = new Question("What is Kpop?", 100, "Korean Pop Music");
            theQuestionList.Add(question);
            Assert.AreEqual(1, category.QuestionList.Count);


            Question question2 = new Question("Who is the most popular Korean boy band?", 200, "BTS");
            theQuestionList.Add(question2);
            Assert.AreEqual(2, category.QuestionList.Count);

            Question question3 = new Question("Who is the most popular Korean girl band?", 300, "BlackPink");
            theQuestionList.Add(question3);
            Assert.AreEqual(3, category.QuestionList.Count);
            Assert.AreNotEqual(0, category.QuestionList.Count);
            Assert.AreNotEqual(-1, category.QuestionList.Count);
            Assert.AreNotEqual(-2, category.QuestionList.Count);

            //Testing Category object with NO data - part 2
            Category category2 = new Category();
            Assert.IsNotNull(category2);
            Assert.AreEqual(null, category2.CategoryName);
            Assert.AreEqual(null, category2.QuestionList);

            //Testing Category object with data - part 2
            String theCategoryName2 = "Animal";
            List<Question> theQuestionList2 = new List<Question>();
            category2.CategoryName = theCategoryName2;
            category2.QuestionList = theQuestionList2;
            Assert.AreEqual("Animal", category2.CategoryName);
            Assert.AreEqual(theQuestionList2, category2.QuestionList);
            Assert.AreEqual(0, category2.QuestionList.Count);

            Question question4 = new Question("What animal has a long nose?", 400, "Elephant");
            theQuestionList2.Add(question4);
            Assert.AreEqual(1, category2.QuestionList.Count);

            Question question5 = new Question("What animal has long ears?", 500, "Rabbit");
            theQuestionList2.Add(question5);
            Assert.AreEqual(2, category2.QuestionList.Count);
            Assert.AreNotEqual(0, category2.QuestionList.Count);
            Assert.AreNotEqual(-1, category2.QuestionList.Count);
            Assert.AreNotEqual(-2, category2.QuestionList.Count);

            //Testing 2 Category objects
            Assert.AreNotSame(category, category2);
            Assert.AreNotEqual(category.CategoryName, category2.CategoryName);
            Assert.AreNotEqual(category.QuestionList, category2.QuestionList);
            Assert.AreNotEqual(category.QuestionList.Count, category2.QuestionList.Count);

            //Following codes may be redundant, but just to be safe
            category = category2;
            Assert.AreSame(category, category2);
            Assert.AreEqual(category.CategoryName, category2.CategoryName);
            Assert.AreEqual(category.QuestionList, category2.QuestionList);
            Assert.AreEqual(category.QuestionList.Count, category2.QuestionList.Count);
            Assert.AreEqual("Animal", category.CategoryName);
            Assert.AreEqual(theQuestionList2, category.QuestionList);
            Assert.AreEqual(2, category.QuestionList.Count);
            Assert.AreEqual("Animal", category2.CategoryName);
            Assert.AreEqual(theQuestionList2, category2.QuestionList);
            Assert.AreEqual(2, category2.QuestionList.Count);

            //Test - updating data
            category.CategoryName = "Temple";
            Assert.AreEqual("Temple", category.CategoryName);
            Assert.AreNotEqual("Animal", category.CategoryName); //not = to previous data
            Assert.AreEqual("Temple", category2.CategoryName);
            Assert.AreNotEqual("Animal", category2.CategoryName);

            Assert.AreEqual(2, category.QuestionList.Count);
            Assert.AreNotEqual(0, category.QuestionList.Count);
            Assert.AreEqual(2, category2.QuestionList.Count);
            Assert.AreNotEqual(0, category2.QuestionList.Count);
            category.QuestionList = new List<Question>();
            Assert.AreNotEqual(2, category.QuestionList.Count);
            Assert.AreEqual(0, category.QuestionList.Count);
            Assert.AreNotEqual(2, category2.QuestionList.Count);
            Assert.AreEqual(0, category2.QuestionList.Count);

            //Testing reassigning the 1st Category object to nothing (null)
            Assert.AreNotEqual(null, category);
            category = null;
            Assert.AreEqual(null, category);
            //Assert.AreEqual(null, category.CategoryName);
            //Assert.AreEqual(null, category.QuestionList);
            Assert.AreNotEqual(null, category2); //category2 shouldn't be null (only the 1st Category object is set to null)

            //Testing reassigning the 2nd Category object to nothing (null)
            Assert.AreNotEqual(null, category2);
            category2 = null;
            Assert.AreEqual(null, category2);
            //Assert.AreEqual(null, category2.CategoryName);
            //Assert.AreEqual(null, category2.QuestionList);
        }

        [TestMethod]
        public void TestCategory2() //test constructor with parameter (string categoryName, List<Category> CategoryList)
        {
            //Testing Category object with data
            String theCategoryName = "Music";
            List<Question> theQuestionList = new List<Question>();
            Question question = new Question("What is Kpop?", 100, "Korean Pop Music");
            theQuestionList.Add(question);
            Question question2 = new Question("Who is the most popular Korean boy band?", 200, "BTS");
            theQuestionList.Add(question2);
            Question question3 = new Question("Who is the most popular Korean girl band?", 300, "BlackPink");
            theQuestionList.Add(question3);

            Category category = new Category(theCategoryName, theQuestionList);
            Assert.AreEqual("Music", category.CategoryName);
            Assert.AreEqual(theQuestionList, category.QuestionList);
            Assert.AreEqual(3, category.QuestionList.Count);
            Assert.AreNotEqual(0, category.QuestionList.Count);
            Assert.AreNotEqual(-1, category.QuestionList.Count);
            Assert.AreNotEqual(-2, category.QuestionList.Count);

            //Testing Category object with data - part 2
            String theCategoryName2 = "Animal";
            List<Question> theQuestionList2 = new List<Question>();
            Question question4 = new Question("What animal has a long nose?", 400, "Elephant");
            theQuestionList2.Add(question4);
            Question question5 = new Question("What animal has long ears?", 500, "Rabbit");
            theQuestionList2.Add(question5);

            Category category2 = new Category(theCategoryName2, theQuestionList2);
            Assert.AreEqual("Animal", category2.CategoryName);
            Assert.AreEqual(theQuestionList2, category2.QuestionList);
            Assert.AreEqual(2, category2.QuestionList.Count);
            Assert.AreNotEqual(0, category2.QuestionList.Count);
            Assert.AreNotEqual(-1, category2.QuestionList.Count);
            Assert.AreNotEqual(-2, category2.QuestionList.Count);

            //Testing 2 Category objects
            Assert.AreNotSame(category, category2);
            Assert.AreNotEqual(category.CategoryName, category2.CategoryName);
            Assert.AreNotEqual(category.QuestionList, category2.QuestionList);
            Assert.AreNotEqual(category.QuestionList.Count, category2.QuestionList.Count);

            //Following codes may be redundant, but just to be safe
            category = category2;
            Assert.AreSame(category, category2);
            Assert.AreEqual(category.CategoryName, category2.CategoryName);
            Assert.AreEqual(category.QuestionList, category2.QuestionList);
            Assert.AreEqual(category.QuestionList.Count, category2.QuestionList.Count);
            Assert.AreEqual("Animal", category.CategoryName);
            Assert.AreEqual(theQuestionList2, category.QuestionList);
            Assert.AreEqual(2, category.QuestionList.Count);
            Assert.AreEqual("Animal", category2.CategoryName);
            Assert.AreEqual(theQuestionList2, category2.QuestionList);
            Assert.AreEqual(2, category2.QuestionList.Count);

            //Test - updating data
            category.CategoryName = "Temple";
            Assert.AreEqual("Temple", category.CategoryName);
            Assert.AreNotEqual("Animal", category.CategoryName); //not = to previous data
            Assert.AreEqual("Temple", category2.CategoryName);
            Assert.AreNotEqual("Animal", category2.CategoryName);

            Assert.AreEqual(2, category.QuestionList.Count);
            Assert.AreNotEqual(0, category.QuestionList.Count);
            Assert.AreEqual(2, category2.QuestionList.Count);
            Assert.AreNotEqual(0, category2.QuestionList.Count);
            category.QuestionList = new List<Question>();
            Assert.AreNotEqual(2, category.QuestionList.Count);
            Assert.AreEqual(0, category.QuestionList.Count);
            Assert.AreNotEqual(2, category2.QuestionList.Count);
            Assert.AreEqual(0, category2.QuestionList.Count);

            //Testing reassigning the 1st Category object to nothing (null)
            Assert.AreNotEqual(null, category);
            category = null;
            Assert.AreEqual(null, category);
            //Assert.AreEqual(null, category.CategoryName);
            //Assert.AreEqual(null, category.QuestionList);
            Assert.AreNotEqual(null, category2); //category2 shouldn't be null (only the 1st Category object is set to null)

            //Testing reassigning the 2nd Category object to nothing (null)
            Assert.AreNotEqual(null, category2);
            category2 = null;
            Assert.AreEqual(null, category2);
            //Assert.AreEqual(null, category2.CategoryName);
            //Assert.AreEqual(null, category2.QuestionList);
        }

        [TestMethod]
        public void TestFindQuestion()
        {
            String theCategoryName = "Music";

            List<Question> theQuestionList = new List<Question>();
            Question question = new Question("What is Kpop?", 100, "Korean Pop Music");
            theQuestionList.Add(question);
            Question question2 = new Question("Who is the most popular Korean boy band?", 200, "BTS");
            theQuestionList.Add(question2);
            Question question3 = new Question("Who is the most popular Korean girl band?", 300, "BlackPink");
            theQuestionList.Add(question3);

            Category category = new Category(theCategoryName, theQuestionList);

            //test 1
            Question returnedQuestion = category.FindQuestion(100);
            Assert.IsNotNull(returnedQuestion);
            Assert.AreSame(question, returnedQuestion);
            Assert.AreEqual(question.Query, returnedQuestion.Query); //make sure we got the EXACT same Question object
            Assert.AreEqual(question.Answer, returnedQuestion.Answer);
            Assert.AreEqual(question.PointValue, returnedQuestion.PointValue);
            Assert.AreEqual("What is Kpop?", returnedQuestion.Query); //make sure we got the EXACT same Question object
            Assert.AreEqual("Korean Pop Music", returnedQuestion.Answer);
            Assert.AreEqual(100, returnedQuestion.PointValue);

            //test 2
            returnedQuestion = category.FindQuestion(200);
            Assert.IsNotNull(returnedQuestion);
            Assert.AreSame(question2, returnedQuestion);
            Assert.AreEqual(question2.Query, returnedQuestion.Query); //make sure we got the EXACT same Question object
            Assert.AreEqual(question2.Answer, returnedQuestion.Answer);
            Assert.AreEqual(question2.PointValue, returnedQuestion.PointValue);
            Assert.AreEqual("Who is the most popular Korean boy band?", returnedQuestion.Query); //make sure we got the EXACT same Question object
            Assert.AreEqual("BTS", returnedQuestion.Answer);
            Assert.AreEqual(200, returnedQuestion.PointValue);
            Assert.AreNotSame(question, returnedQuestion); //the function doesn't return the previous Question object 

            //test 3 (for null)
            returnedQuestion = category.FindQuestion(1000); //the list doesn't have a Question object with 1000 pt
            Assert.AreNotSame(question, returnedQuestion);
            Assert.AreNotSame(question2, returnedQuestion);
            Assert.AreNotSame(question3, returnedQuestion);
            Assert.IsNull(returnedQuestion);
        }
    }
}
