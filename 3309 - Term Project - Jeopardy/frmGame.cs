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
            foreach(Player p in players) { MessageBox.Show(p.Name + " " + p.Id); }
        }

        private void SetQuestion(Category chosenCategory, int points)
        {
            gameBoard.SelectedQuestion = gameBoard.CategoryList.GetQuestion(chosenCategory, points);

            txtQuestion.Text = gameBoard.SelectedQuestion.Query;

        }

        private void btnMovies100_Click(object sender, EventArgs e)
        {
            Category moviesCategory = new Category(); 

            SetQuestion(moviesCategory, 100);
        }
    }
}
