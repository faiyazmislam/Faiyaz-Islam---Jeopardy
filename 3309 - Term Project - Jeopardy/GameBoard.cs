using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    public class GameBoard
    {
        public CategoryList CategoryList { get; set; }
        public List<Player> PlayerList { get; set; }
        public Player CurrentPlayer { get; set; }
        public String CurrentPlayerAnswer { get; set; }
        public Question SelectedQuestion { get; set; }
        public int AvailableQuestions { get; set; }

        public GameBoard(CategoryList categoryList, List<Player> playerList, int numberQuestions) 
        {
            this.CategoryList = categoryList;
            this.PlayerList = playerList;
            this.CurrentPlayer = playerList.First();
            this.SelectedQuestion = null;
            this.AvailableQuestions = numberQuestions;
        }

        public bool CheckAnswer()
        {
            if (CurrentPlayerAnswer.ToLower().Equals(SelectedQuestion.Answer.ToLower())) 
                return true;
            return false;
        }

        //calculate player's score according to the result of CheckAnswer() 
        public int CalculateScore(int points)
        {
            bool isCorrect = CheckAnswer();

            if (isCorrect) 
                return CurrentPlayer.PlayerScore + points;//points;  //if player's answer is correct, increment score
            else return CurrentPlayer.PlayerScore - points; //(-1) * points;     //if player's answer is incorrect, decrement score

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

        public void DecreaseAvailableQuestions()
        {
            AvailableQuestions -= 1;
        }

        public Boolean CheckGameStatus()
        {
            if(AvailableQuestions >  0)
            {
                return true;
            }

            return false; 
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
    }
}
