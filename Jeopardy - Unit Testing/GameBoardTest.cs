using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3309___Term_Project___Jeopardy;
using System.Collections.Generic;
using System.Linq;

namespace Jeopardy___Unit_Testing
{
    [TestClass]
    public class GameBoardTest
    {
        [TestMethod]
        public void TestGameBoard()
        {
            CategoryList categoryList = new CategoryList();
            List<Player> players = new List<Player>();
            Player player1 = new Player(1, "Jenny");
            Player player2 = new Player(2, "Faiyaz");
            players.Add(player1);
            players.Add(player2);

            //test initiated GameBoard object
            GameBoard gameBoard = new GameBoard(categoryList, players);
            Assert.IsNotNull(gameBoard);
            Assert.AreSame(categoryList, gameBoard.CategoryList);
            Assert.AreSame(players, gameBoard.PlayerList);
            Assert.AreSame(player1, gameBoard.CurrentPlayer);
            Assert.AreEqual(player1.Name, gameBoard.CurrentPlayer.Name);
            Assert.AreSame(null, gameBoard.SelectedQuestion);

            //test if data are updated
            Question question = new Question();
            question.Query = "What is AJAX?";
            gameBoard.SelectedQuestion = question;
            Assert.AreNotEqual(null, gameBoard.SelectedQuestion); //after change
            Assert.AreSame(question, gameBoard.SelectedQuestion);
            Assert.AreEqual(question.Query, gameBoard.SelectedQuestion.Query);

            Assert.AreEqual(null, gameBoard.CurrentPlayerAnswer); //before change
            gameBoard.CurrentPlayerAnswer = "Asynchronous JavaScript and XML";
            Assert.AreEqual("Asynchronous JavaScript and XML", gameBoard.CurrentPlayerAnswer); //after change

            Assert.AreEqual(2, gameBoard.PlayerList.Count); //before change
            gameBoard.PlayerList.Add(new Player(3, "Chris"));
            Assert.AreEqual(3, gameBoard.PlayerList.Count); //after change
            Assert.AreEqual("Chris", gameBoard.PlayerList.ElementAt(2).Name);

            Assert.AreEqual(0, gameBoard.AvailableQuestions); //before change
            gameBoard.AvailableQuestions = 30;
            Assert.AreEqual(30, gameBoard.AvailableQuestions); //after change

            //Testing 2 GameBoard objects
            GameBoard gameBoard2 = null;
            Assert.AreEqual(null, gameBoard2);
            Assert.AreNotSame(gameBoard, gameBoard2);
            gameBoard2 = gameBoard;
            Assert.AreNotEqual(null, gameBoard2);
            Assert.AreSame(gameBoard, gameBoard2);
            Assert.AreSame(gameBoard.PlayerList, gameBoard2.PlayerList);
            Assert.AreSame(gameBoard.CategoryList, gameBoard2.CategoryList);
            Assert.AreSame(gameBoard.SelectedQuestion, gameBoard2.SelectedQuestion);

            //Testing null
            gameBoard = null;
            Assert.AreEqual(null, gameBoard);
        }

        [TestMethod]
        public void TestSetAvailableQuestions()
        {
            CategoryList categoryList = new CategoryList();
            List<Player> players = new List<Player>();
            Player player1 = new Player(1, "Jenny");
            Player player2 = new Player(2, "Faiyaz");
            players.Add(player1);
            players.Add(player2);
            GameBoard gameBoard = new GameBoard(categoryList, players);
            Assert.AreEqual(0, gameBoard.AvailableQuestions); //before change

            //test 0 and positive #
            for (int i = 0; i < 30; i++)
            {
                gameBoard.SetAvailableQuestions(i);
                if (i != 0)
                { //make sure not = to previous assigned value
                    Assert.AreNotEqual(i - 1, gameBoard.AvailableQuestions);
                }
                Assert.AreEqual(i, gameBoard.AvailableQuestions);
            }

            //test between negative and positive #
            for (int i = -100; i < 100; i++)
            {
                gameBoard.SetAvailableQuestions(i);
                if (i != 0)
                { //make sure not = to previous assigned value
                    Assert.AreNotEqual(i - 1, gameBoard.AvailableQuestions);
                }
                Assert.AreEqual(i, gameBoard.AvailableQuestions);
            }

            //test negative # only
            for (int i = -100; i < -50; i++)
            {
                gameBoard.SetAvailableQuestions(i);
                if (i != 0)
                { //make sure not = to previous assigned value
                    Assert.AreNotEqual(i - 1, gameBoard.AvailableQuestions);
                }
                Assert.AreEqual(i, gameBoard.AvailableQuestions);
            }
        }

