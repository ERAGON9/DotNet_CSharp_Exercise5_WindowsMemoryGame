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
            this.m_LabelFirstPlayerName = new System.Windows.Forms.Label();
            this.m_TextBoxFirstPlayerName = new System.Windows.Forms.TextBox();
            this.m_LabelSecondPlayerName = new System.Windows.Forms.Label();
            this.m_TextBoxFriend = new System.Windows.Forms.TextBox();
            this.m_ButtonAgainstAFriend = new System.Windows.Forms.Button();
            this.m_LabelBoardSize = new System.Windows.Forms.Label();
            this.m_ButtonBoardSize = new System.Windows.Forms.Button();
            this.m_ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_LabelFirstPlayerName
            // 
            this.m_LabelFirstPlayerName.AutoSize = true;
            this.m_LabelFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelFirstPlayerName.Location = new System.Drawing.Point(19, 29);
            this.m_LabelFirstPlayerName.Name = "m_LabelFirstPlayerName";
            this.m_LabelFirstPlayerName.Size = new System.Drawing.Size(149, 20);
            this.m_LabelFirstPlayerName.TabIndex = 0;
            this.m_LabelFirstPlayerName.Text = "First Player Name:";
            // 
            // m_TextBoxFirstPlayerName
            // 
            this.m_TextBoxFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_TextBoxFirstPlayerName.Location = new System.Drawing.Point(204, 25);
            this.m_TextBoxFirstPlayerName.Name = "m_TextBoxFirstPlayerName";
            this.m_TextBoxFirstPlayerName.Size = new System.Drawing.Size(149, 26);
            this.m_TextBoxFirstPlayerName.TabIndex = 1;
            // 
            // m_LabelSecondPlayerName
            // 
            this.m_LabelSecondPlayerName.AutoSize = true;
            this.m_LabelSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelSecondPlayerName.Location = new System.Drawing.Point(18, 66);
            this.m_LabelSecondPlayerName.Name = "m_LabelSecondPlayerName";
            this.m_LabelSecondPlayerName.Size = new System.Drawing.Size(171, 20);
            this.m_LabelSecondPlayerName.TabIndex = 2;
            this.m_LabelSecondPlayerName.Text = "Second Player Name:";
            // 
            // m_TextBoxFriend
            // 
            this.m_TextBoxFriend.Enabled = false;
            this.m_TextBoxFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_TextBoxFriend.Location = new System.Drawing.Point(204, 62);
            this.m_TextBoxFriend.Name = "m_TextBoxFriend";
            this.m_TextBoxFriend.Size = new System.Drawing.Size(149, 26);
            this.m_TextBoxFriend.TabIndex = 3;
            this.m_TextBoxFriend.Text = "- computer -";
            // 
            // m_ButtonAgainstAFriend
            // 
            this.m_ButtonAgainstAFriend.BackColor = System.Drawing.SystemColors.Control;
            this.m_ButtonAgainstAFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonAgainstAFriend.Location = new System.Drawing.Point(364, 62);
            this.m_ButtonAgainstAFriend.Name = "m_ButtonAgainstAFriend";
            this.m_ButtonAgainstAFriend.Size = new System.Drawing.Size(173, 28);
            this.m_ButtonAgainstAFriend.TabIndex = 4;
            this.m_ButtonAgainstAFriend.Text = "Against a Friend";
            this.m_ButtonAgainstAFriend.UseVisualStyleBackColor = false;
            // 
            // m_LabelBoardSize
            // 
            this.m_LabelBoardSize.AutoSize = true;
            this.m_LabelBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelBoardSize.Location = new System.Drawing.Point(19, 109);
            this.m_LabelBoardSize.Name = "m_LabelBoardSize";
            this.m_LabelBoardSize.Size = new System.Drawing.Size(97, 20);
            this.m_LabelBoardSize.TabIndex = 5;
            this.m_LabelBoardSize.Text = "Board Size:";
            // 
            // m_ButtonBoardSize
            // 
            this.m_ButtonBoardSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.m_ButtonBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonBoardSize.Location = new System.Drawing.Point(22, 132);
            this.m_ButtonBoardSize.Name = "m_ButtonBoardSize";
            this.m_ButtonBoardSize.Size = new System.Drawing.Size(146, 106);
            this.m_ButtonBoardSize.TabIndex = 6;
            this.m_ButtonBoardSize.Text = "4 x 4";
            this.m_ButtonBoardSize.UseVisualStyleBackColor = false;
            // 
            // m_ButtonStart
            // 
            this.m_ButtonStart.BackColor = System.Drawing.Color.Lime;
            this.m_ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonStart.Location = new System.Drawing.Point(414, 201);
            this.m_ButtonStart.Name = "m_ButtonStart";
            this.m_ButtonStart.Size = new System.Drawing.Size(123, 33);
            this.m_ButtonStart.TabIndex = 7;
            this.m_ButtonStart.Text = "Start!";
            this.m_ButtonStart.UseVisualStyleBackColor = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 255);
            this.Controls.Add(this.m_ButtonStart);
            this.Controls.Add(this.m_ButtonBoardSize);
            this.Controls.Add(this.m_LabelBoardSize);
            this.Controls.Add(this.m_ButtonAgainstAFriend);
            this.Controls.Add(this.m_TextBoxFriend);
            this.Controls.Add(this.m_LabelSecondPlayerName);
            this.Controls.Add(this.m_TextBoxFirstPlayerName);
            this.Controls.Add(this.m_LabelFirstPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelFirstPlayerName;
        private System.Windows.Forms.TextBox m_TextBoxFirstPlayerName;
        private System.Windows.Forms.Label m_LabelSecondPlayerName;
        private System.Windows.Forms.TextBox m_TextBoxFriend;
        private System.Windows.Forms.Button m_ButtonAgainstAFriend;
        private System.Windows.Forms.Label m_LabelBoardSize;
        private System.Windows.Forms.Button m_ButtonBoardSize;
        private System.Windows.Forms.Button m_ButtonStart;
    }
}