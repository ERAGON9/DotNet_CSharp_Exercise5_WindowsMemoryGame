namespace Ex05.Windows.MemoryGame
{
    partial class FormSettings
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
            this.labelFirstPlayerName = new System.Windows.Forms.Label();
            this.textBoxFirstPlayerName = new System.Windows.Forms.TextBox();
            this.labelSecondPlayerName = new System.Windows.Forms.Label();
            this.textBoxSecondPlayerName = new System.Windows.Forms.TextBox();
            this.buttonAgainstAFriend = new System.Windows.Forms.Button();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.buttonBoardSize = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstPlayerName
            // 
            this.labelFirstPlayerName.AutoSize = true;
            this.labelFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstPlayerName.Location = new System.Drawing.Point(29, 36);
            this.labelFirstPlayerName.Name = "labelFirstPlayerName";
            this.labelFirstPlayerName.Size = new System.Drawing.Size(149, 20);
            this.labelFirstPlayerName.TabIndex = 0;
            this.labelFirstPlayerName.Text = "First Player Name:";
            // 
            // textBoxFirstPlayerName
            // 
            this.textBoxFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFirstPlayerName.Location = new System.Drawing.Point(214, 32);
            this.textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            this.textBoxFirstPlayerName.Size = new System.Drawing.Size(129, 26);
            this.textBoxFirstPlayerName.TabIndex = 1;
            // 
            // labelSecondPlayerName
            // 
            this.labelSecondPlayerName.AutoSize = true;
            this.labelSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSecondPlayerName.Location = new System.Drawing.Point(28, 73);
            this.labelSecondPlayerName.Name = "labelSecondPlayerName";
            this.labelSecondPlayerName.Size = new System.Drawing.Size(171, 20);
            this.labelSecondPlayerName.TabIndex = 2;
            this.labelSecondPlayerName.Text = "Second Player Name:";
            // 
            // textBoxSecondPlayerName
            // 
            this.textBoxSecondPlayerName.Enabled = false;
            this.textBoxSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxSecondPlayerName.Location = new System.Drawing.Point(214, 69);
            this.textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            this.textBoxSecondPlayerName.Size = new System.Drawing.Size(129, 26);
            this.textBoxSecondPlayerName.TabIndex = 3;
            this.textBoxSecondPlayerName.Text = "- computer -";
            // 
            // buttonAgainstAFriend
            // 
            this.buttonAgainstAFriend.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAgainstAFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAgainstAFriend.Location = new System.Drawing.Point(355, 69);
            this.buttonAgainstAFriend.Name = "buttonAgainstAFriend";
            this.buttonAgainstAFriend.Size = new System.Drawing.Size(154, 28);
            this.buttonAgainstAFriend.TabIndex = 4;
            this.buttonAgainstAFriend.Text = "Against a Friend";
            this.buttonAgainstAFriend.UseVisualStyleBackColor = false;
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBoardSize.Location = new System.Drawing.Point(29, 118);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(97, 20);
            this.labelBoardSize.TabIndex = 5;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // buttonBoardSize
            // 
            this.buttonBoardSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBoardSize.Location = new System.Drawing.Point(32, 141);
            this.buttonBoardSize.Name = "buttonBoardSize";
            this.buttonBoardSize.Size = new System.Drawing.Size(146, 106);
            this.buttonBoardSize.TabIndex = 6;
            this.buttonBoardSize.Text = "4 x 5";
            this.buttonBoardSize.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.Location = new System.Drawing.Point(379, 216);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(130, 31);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 255);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBoardSize);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.buttonAgainstAFriend);
            this.Controls.Add(this.textBoxSecondPlayerName);
            this.Controls.Add(this.labelSecondPlayerName);
            this.Controls.Add(this.textBoxFirstPlayerName);
            this.Controls.Add(this.labelFirstPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstPlayerName;
        private System.Windows.Forms.TextBox textBoxFirstPlayerName;
        private System.Windows.Forms.Label labelSecondPlayerName;
        private System.Windows.Forms.TextBox textBoxSecondPlayerName;
        private System.Windows.Forms.Button buttonAgainstAFriend;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.Button buttonBoardSize;
        private System.Windows.Forms.Button buttonStart;
    }
}