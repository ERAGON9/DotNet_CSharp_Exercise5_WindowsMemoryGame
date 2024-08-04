using Ex05.Logic.MemoryGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.Windows.MemoryGame
{
    public class ButtonCard : Button
    {
        private Card m_Card;

        public ButtonCard(Card i_Card)
        {
            InitializeComponent();
            m_Card = i_Card;
        }

        private void InitializeComponent()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Size = new System.Drawing.Size(70, 80);
            this.Text = string.Empty;
            this.TabStop = false;
        }

        public Card Card
        {
            get
            {
                return m_Card;
            }
            set 
            {
                m_Card = value;
            }
        }
    }
}
