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
                //MessageBox.Show("Player: " + player.Name + "(" + player.Id + ") is added.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(playerList.Count >= 2)
            {
                gameBoard = new GameBoard(categoryList, playerList);
                frmGame gameForm = new frmGame(this);
                //gameForm.gameBoard = gameBoard;
                gameForm.ShowDialog();

               // frmStarter starterForm = new frmStarter();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to have at least 2 players. Add more players.");
            }
        }
        /*
        public void LoadCategoryList(String categoryName, DataTable dataTable)
        {
            List<Question> questions = new List<Question>();

            foreach(DataRow record in dataTable.Rows) {
                if (record["Category"].ToString().Equals(categoryName))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();
                   
                    questions.Add(question);
                }
            }

            Category category = new Category(categoryName, questions);
            categoryList.AddCategory(category);
        }*/

        private void frmStarter_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM JeopardyQuestions";
            string strConnection = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = JeopardyDatabase.accdb";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet dataSet = new DataSet("JeopardyQuestionsTable");
            myDataAdapter.Fill(dataSet, "JeopardyQuestionsTable");
            DataTable dataTable = dataSet.Tables["JeopardyQuestionsTable"];
            /*
            LoadCategoryList("Movies", dataTable);
            LoadCategoryList("Music", dataTable);
            LoadCategoryList("Games", dataTable);
            LoadCategoryList("Shows", dataTable);
            LoadCategoryList("Sports", dataTable);
            LoadCategoryList("Temple", dataTable);

            String display = "";
            foreach(Category category in categoryList)
            {
                display += "Category: " + category.CategoryName + "\n";
                List<Question> questionList = category.QuestionList;

                foreach(Question question in questionList)
                {
                    display += "\tPoint: " + question.Point + " | Question: " + question.Query + 
                               "\n\tAnswer: " + question.Answer;
                }
            }
            MessageBox.Show(display);*/

            
            List<Question> movieQuestions = new List<Question> ();

            foreach(DataRow record in dataTable.Rows) {

                if (record["Category"].ToString().Equals("Movies"))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();

                    movieQuestions.Add(question);
                }
            }

            Category moviesCategory = new Category("Movies", movieQuestions);
            categoryList.AddCategory(moviesCategory);


            foreach(Question question in movieQuestions)
            {
                //MessageBox.Show("" + question.Query + " - " + question.Point + " - " + question.Answer);
            }
            /////

            List<Question> musicQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {

                if (record["Category"].ToString().Equals("Music"))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();

                    musicQuestions.Add(question);
                }
            }

            Category musicCategory = new Category("Music", musicQuestions);
            categoryList.AddCategory(musicCategory);

            //////

            List<Question> gamesQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {

                if (record["Category"].ToString().Equals("Games"))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();

                    gamesQuestions.Add(question);
                }
            }

            Category gamesCategory = new Category("Games", gamesQuestions);
            categoryList.AddCategory(gamesCategory);

            /////

            List<Question> showsQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {

                if (record["Category"].ToString().Equals("Shows"))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();

                    showsQuestions.Add(question);
                }
            }

            Category showsCategory = new Category("Shows", showsQuestions);
            categoryList.AddCategory(showsCategory);

            //////

            List<Question> sportsQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {

                if (record["Category"].ToString().Equals("Sports"))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();

                    sportsQuestions.Add(question);
                }
            }

            Category sportsCategory = new Category("Sports", sportsQuestions);
            categoryList.AddCategory(sportsCategory);

            //////

            List<Question> templeQuestions = new List<Question>();

            foreach (DataRow record in dataTable.Rows)
            {

                if (record["Category"].ToString().Equals("Temple"))
                {
                    Question question = new Question();
                    question.Point = int.Parse(record["Points"].ToString());
                    question.Query = record["Question"].ToString();
                    question.Answer = record["Answer"].ToString();

                    templeQuestions.Add(question);
                }
            }

            Category templeCategory = new Category("Temple", templeQuestions);
            categoryList.AddCategory(templeCategory);

            //MessageBox.Show("" + movieQuestions.Count + musicQuestions.Count + gamesQuestions.Count + 
            //    showsQuestions.Count + sportsQuestions.Count + templeQuestions.Count);

            //    MessageBox.Show("" + categoryList.GetQuestion(moviesCategory, 500).Query);

            //    MessageBox.Show("" + categoryList.GetQuestion(gamesCategory, 300).Query);

            //    MessageBox.Show("" + categoryList.GetQuestion(showsCategory, 100).Query);
            

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

            //////--------------Cartoon Questions and Category------------------------
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

            //////------------------Add Categories to categoryList-----------------------
            //categoryList.AddCategory(school);
            //categoryList.AddCategory(cartoon);
        }
    }
}
