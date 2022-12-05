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
            if (playerList.Count == 4)
            {
                MessageBox.Show("Max of 4 players reached. No more can be added");
            }
            else
            {
                if (txtPlayerName.Text.Trim().Equals("") || !mskId.MaskCompleted)
                {
                    MessageBox.Show("You must enter your name AND a unique number.");
                }
                else
                {
                    bool duplicated = false;

                    //loop through the list of players to see if any other player has the same ID
                    foreach(Player p in playerList)
                    {
                        //check for duplicate players
                        if(p.Id == int.Parse(mskId.Text))
                        {
                            duplicated = true;
                            MessageBox.Show("There is a player with the same ID. Please choose another one");
                            break;
                        }
                    }

                    //can add player if ID does not already exist
                    if (!duplicated)
                    {
                        Player player = new Player(int.Parse(mskId.Text), txtPlayerName.Text);
                        playerList.Add(player);
                        MessageBox.Show("Player: " + player.Name + " ( " + player.Id + " ) has been added to the game.");
                    }
                }
            }
        }

        //starts the game form and sends the gameboard data 
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(playerList.Count >= 2)
            {
                gameBoard = new GameBoard(categoryList, playerList, 30);
                frmGame gameForm = new frmGame(this);
                this.Hide();
                gameForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to have at least 2 players. Add more players.");
            }
        }
        
        //frm extracts data from the database and creates categories with them
        //they are then added to the category list for the gameboard to be initialized with
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


        //when player wants to play, the rules, the controls to add players, and the button to start will appear
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            gbPlayerAddition.Visible = true;
            lblDirection.Visible = true;
            gbRules.Visible = true;
            btnPlay.Visible = false;
        }
    }
}
