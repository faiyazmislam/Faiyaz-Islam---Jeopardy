using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3309___Term_Project___Jeopardy;
using System.Collections.Generic;

namespace Jeopardy___Unit_Testing
{
    [TestClass]
    public class QuestionTest
    {
        [TestMethod]
        public void TestQuestion() //test for default empty constructor 
        {
            //Testing Question object with NO data
            Question question = new Question();
            Assert.IsNotNull(question);
            Assert.AreEqual(null, question.Query);
            Assert.AreEqual(null, question.Answer);
            Assert.AreEqual(0, question.PointValue);

            //Testing Question object with data
            String theQuery = "Who are you?";
            String theAnswer = "I'm Mi";
            int thePoint = 100;

            question.Query = theQuery;
            question.Answer = theAnswer;
            question.PointValue = thePoint;

            Assert.AreEqual("Who are you?", question.Query);
            Assert.AreEqual("I'm Mi", question.Answer);
            Assert.AreEqual(100, question.PointValue);

            //Testing Question object with NO data - Part 2
            Question question2 = new Question();
            Assert.IsNotNull(question2);
            Assert.AreEqual(null, question2.Query);
            Assert.AreEqual(null, question2.Answer);
            Assert.AreEqual(0, question2.PointValue);

            //Testing Question object with data - Part 2
            String theQuery2 = "Who is he?";
            String theAnswer2 = "He's Yu";
            int thePoint2 = 200;

            question2.Query = theQuery2;
            question2.Answer = theAnswer2;
            question2.PointValue = thePoint2;

            Assert.AreEqual("Who is he?", question2.Query);
            Assert.AreEqual("He's Yu", question2.Answer);
            Assert.AreEqual(200, question2.PointValue);

            //Testing 2 Question objects
            Assert.AreNotSame(question, question2);
            Assert.AreNotEqual(question.Query, question2.Query);
            Assert.AreNotEqual(question.Answer, question2.Answer);
            Assert.AreNotEqual(question.PointValue, question2.PointValue);

            //Following codes may be redundant, but just to be safe
            question = question2;
            Assert.AreSame(question, question2);
            Assert.AreEqual(question.Query, question2.Query);
            Assert.AreEqual(question.Answer, question2.Answer);
            Assert.AreEqual(question.PointValue, question2.PointValue);
            Assert.AreEqual("Who is he?", question.Query);
            Assert.AreEqual("He's Yu", question.Answer);
            Assert.AreEqual(200, question.PointValue);
            Assert.AreEqual("Who is he?", question2.Query);
            Assert.AreEqual("He's Yu", question2.Answer);
            Assert.AreEqual(200, question2.PointValue);

            //Testing if data are updated if reassigned (should = to new data and not = to old data)
            question.Query = "Who is she?";
            question.Answer = "She is Yu.";
            question.PointValue = 300;
            Assert.AreEqual("Who is she?", question.Query);
            Assert.AreEqual("She is Yu.", question.Answer);
            Assert.AreEqual(300, question.PointValue);
            Assert.AreNotEqual("Who is he?", question.Query);   //shouldn't = to previous data
            Assert.AreNotEqual("He's Yu", question.Answer);     //shouldn't = to previous data
            Assert.AreNotEqual(200, question.PointValue);       //shouldn't = to previous data

            //2nd Question object's data should also be updated with new data since question = question2
            Assert.AreEqual("Who is she?", question2.Query);
            Assert.AreEqual("She is Yu.", question2.Answer);
            Assert.AreEqual(300, question2.PointValue);
            Assert.AreNotEqual("Who is he?", question2.Query);   //shouldn't = to previous data
            Assert.AreNotEqual("He's Yu", question2.Answer);     //shouldn't = to previous data
            Assert.AreNotEqual(200, question2.PointValue);       //shouldn't = to previous data

            //Testing reassigning the 1st Question object to nothing (null)
            Assert.AreNotEqual(null, question);
            question = null;
            Assert.AreEqual(null, question);
            //Assert.AreEqual(null, question.Query);
            //Assert.AreEqual(null, question.Answer);
            //Assert.AreEqual(null, question.PointValue);
            Assert.AreNotEqual(null, question2); //question2 shouldn't be null (only the 1st Question object is set to null)

            //Testing reassigning the 2nd Question object to a new default empty Question object 
            //data should be null and not = to previous data
            question2 = new Question();
            Assert.AreNotEqual(null, question2);
            Assert.AreEqual(null, question2.Query);
            Assert.AreEqual(null, question2.Answer);
            Assert.AreEqual(0, question2.PointValue);
            Assert.AreNotEqual("Who is she?", question2.Query);
            Assert.AreNotEqual("She is Yu", question2.Answer);
            Assert.AreNotEqual(300, question2.PointValue);
        }