        [TestMethod]
        public void TestCheckAnswer()
        {
            CategoryList categoryList = new CategoryList();
            List<Player> players = new List<Player>();
            Player player1 = new Player(1, "Jenny");
            Player player2 = new Player(2, "Faiyaz");
            players.Add(player1);
            players.Add(player2);
            GameBoard gameBoard = new GameBoard(categoryList, players);
            gameBoard.CurrentPlayerAnswer = "What is anything?";
            gameBoard.SelectedQuestion = new Question("Opposite of something", 100, "What is nothing?");

            //test - player's answer is wrong
            bool result = gameBoard.CheckAnswer();
            Assert.AreEqual(false, result);

            //test - player's answer is correct (exactly the same as question's answer)
            gameBoard.CurrentPlayerAnswer = "What is nothing?";
            result = gameBoard.CheckAnswer();
            Assert.AreEqual(true, result);

            //test - player's answer is correct (not exactly the same as question's answer)
            //lowercase vs. uppercase
            gameBoard.CurrentPlayerAnswer = "what is Nothing?";
            result = gameBoard.CheckAnswer();
            Assert.AreEqual(true, result);

            //test - player's answer is wrong (user forgot a "?")
            gameBoard.CurrentPlayerAnswer = "What is nothing";
            result = gameBoard.CheckAnswer();
            Assert.AreEqual(false, result);

            //test - player's answer is wrong (user's answer is in non-answer form)
            gameBoard.CurrentPlayerAnswer = "nothing";
            result = gameBoard.CheckAnswer();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestCalculateScore()
        {
            List<Player> players = new List<Player>();
            GameBoard gameBoard = new GameBoard(new CategoryList(), players);

            //test - player's answer is true, therefore they will get 100 pts
            gameBoard.SelectedQuestion.Answer = "What is nothing?";

            gameBoard.CurrentPlayerAnswer = "What is nothing?";
            int result = gameBoard.CalculateScore(100);
            Assert.AreEqual(100, result);
            Assert.AreNotEqual(-100, result);

            //player's answer is false, therefore they will get -100 pts
            gameBoard.CurrentPlayerAnswer = "What is something?";
            result = gameBoard.CalculateScore(100);
            Assert.AreEqual(-100, result);
            Assert.AreNotEqual(100, result);

            //test - player's answer is true, therefore they will get 300 pts
            gameBoard.SelectedQuestion.Answer = "What is Temple?";

            gameBoard.CurrentPlayerAnswer = "What is temple?";
            result = gameBoard.CalculateScore(300);
            Assert.AreEqual(300, result);
            Assert.AreNotEqual(100, result);
            Assert.AreNotEqual(-100, result);

            //player's answer is false, therefore they will get -100 pts
            gameBoard.CurrentPlayerAnswer = "What is something?";
            result = gameBoard.CalculateScore(300);
            Assert.AreEqual(-300, result);
            Assert.AreNotEqual(300, result);
            Assert.AreNotEqual(100, result);
            Assert.AreNotEqual(-100, result);


        }

        [TestMethod]
        public void TestNextPlayer()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player(1, "Jenny"));
            players.Add(new Player(2, "Faiyaz"));
            players.Add(new Player(3, "Chris"));
            GameBoard gameBoard = new GameBoard(new CategoryList(), players);

            Assert.AreSame("Jenny", gameBoard.CurrentPlayer.Name);
            gameBoard.NextPlayer();
            Assert.AreNotSame("Jenny", gameBoard.CurrentPlayer.Name);
            Assert.AreSame("Faiyaz", gameBoard.CurrentPlayer.Name);

            gameBoard.NextPlayer();
            Assert.AreNotSame("Faiyaz", gameBoard.CurrentPlayer.Name);
            Assert.AreSame("Chris", gameBoard.CurrentPlayer.Name);

            gameBoard.NextPlayer();
            Assert.AreNotSame("Chris", gameBoard.CurrentPlayer.Name);
            Assert.AreSame("Jenny", gameBoard.CurrentPlayer.Name);

            gameBoard.NextPlayer();
            Assert.AreNotSame("Jenny", gameBoard.CurrentPlayer.Name);
            Assert.AreSame("Faiyaz", gameBoard.CurrentPlayer.Name);
        }

        [TestMethod]
        public void TestDecreaseAvailableQuestions()
        {
            List<Player> players = new List<Player>();
            Player player1 = new Player(1, "Jenny");
            Player player2 = new Player(2, "Faiyaz");
            players.Add(player1);
            players.Add(player2);
            GameBoard gameBoard = new GameBoard(new CategoryList(), players);
            gameBoard.SetAvailableQuestions(70);
            Assert.AreEqual(70, gameBoard.AvailableQuestions);

            gameBoard.DecreaseAvailableQuestions();
            Assert.AreNotEqual(70, gameBoard.AvailableQuestions);
            Assert.AreEqual(69, gameBoard.AvailableQuestions);

            gameBoard.DecreaseAvailableQuestions();
            Assert.AreNotEqual(69, gameBoard.AvailableQuestions);
            Assert.AreEqual(68, gameBoard.AvailableQuestions);

            gameBoard.DecreaseAvailableQuestions();
            Assert.AreNotEqual(68, gameBoard.AvailableQuestions);
            Assert.AreEqual(67, gameBoard.AvailableQuestions);
        }

