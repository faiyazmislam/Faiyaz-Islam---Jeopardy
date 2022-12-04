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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStarter));
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskId = new System.Windows.Forms.MaskedTextBox();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.gbPlayerAddition = new System.Windows.Forms.GroupBox();
            this.gbRules.SuspendLayout();
            this.gbPlayerAddition.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(195, 91);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(110, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(86, 94);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(105, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Enter Player\'s Name:";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(322, 91);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(106, 53);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.Location = new System.Drawing.Point(160, 26);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(246, 48);
            this.lblDirection.TabIndex = 5;
            this.lblDirection.Text = "Keep adding players until you\'re ready. \r\n(Max 5 Players)";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDirection.Visible = false;
            this.lblDirection.Click += new System.EventHandler(this.lblDirection_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(245, 351);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 47);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a unique ID:";
            // 
            // mskId
            // 
            this.mskId.Location = new System.Drawing.Point(195, 124);
            this.mskId.Margin = new System.Windows.Forms.Padding(2);
            this.mskId.Mask = "0";
            this.mskId.Name = "mskId";
            this.mskId.Size = new System.Drawing.Size(110, 20);
            this.mskId.TabIndex = 8;
            this.mskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.lblRules);
            this.gbRules.Location = new System.Drawing.Point(48, 48);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(520, 96);
            this.gbRules.TabIndex = 9;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "Rules:";
            this.gbRules.Visible = false;
            this.gbRules.Enter += new System.EventHandler(this.gbRules_Enter);
            // 
            // lblRules
            // 
            this.lblRules.Location = new System.Drawing.Point(28, 16);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(486, 57);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "- 1. ";
            // 
            // gbPlayerAddition
            // 
            this.gbPlayerAddition.Controls.Add(this.lblDirection);
            this.gbPlayerAddition.Controls.Add(this.txtPlayerName);
            this.gbPlayerAddition.Controls.Add(this.mskId);
            this.gbPlayerAddition.Controls.Add(this.lblPlayerName);
            this.gbPlayerAddition.Controls.Add(this.label1);
            this.gbPlayerAddition.Controls.Add(this.btnAddPlayer);
            this.gbPlayerAddition.Location = new System.Drawing.Point(41, 160);
            this.gbPlayerAddition.Name = "gbPlayerAddition";
            this.gbPlayerAddition.Size = new System.Drawing.Size(547, 173);
            this.gbPlayerAddition.TabIndex = 10;
            this.gbPlayerAddition.TabStop = false;
            this.gbPlayerAddition.Visible = false;
            // 
            // frmStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 436);
            this.Controls.Add(this.gbPlayerAddition);
            this.Controls.Add(this.gbRules);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStarter";
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.frmStarter_Load);
            this.gbRules.ResumeLayout(false);
            this.gbPlayerAddition.ResumeLayout(false);
            this.gbPlayerAddition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskId;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.GroupBox gbPlayerAddition;
    }
}