using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3309___Term_Project___Jeopardy
{

    public partial class frmWinner : Form
    {
        internal frmGame myOwnerFrm;

        public frmWinner(frmGame frmThatOpenedMe)
        {
            myOwnerFrm = frmThatOpenedMe;

            InitializeComponent();
        }

        private void frmWinner_Load(object sender, EventArgs e)
        {
            string winnersText = "";
            
            foreach(Player winner in myOwnerFrm.winners)
            {
                winnersText = winner.Name + " - " + winner.PlayerScore + " \n "; 
            }

            lblWinners.Text = winnersText;
        }

       
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmStarter newGame = new frmStarter();
            newGame.ShowDialog();

            this.Close();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing!");
            this.Close();
        }
    }
}
