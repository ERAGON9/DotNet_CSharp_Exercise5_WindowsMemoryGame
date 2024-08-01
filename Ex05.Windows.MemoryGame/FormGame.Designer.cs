namespace Ex05.Windows.MemoryGame
{
    partial class FormGame
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
            this.m_CurrentPlayer = new System.Windows.Forms.Label();
            this.m_FirstPlayer = new System.Windows.Forms.Label();
            this.m_SecoundPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_CurrentPlayer
            // 
            this.m_CurrentPlayer.AutoSize = true;
            this.m_CurrentPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_CurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CurrentPlayer.Location = new System.Drawing.Point(25, 225);
            this.m_CurrentPlayer.Name = "m_CurrentPlayer";
            this.m_CurrentPlayer.Size = new System.Drawing.Size(145, 18);
            this.m_CurrentPlayer.TabIndex = 0;
            this.m_CurrentPlayer.Text = "Current Player: Dana";
            // 
            // m_FirstPlayer
            // 
            this.m_FirstPlayer.AutoSize = true;
            this.m_FirstPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_FirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FirstPlayer.Location = new System.Drawing.Point(25, 255);
            this.m_FirstPlayer.Name = "m_FirstPlayer";
            this.m_FirstPlayer.Size = new System.Drawing.Size(97, 18);
            this.m_FirstPlayer.TabIndex = 1;
            this.m_FirstPlayer.Text = "Dana: 2 Pairs";
            // 
            // m_SecoundPlayer
            // 
            this.m_SecoundPlayer.AutoSize = true;
            this.m_SecoundPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.m_SecoundPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_SecoundPlayer.Location = new System.Drawing.Point(25, 285);
            this.m_SecoundPlayer.Name = "m_SecoundPlayer";
            this.m_SecoundPlayer.Size = new System.Drawing.Size(102, 18);
            this.m_SecoundPlayer.TabIndex = 2;
            this.m_SecoundPlayer.Text = "Amir: 1 Pair(s)";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 312);
            this.Controls.Add(this.m_SecoundPlayer);
            this.Controls.Add(this.m_FirstPlayer);
            this.Controls.Add(this.m_CurrentPlayer);
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_CurrentPlayer;
        private System.Windows.Forms.Label m_FirstPlayer;
        private System.Windows.Forms.Label m_SecoundPlayer;
    }
}