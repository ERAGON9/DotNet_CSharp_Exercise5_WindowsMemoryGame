namespace Ex05.Windows.MemoryGame
{
    partial class ButtonCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_ButtonCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonCard
            // 
            this.m_ButtonCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_ButtonCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ButtonCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonCard.Location = new System.Drawing.Point(0, 0);
            this.m_ButtonCard.Name = "m_ButtonCard";
            this.m_ButtonCard.Size = new System.Drawing.Size(70, 80);
            this.m_ButtonCard.TabIndex = 0;
            this.m_ButtonCard.UseVisualStyleBackColor = false;
            // 
            // ButtonCard
            // 
            this.Controls.Add(this.m_ButtonCard);
            this.Name = "ButtonCard";
            this.Size = new System.Drawing.Size(70, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonCard;
    }
}
