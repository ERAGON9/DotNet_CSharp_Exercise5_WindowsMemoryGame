using Ex05.Logic.MemoryGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.Windows.MemoryGame
{
    public partial class ButtonCardUserControl : UserControl
    {
        private readonly Card r_Card;

        public ButtonCardUserControl()
        {
            InitializeComponent();
        }

        public ButtonCardUserControl(Card i_Card)
        {
            InitializeComponent();
            r_Card = i_Card;
        }

        public Card Card
        {
            get
            {
                return r_Card;
            }
        }

        public string Text
        {
            get 
            {
                return m_ButtonCard.Text;
            }
            set 
            {
                m_ButtonCard.Text = value;
            }
        }

        private void m_ButtonCard_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
