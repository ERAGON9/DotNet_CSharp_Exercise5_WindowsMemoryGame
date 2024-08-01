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
    public partial class ButtonCard : UserControl
    {
        Card m_Card;
        public ButtonCard(Card i_Card)
        {
            InitializeComponent();
            m_Card = i_Card;
        }
    }
}