        [TestMethod]
        public void TestQuestion2() //test for 2nd constructor that takes in (String query, int pointValue, String answer)
        {
            //Testing Question object with data
            String theQuery = "Who are you?";
            String theAnswer = "I'm Mi";
            int thePoint = 100;
            Question question = new Question(theQuery, thePoint, theAnswer);

            Assert.IsNotNull(question);
            Assert.AreNotEqual(null, question.Query);
            Assert.AreNotEqual(null, question.Answer);
            Assert.AreNotEqual(null, question.PointValue);
            Assert.AreEqual("Who are you?", question.Query);
            Assert.AreEqual("I'm Mi", question.Answer);
            Assert.AreEqual(100, question.PointValue);

            //Testing Question object with data - part 2
            String theQuery2 = "Who is he?";
            String theAnswer2 = "He's Yu";
            int thePoint2 = 200;
            Question question2 = new Question(theQuery2, thePoint2, theAnswer2);

            Assert.IsNotNull(question2);
            Assert.AreNotEqual(null, question2.Query);
            Assert.AreNotEqual(null, question2.Answer);
            Assert.AreNotEqual(null, question2.PointValue);
            Assert.AreEqual("Who is he?", question2.Query);
            Assert.AreEqual("He's Yu", question2.Answer);
            Assert.AreEqual(200, question2.PointValue);

            //Testing 2 Question objects
            Assert.AreNotSame(question, question2);
            Assert.AreNotEqual(question.Query, question2.Query);
            Assert.AreNotEqual(question.Answer, question2.Answer);
            Assert.AreNotEqual(question.PointValue, question2.PointValue);

            //Following codes may be redundant, but just to be safe
            question = question2;
            Assert.AreSame(question, question2);
            Assert.AreEqual(question.Query, question2.Query);
            Assert.AreEqual(question.Answer, question2.Answer);
            Assert.AreEqual(question.PointValue, question2.PointValue);
            Assert.AreEqual("Who is he?", question.Query);
            Assert.AreEqual("He's Yu", question.Answer);
            Assert.AreEqual(200, question.PointValue);
            Assert.AreEqual("Who is he?", question2.Query);
            Assert.AreEqual("He's Yu", question2.Answer);
            Assert.AreEqual(200, question2.PointValue);

            //Testing if data are updated if reassigned (should = to new data and not = to old data)
            question.Query = "Who is she?";
            question.Answer = "She is Yu.";
            question.PointValue = 300;
            Assert.AreEqual("Who is she?", question.Query);
            Assert.AreEqual("She is Yu.", question.Answer);
            Assert.AreEqual(300, question.PointValue);
            Assert.AreNotEqual("Who is he?", question.Query);   //shouldn't = to previous data
            Assert.AreNotEqual("He's Yu", question.Answer);     //shouldn't = to previous data
            Assert.AreNotEqual(200, question.PointValue);       //shouldn't = to previous data

            //2nd Question object's data should also be updated with new data since question = question2
            Assert.AreEqual("Who is she?", question2.Query);
            Assert.AreEqual("She is Yu.", question2.Answer);
            Assert.AreEqual(300, question2.PointValue);
            Assert.AreNotEqual("Who is he?", question2.Query);   //shouldn't = to previous data
            Assert.AreNotEqual("He's Yu", question2.Answer);     //shouldn't = to previous data
            Assert.AreNotEqual(200, question2.PointValue);       //shouldn't = to previous data

            //Test - Assigning 1st Question object to a new Question object with same parameter format
            question = new Question("Who is Hooter?", 400, "Hooter is an owl.");
            Assert.AreEqual("Who is Hooter?", question.Query);
            Assert.AreEqual("Hooter is an owl.", question.Answer);
            Assert.AreEqual(400, question.PointValue);
            Assert.AreNotEqual("Who is she?", question.Query);
            Assert.AreNotEqual("She is Yu.", question.Answer);
            Assert.AreNotEqual(300, question.PointValue);

            //Testing reassigning Question objects to nothing (null)
            Assert.AreNotEqual(null, question);
            question = null;
            Assert.AreEqual(null, question);
            //Assert.AreEqual(null, question.Query);
            //Assert.AreEqual(null, question.Answer);
            //Assert.AreEqual(null, question.PointValue);

            Assert.AreNotEqual(null, question2); //question2 shouldn't be null (only the 1st Question object is set to null)
            question2 = null;
            Assert.AreEqual(null, question2);
            //Assert.AreEqual(null, question2.Query);
            //Assert.AreEqual(null, question2.Answer);
            //Assert.AreEqual(null, question2.PointValue);
        }
    }
}
