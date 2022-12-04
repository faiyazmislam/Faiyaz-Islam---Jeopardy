using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class GameBoard
    {
        //CategoryList categoryList;
        //List<Player> playerList;
        //Player currentPlayer;
        //String currentPlayerAnswer;
        //Question selectedQuestion; //according to player's chosen category and chosen point
        //bool allQuestionsChosen; 
        //int numberQuestions;
        public CategoryList CategoryList { get; set; }
        public List<Player> PlayerList { get; set; }
        public Player CurrentPlayer { get; set; }
        public String CurrentPlayerAnswer { get; set; }
        public Question SelectedQuestion { get; set; }
        public bool AllQuestionsChosen { get; set; }

        public int AvailableQuestions { get; set; }

        public GameBoard(CategoryList categoryList, List<Player> playerList) //, int numberQuestions)
        {
            this.CategoryList = categoryList;
            this.PlayerList = playerList;
            this.CurrentPlayer = playerList.First();
            //this.CurrentPlayerAnswer = null; //MIGHT NOT NEEDED
            this.SelectedQuestion = null;   //MIGHT NOT NEEDED
            this.AllQuestionsChosen = false;
            //this.numberQuestions = numberQuestions;
        }

        public bool CheckAnswer()
        {
            //NOTE: make sure selectedQuestion is NOT null
            if (CurrentPlayerAnswer.Equals(SelectedQuestion.Answer)) return true;
            return false;
        }

        //calculate player's score according to the result of CheckAnswer() 
        public int CalculateScore(int points) //UpdateScore() is not needed, faiyaz
        {
            bool isCorrect = CheckAnswer();
            //int playerScore = CurrentPlayer.Points;
            //int chosenPoint = CurrentPlayer.ChosenPoint;

            //NOTE: make sure player's chosen point is corret
            if (isCorrect) return points;  //if player's answer is correct, increment score
            else return (-1) * points;            //if player's answer is incorrect, decrement score

            //return playerScore;
        }

        public void NextPlayer()
        {
            int currentIndex = PlayerList.IndexOf(CurrentPlayer);

            //if current player is NOT the last player, move to next player
            if (currentIndex != PlayerList.Count - 1) 
            {
                CurrentPlayer = PlayerList.ElementAt(currentIndex + 1);
            }
            //current player is the last player, move to 1st player
            else CurrentPlayer = PlayerList.First(); 
        }

        public Boolean CheckGameStatus()
        {
            AvailableQuestions -= 1;

            while(AvailableQuestions >  0)
            {
                return false;
            }

            return true; 
        }

        public List<Player> FindWinner() //Note: there can be more than 1 player
        {
            //assuming 1st player is the winner and has the highest score
            int max = PlayerList.First().PlayerScore;
            List<Player> winners = new List<Player>();
            winners.Add(PlayerList.First());

            for(int i = 1; i < PlayerList.Count; i++)  
            {
                Player player = PlayerList.ElementAt(i);

                if (player.PlayerScore > max)
                {
                    max = player.PlayerScore;
                    winners.Clear(); //remove all players in the winner list (in case there's more than 1 winner)
                    winners.Add(player);
                }
                else if(player.PlayerScore == max) { winners.Add(player); }
            }

            return winners;
        }
        //public String DisplayQuestion()
        //{
        //    return selectedQuestion.Query;
        //}

        
    }
}
