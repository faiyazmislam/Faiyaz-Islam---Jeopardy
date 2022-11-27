using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class GameBoard
    {
        CategoryList categoryList;
        List<Player> playerList;
        Player currentPlayer;
        String currentPlayerAnswer;
        Question selectedQuestion; //according to player's chosen category and chosen point
        bool allQuestionsChosen; 
        //int numberQuestions;

        public GameBoard(CategoryList categoryList, List<Player> playerList) //, int numberQuestions)
        {
            this.categoryList = categoryList;
            this.playerList = playerList;
            this.currentPlayer = playerList.First();
            this.currentPlayerAnswer = null; //MIGHT NOT NEEDED
            this.selectedQuestion = null;   //MIGHT NOT NEEDED
            this.allQuestionsChosen = false;
            //this.numberQuestions = numberQuestions;
        }

        public CategoryList CategoryList { get; set; }
        public List<Player> PlayerList { get; set; }
        public Player CurrentPlayer { get; set; }
        public String CurrentPlayerAnswer { get; set; }
        public Question SelectedQuestion { get; set; }
        public bool AllQuestionsChosen { get; set; }

        public bool CheckAnswer()
        {
            //NOTE: make sure selectedQuestion is NOT null
            if (currentPlayer.Answer.Equals(selectedQuestion.Answer)) return true;
            return false;
        }

        //calculate player's score according to the result of CheckAnswer() 
        public int CalculateScore() //UpdateScore() is not needed, faiyaz
        {
            bool isCorrect = CheckAnswer();
            int playerScore = currentPlayer.Points;
            int chosenPoint = currentPlayer.ChosenPoint;

            //NOTE: make sure player's chosen point is corret
            if (isCorrect) playerScore += chosenPoint;  //if player's answer is correct, increment score
            else playerScore -= chosenPoint;            //if player's answer is incorrect, decrement score

            return playerScore;
        }

        public void NextPlayer()
        {
            int currentIndex = playerList.IndexOf(currentPlayer);

            //if current player is NOT the last player, move to next player
            if (currentIndex != playerList.Count - 1) 
            {
                currentPlayer = playerList.ElementAt(currentIndex + 1);
            }
            //current player is the last player, move to 1st player
            else currentPlayer = playerList.First(); 
        }

        public void CheckGameStatus()
        {
            
        }

        public List<Player> FindWinner() //Note: there can be more than 1 player
        {
            //assuming 1st player is the winner and has the highest score
            int max = playerList.First().Points;
            List<Player> winners = new List<Player>();
            winners.Add(playerList.First());

            for(int i = 1; i < playerList.Count; i++)  
            {
                Player player = playerList.ElementAt(i);

                if (player.Points > max)
                {
                    max = player.Points;
                    winners.Clear(); //remove all players in the winner list (in case there's more than 1 winner)
                    winners.Add(player);
                }
                else if(player.Points == max) { winners.Add(player); }
            }

            return winners;
        }
        //public String DisplayQuestion()
        //{
        //    return selectedQuestion.Query;
        //}
    }
}
