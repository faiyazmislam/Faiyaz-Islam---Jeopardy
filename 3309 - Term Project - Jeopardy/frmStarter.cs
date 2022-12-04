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

        internal List<Player> playerList = new List<Player>();
        internal CategoryList categoryList = new CategoryList();
        internal GameBoard gameBoard;

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
                //MessageBox.Show("Player: " + player.Name + " ( " + player.Id + " ) has been added.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(playerList.Count >= 2)
            {
                gameBoard = new GameBoard(categoryList, playerList);
                frmGame gameForm = new frmGame(this);
                gameForm.ShowDialog();
                this.Close();
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

            ////////////////////////

            List<Question> movieQuestions = new List<Question> ();

            foreach(DataRow record in dataTable.Rows) {

                if (record["Category"].ToString().Equals("Movies"))
                {
                    Question question = new Question(record["Question"].ToString(), int.Parse(record["Points"].ToString()), record["Answer"].ToString());
                    movieQuestions.Add(question);
                }
            }

            Category moviesCategory = new Category("Movies", movieQuestions);
            categoryList.AddCategory(moviesCategory);

            ////////////////////////

            List<Question> musicQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {
                if (record["Category"].ToString().Equals("Music"))
                {
                    Question question = new Question(record["Question"].ToString(), int.Parse(record["Points"].ToString()), record["Answer"].ToString());
                    musicQuestions.Add(question);
                }
            }

            Category musicCategory = new Category("Music", musicQuestions);
            categoryList.AddCategory(musicCategory);

            ////////////////////////

            List<Question> gamesQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {
                if (record["Category"].ToString().Equals("Games"))
                {
                    Question question = new Question(record["Question"].ToString(), int.Parse(record["Points"].ToString()), record["Answer"].ToString());
                    gamesQuestions.Add(question);
                }
            }

            Category gamesCategory = new Category("Games", gamesQuestions);
            categoryList.AddCategory(gamesCategory);

            ////////////////////////////

            List<Question> showsQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {
                if (record["Category"].ToString().Equals("Shows"))
                {
                    Question question = new Question(record["Question"].ToString(), int.Parse(record["Points"].ToString()), record["Answer"].ToString());
                    showsQuestions.Add(question);
                }
            }

            Category showsCategory = new Category("Shows", showsQuestions);
            categoryList.AddCategory(showsCategory);

            //////////////////////////////

            List<Question> sportsQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {
                if (record["Category"].ToString().Equals("Sports"))
                {
                    Question question = new Question(record["Question"].ToString(), int.Parse(record["Points"].ToString()), record["Answer"].ToString());
                    sportsQuestions.Add(question);
                }
            }

            Category sportsCategory = new Category("Sports", sportsQuestions);
            categoryList.AddCategory(sportsCategory);

            /////////////////////////////

            List<Question> templeQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {
                if (record["Category"].ToString().Equals("Temple"))
                {
                    Question question = new Question(record["Question"].ToString(), int.Parse(record["Points"].ToString()), record["Answer"].ToString());
                    templeQuestions.Add(question);
                }
            }

            Category templeCategory = new Category("Temple", templeQuestions);
            categoryList.AddCategory(templeCategory);

        }

        private void lblDirection_Click(object sender, EventArgs e)
        {

        }

        private void gbRules_Enter(object sender, EventArgs e)
        {

        }
    }
}
