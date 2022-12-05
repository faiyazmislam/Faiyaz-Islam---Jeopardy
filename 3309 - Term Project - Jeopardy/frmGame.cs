using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3309___Term_Project___Jeopardy
{
    public partial class frmGame : Form
    {
        internal GameBoard currentGameBoard;
        internal frmStarter myOwnerForm;
        internal List<Player> winners = new List<Player>();

        public frmGame(frmStarter frmThatOpenedMe)
        {
            myOwnerForm = frmThatOpenedMe;

            currentGameBoard = frmThatOpenedMe.gameBoard;

            currentGameBoard.SetAvailableQuestions(30);

            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            //List<Player> players = currentGameBoard.PlayerList;
            //first player is identified
            txtbxCurrentPlayer.Text = currentGameBoard.CurrentPlayer.Name + " " + currentGameBoard.CurrentPlayer.Id;

            //displays the players
            DisplayPlayers(currentGameBoard.PlayerList);

            //prevents player from entering data before the question has been chosen
            txtPlayerResponse.Enabled = false;
            btnSubmit.Enabled = false;
        }

        //function that displays the players in the game
        private void DisplayPlayers(List<Player> players)
        {
            string playerDisplay = "";

            foreach(Player p in players)
            {
                playerDisplay += p.Name + " " + p.Id + " - Score: " + p.PlayerScore + "\n";
            }

            lblPlayers.Text = playerDisplay;
        }

        private void SetQuestion(String chosenCategoryName, int points)
        {
            //finds the category that has been chosen
            Category chosenCategory = currentGameBoard.CategoryList.FindCategory(chosenCategoryName);

            //finds and stores the question based on the point value
            currentGameBoard.SelectedQuestion = chosenCategory.FindQuestion(points);

            //reduces the number of available questions
            currentGameBoard.DecreaseAvailableQuestions();

            //displays the question
            txtQuestion.Text = currentGameBoard.SelectedQuestion.Query;

            //enables controls that allow the player to enter in their answer, disables them from pressing other buttons
            txtPlayerResponse.Enabled = true;
            btnSubmit.Enabled = true;
            grbCategories.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            currentGameBoard.CurrentPlayerAnswer = txtPlayerResponse.Text;

            bool result = currentGameBoard.CheckAnswer();

            currentGameBoard.CurrentPlayer.PlayerScore += currentGameBoard.CalculateScore(currentGameBoard.SelectedQuestion.PointValue);

            int playerScore = currentGameBoard.CurrentPlayer.PlayerScore;

            lblResult.Text = "Result: \n" + result + "\nPlayer: " + currentGameBoard.CurrentPlayer.Name + " - Total Score: " + playerScore;
            
            DisplayPlayers(currentGameBoard.PlayerList);

            //if player gets the answer right, then they have another turn
            if (result)
            {
                grbCategories.Enabled = true;
                txtPlayerResponse.Enabled = false;
                btnSubmit.Enabled = false;
                lblResult.Text = "Result: \n" + result + "\nPlayer: " + currentGameBoard.CurrentPlayer.Name + " - Total Score: " + playerScore;
                txtPlayerResponse.Text = "";
                txtQuestion.Text = "";
            }
            //if they are wrong (Note: they can enter 'nothing' for answer, but it'll be considered as wrong)
            else
            {
                MessageBox.Show("Answer was: " + currentGameBoard.SelectedQuestion.Answer);
                //gameboard checks if there are questions left
                if (currentGameBoard.CheckGameStatus())
                {
                    //if yes, next player has their turn
                    currentGameBoard.NextPlayer();
                    txtPlayerResponse.Enabled = false;
                    btnSubmit.Enabled = false;
                    grbCategories.Enabled = true;
                    txtPlayerResponse.Text = "";
                    txtQuestion.Text = "";
                    txtbxCurrentPlayer.Text = currentGameBoard.CurrentPlayer.Name + " " + currentGameBoard.CurrentPlayer.Id;
                }
                else
                {
                    //if no more questions, the winner is chosen
                    winners = currentGameBoard.FindWinner();

                    frmWinner winnersForm = new frmWinner(this);
                    this.Hide();
                    winnersForm.ShowDialog();
                    this.Close();
                }
            }
        }


        //the code for each button
        private void btnMovies100_Click(object sender, EventArgs e)
        {
            //calls the function with the specific category and point value
            SetQuestion("Movies", 100);

            //disables the button so that it will not be pressed again
            btnMovies100.Enabled = false;
        }

        private void btnMovies200_Click(object sender, EventArgs e)
        {
            SetQuestion("Movies", 200);
            btnMovies200.Enabled = false;
        }

        private void btnMovies300_Click(object sender, EventArgs e)
        {
            SetQuestion("Movies", 300);
            btnMovies300.Enabled = false;
        }

        private void btnMovies400_Click(object sender, EventArgs e)
        {
            SetQuestion("Movies", 400);
            btnMovies400.Enabled = false;
        }

        private void btnMovies500_Click(object sender, EventArgs e)
        {
            SetQuestion("Movies", 500);
            btnMovies500.Enabled = false;
        }

        //music category questions
        private void btnMusic100_Click(object sender, EventArgs e)
        {
            SetQuestion("Music", 100);
            btnMusic100.Enabled = false;
        }

        private void btnMusic200_Click(object sender, EventArgs e)
        {
            SetQuestion("Music", 200);
            btnMusic200.Enabled = false;
        }

        private void btnMusic300_Click(object sender, EventArgs e)
        {
            SetQuestion("Music", 300);
            btnMusic300.Enabled = false;
        }

        private void btnMusic400_Click(object sender, EventArgs e)
        {
            SetQuestion("Music", 400);
            btnMusic400.Enabled = false;
        }

        private void btnMusic500_Click(object sender, EventArgs e)
        {
            SetQuestion("Music", 500);
            btnMusic500.Enabled = false;
        }

        //games category questions
        private void btnGames100_Click(object sender, EventArgs e)
        {
            SetQuestion("Games", 100);
            btnGames100.Enabled = false;
        }

        private void btnGames200_Click(object sender, EventArgs e)
        {
            SetQuestion("Games", 200);
            btnGames200.Enabled = false;
        }

        private void btnGames300_Click(object sender, EventArgs e)
        {
            SetQuestion("Games", 300);
            btnGames300.Enabled = false;
        }

        private void btnGames400_Click(object sender, EventArgs e)
        {
            SetQuestion("Games", 400);
            btnGames400.Enabled = false;
        }

        private void btnGames500_Click(object sender, EventArgs e)
        {
            SetQuestion("Games", 500);
            btnGames500.Enabled = false;
        }

        //shows category questions
        private void btnShows100_Click(object sender, EventArgs e)
        {
            SetQuestion("Shows", 100);
            btnShows100.Enabled = false;
        }

        private void btnShows200_Click(object sender, EventArgs e)
        {
            SetQuestion("Shows", 200);
            btnShows200.Enabled = false;
        }

        private void btnShows300_Click(object sender, EventArgs e)
        {
            SetQuestion("Shows", 300);
            btnShows300.Enabled = false;
        }

        private void btnShows400_Click(object sender, EventArgs e)
        {
            SetQuestion("Shows", 400);
            btnShows400.Enabled = false;
        }

        private void btnShows500_Click(object sender, EventArgs e)
        {
            SetQuestion("Shows", 500);
            btnShows500.Enabled = false;
        }

        //sports category questions
        private void btnSports100_Click(object sender, EventArgs e)
        {
            SetQuestion("Sports", 100);
            btnSports100.Enabled = false;
        }

        private void btnSports200_Click(object sender, EventArgs e)
        {
            SetQuestion("Sports", 200);
            btnSports200.Enabled = false;
        }

        private void btnSports300_Click(object sender, EventArgs e)
        {
            SetQuestion("Sports", 300);
            btnSports300.Enabled = false;
        }

        private void btnSports400_Click(object sender, EventArgs e)
        {
            SetQuestion("Sports", 400);
            btnSports400.Enabled = false;
        }

        private void btnSports500_Click(object sender, EventArgs e)
        {
            SetQuestion("Sports", 500);
            btnSports500.Enabled = false;
        }

        //Temple category questions
        private void btnTemple100_Click(object sender, EventArgs e)
        {
            SetQuestion("Temple", 100);
            btnTemple100.Enabled = false;
        }

        private void btnTemple200_Click(object sender, EventArgs e)
        {
            SetQuestion("Temple", 200);
            btnTemple200.Enabled = false;
        }

        private void btnTemple300_Click(object sender, EventArgs e)
        {
            SetQuestion("Temple", 300);
            btnTemple300.Enabled = false;
        }

        private void btnTemple400_Click(object sender, EventArgs e)
        {
            SetQuestion("Temple", 400);
            btnTemple400.Enabled = false;
        }

        private void btnTemple500_Click(object sender, EventArgs e)
        {
            SetQuestion("Temple", 500);
            btnTemple500.Enabled = false;
        }
    }
}
