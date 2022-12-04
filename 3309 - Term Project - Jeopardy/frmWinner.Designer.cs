namespace _3309___Term_Project___Jeopardy
{
    partial class frmWinner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinners = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Gold;
            this.lblWinner.Location = new System.Drawing.Point(183, 21);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(225, 68);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "YOU WON! \r\nCONGRATULATIONS!";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinners
            // 
            this.lblWinners.BackColor = System.Drawing.Color.Transparent;
            this.lblWinners.Font = new System.Drawing.Font("Lucida Fax", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinners.ForeColor = System.Drawing.Color.Gold;
            this.lblWinners.Location = new System.Drawing.Point(77, 100);
            this.lblWinners.Name = "lblWinners";
            this.lblWinners.Size = new System.Drawing.Size(432, 154);
            this.lblWinners.TabIndex = 1;
            this.lblWinners.Text = "Winner Name";
            this.lblWinners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblWinners.Click += new System.EventHandler(this.lblWinners_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Navy;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Gold;
            this.btnNewGame.Location = new System.Drawing.Point(70, 246);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(212, 42);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Navy;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndGame.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.Gold;
            this.btnEndGame.Location = new System.Drawing.Point(297, 246);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(212, 42);
            this.btnEndGame.TabIndex = 3;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // frmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3309___Term_Project___Jeopardy.Properties.Resources.JeopardyWinBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 325);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWinners);
            this.Controls.Add(this.lblWinner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWinner";
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.frmWinner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblWinners;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnEndGame;
    }
}
