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
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWinner.Location = new System.Drawing.Point(214, 23);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(105, 25);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "Winner(s):";
            // 
            // lblWinners
            // 
            this.lblWinners.Location = new System.Drawing.Point(52, 93);
            this.lblWinners.Name = "lblWinners";
            this.lblWinners.Size = new System.Drawing.Size(432, 154);
            this.lblWinners.TabIndex = 1;
            this.lblWinners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblWinners);
            this.Controls.Add(this.lblWinner);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWinner";
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.frmWinner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblWinners;
    }
}
