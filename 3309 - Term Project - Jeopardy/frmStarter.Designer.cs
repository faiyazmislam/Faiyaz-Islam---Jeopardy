namespace _3309___Term_Project___Jeopardy
{
    partial class frmStarter
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskId = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(250, 23);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(101, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Let\'s Play Jeopardy!";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(17, 55);
            this.lblRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(40, 13);
            this.lblRule.TabIndex = 1;
            this.lblRule.Text = "Rules: ";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(148, 192);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(110, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(17, 194);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(128, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Enter Player\'s Name Here";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(323, 194);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(73, 27);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "AddPlayer";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(17, 177);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(188, 13);
            this.lblDirection.TabIndex = 5;
            this.lblDirection.Text = "Keep adding players until you\'re ready.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(237, 252);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(54, 24);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a unique number that represent the player";
            // 
            // mskId
            // 
            this.mskId.Location = new System.Drawing.Point(253, 213);
            this.mskId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskId.Mask = "0";
            this.mskId.Name = "mskId";
            this.mskId.Size = new System.Drawing.Size(26, 20);
            this.mskId.TabIndex = 8;
            // 
            // frmStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 344);
            this.Controls.Add(this.mskId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmStarter";
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.frmStarter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskId;
    }
}