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
        internal GameBoard gameBoard;
        internal frmStarter myOwnerForm;

        public frmGame(frmStarter frmThatOpenedMe)
        {
            myOwnerForm = frmThatOpenedMe;

            gameBoard = frmThatOpenedMe.gameBoard;

            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            List<Player> players = gameBoard.PlayerList;
            //foreach(Player p in players) { MessageBox.Show(p.Name + " " + p.Id); }

        }

        private void SetQuestion(String chosenCategoryName, int points)
        {
            Category chosenCategory = gameBoard.CategoryList.FindCategory(chosenCategoryName);

            gameBoard.SelectedQuestion = chosenCategory.FindQuestion(points);

            txtQuestion.Text = gameBoard.SelectedQuestion.Query;

        }

        

        private void btnMovies100_Click(object sender, EventArgs e)
        {

            SetQuestion("Movies", 100);
        }

        private void btnMovies200_Click(object sender, EventArgs e)
        {
            SetQuestion("Movies", 200);

        }

        private void btnMovies300_Click(object sender, EventArgs e)
        {

        }

        private void btnMovies400_Click(object sender, EventArgs e)
        {

        }

        private void btnMovies500_Click(object sender, EventArgs e)
        {

        }

        private void btnMusic100_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            gameBoard.CurrentPlayerAnswer = txtPlayerResponse.Text.Trim();

            bool result = gameBoard.CheckAnswer();

            gameBoard.CalculateScore();

            MessageBox.Show("Result: "+ result + " - Player: " + gameBoard.CurrentPlayer.Name + " - Points: " + gameBoard.CurrentPlayer.Points);


            gameBoard.NextPlayer();
        }
    }
}