        [TestMethod]
        public void TestCheckGameStatus()
        {
            List<Player> players = new List<Player>();
            Player player1 = new Player(1, "Jenny");
            Player player2 = new Player(2, "Faiyaz");
            players.Add(player1);
            players.Add(player2);
            GameBoard gameBoard = new GameBoard(new CategoryList(), players);
            gameBoard.SetAvailableQuestions(3);

            Assert.AreEqual(3, gameBoard.AvailableQuestions);
            bool continueGame = gameBoard.CheckGameStatus();
            Assert.AreEqual(true, continueGame);

            gameBoard.DecreaseAvailableQuestions();
            Assert.AreEqual(2, gameBoard.AvailableQuestions);
            continueGame = gameBoard.CheckGameStatus();
            Assert.AreEqual(true, continueGame);

            gameBoard.DecreaseAvailableQuestions();
            Assert.AreEqual(1, gameBoard.AvailableQuestions);
            continueGame = gameBoard.CheckGameStatus();
            Assert.AreEqual(true, continueGame);

            gameBoard.DecreaseAvailableQuestions();
            Assert.AreEqual(0, gameBoard.AvailableQuestions);
            continueGame = gameBoard.CheckGameStatus();
            Assert.AreEqual(false, continueGame);
        }

        [TestMethod]
        public void TestFindWinner()
        {
            Player player1 = new Player(1, "Jenny");
            player1.PlayerScore = 100;

            Player player2 = new Player(2, "Faiyaz");
            player2.PlayerScore = 200;

            Player player3 = new Player(3, "Chris");
            player3.PlayerScore = 300;

            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            GameBoard gameBoard = new GameBoard(new CategoryList(), players);

            //test - 3rd player wins
            List<Player> theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(1, theWinners.Count);
            Assert.AreEqual(player3, theWinners.ElementAt(0));
            Assert.AreEqual(player3.Name, theWinners.ElementAt(0).Name);

            //test - 2nd player wins
            player3.PlayerScore = 0;
            theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(1, theWinners.Count);
            Assert.AreEqual(player2, theWinners.ElementAt(0));
            Assert.AreEqual(player2.Name, theWinners.ElementAt(0).Name);

            //test - 1st player wins (and test with negative score)
            player2.PlayerScore = -200;
            theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(1, theWinners.Count);
            Assert.AreEqual(player1, theWinners.ElementAt(0));
            Assert.AreEqual(player1.Name, theWinners.ElementAt(0).Name);

            //test - tie (player 1 and 3 - score = 0 > player 2 - score = -200)
            player1.PlayerScore = 0;
            theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(2, theWinners.Count);
            Assert.AreEqual(player1, theWinners.ElementAt(0));
            Assert.AreEqual(player1.Name, theWinners.ElementAt(0).Name);
            Assert.AreEqual(player3, theWinners.ElementAt(1));
            Assert.AreEqual(player3.Name, theWinners.ElementAt(1).Name);

            //test - tie (player 2 and 3 - score = 500 > player 1 - score = 0)
            player2.PlayerScore = 500;
            player3.PlayerScore = 500;
            theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(2, theWinners.Count);
            Assert.AreEqual(player2, theWinners.ElementAt(0));
            Assert.AreEqual(player2.Name, theWinners.ElementAt(0).Name);
            Assert.AreEqual(player3, theWinners.ElementAt(1));
            Assert.AreEqual(player3.Name, theWinners.ElementAt(1).Name);

            //test - tie (3 winners and all 3 scores = negative scores)
            player1.PlayerScore = -300;
            player2.PlayerScore = -300;
            player3.PlayerScore = -300;
            theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(3, theWinners.Count);
            Assert.AreEqual(player1, theWinners.ElementAt(0));
            Assert.AreEqual(player1.Name, theWinners.ElementAt(0).Name);
            Assert.AreEqual(player2, theWinners.ElementAt(1));
            Assert.AreEqual(player2.Name, theWinners.ElementAt(1).Name);
            Assert.AreEqual(player3, theWinners.ElementAt(2));
            Assert.AreEqual(player3.Name, theWinners.ElementAt(2).Name);

            //test - 1 winner but all 3 players' score = negative
            player1.PlayerScore = -500;
            player2.PlayerScore = -200;
            player3.PlayerScore = -700;
            theWinners = gameBoard.FindWinner();
            Assert.IsNotNull(theWinners);
            Assert.AreEqual(1, theWinners.Count);
            Assert.AreEqual(player2, theWinners.ElementAt(0));
            Assert.AreEqual(player2.Name, theWinners.ElementAt(0).Name);
        }
    }
}
