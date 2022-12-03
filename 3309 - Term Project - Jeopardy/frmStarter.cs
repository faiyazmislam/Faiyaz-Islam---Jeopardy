using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3309___Term_Project___Jeopardy
{
    public partial class frmStarter : Form
    {
        List<Player> playerList = new List<Player>();
        CategoryList categoryList = new CategoryList();

        public frmStarter()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text.Trim().Equals("") || !mskId.MaskCompleted)
            {
                MessageBox.Show("You must enter your name AND a unique number.");
            }
            else
            {
                Player player = new Player(int.Parse(mskId.Text), txtPlayerName.Text);
                playerList.Add(player);
                MessageBox.Show("Player: " + player.Name + "(" + player.Id + ") is added.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(playerList.Count >= 2)
            {
                GameBoard gameBoard = new GameBoard(categoryList, playerList);
                frmGame gameForm = new frmGame(this);
                gameForm.gameBoard = gameBoard;
                gameForm.ShowDialog();

                frmStarter starterForm = new frmStarter();
                starterForm.Close();
            }
            else
            {
                MessageBox.Show("You need to have at least 2 players. Add more players.");
            }
        }

        private void frmStarter_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM JeopardyQuestions";
            string strConnection = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = JeopardyDatabase.accdb";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet dataSet = new DataSet("JeopardyQuestionsTable");
            myDataAdapter.Fill(dataSet, "JeopardyQuestionsTable");
            DataTable dataTable = dataSet.Tables["JeopardyQuestionsTable"];

            //hii
            //this prohect sucsk

            //CREATE CATEGORIES AND QUESTIONS HERE
            //--------------School Questions and Category------------------------
            //String query = "Which Ivy League School is at PA?"; //these r just examples
            //String answer = "University of Pennsylvania";
            //int point = 100;
            //Question question = new Question(query, point, answer);

            //String query2 = "What is Temple University's Mascot?";
            //String answer2 = "Owl";
            //int point2 = 200;
            //Question question2 = new Question(query2, point2, answer2);

            //List<Question> schoolQuestions = new List<Question>();
            //schoolQuestions.Add(question);
            //schoolQuestions.Add(question2);

            //Category school = new Category("School", schoolQuestions);

            ////--------------Cartoon Questions and Category------------------------
            //String query3 = "What's the name of the red teletubby?"; //these r just examples
            //String answer3 = "Po";
            //int point3 = 100;
            //Question question3 = new Question(query3, point3, answer3);

            //String query4 = "What's Kung fu Panda Po's title?";
            //String answer4 = "Dragon Warrior";
            //int point4 = 200;
            //Question question4 = new Question(query4, point4, answer4);

            //List<Question> cartoonQuestions = new List<Question>();
            //cartoonQuestions.Add(question3);
            //cartoonQuestions.Add(question4);

            //Category cartoon = new Category("Cartoon", cartoonQuestions);

            ////------------------Add Categories to categoryList-----------------------
            //categoryList.Add(school);
            //categoryList.Add(cartoon);
        }
    }
}
