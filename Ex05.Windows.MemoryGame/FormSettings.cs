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
    public partial class FormSettings : Form
    {
        private readonly List<string> m_BoardSize;
        private int m_BoardSizeIndex;
        private string m_PlayerType;

        public FormSettings()
        {
            InitializeComponent();
            m_PlayerType = "Computer";
            this.m_ButtonAgainstAFriend.Click += m_ButtonAgainstAFriend_ClickFriend;
            this.m_ButtonBoardSize.Click += m_ButtonBoardSize_Click;
            m_BoardSize = new List<string>() { "4 x 4", "4 x 5", "4 x 6", "5 x 4", "5 x 6", "6 x 4", "6 x 5", "6 x 6" };
            this.m_ButtonStart.Click += m_ButtonStart_Click;
        }

        public string FirstPlayerName
        {
            get 
            {
                return m_TextBoxFirstPlayerName.Text;
            }
        }

        public string SecondPlayerName
        {
            get
            {
                return m_TextBoxFriend.Text;
            }
        }

        public string PlayerType
        {
            get
            {
                return m_PlayerType;
            }
        }

        public string BoardSize
        {
            get
            {
                return m_ButtonBoardSize.Text;
            }
        }

        private void m_ButtonAgainstAFriend_ClickFriend(object sender, EventArgs e)
        {
            m_PlayerType = "Player";
            this.m_TextBoxFriend.Text = string.Empty;
            this.m_TextBoxFriend.Enabled = true;
            this.m_ButtonAgainstAFriend.Text = "Against Computer";
            this.m_ButtonAgainstAFriend.Click -= m_ButtonAgainstAFriend_ClickFriend;
            this.m_ButtonAgainstAFriend.Click += m_ButtonAgainstAFriend_ClickComputer;
        }
        private void m_ButtonAgainstAFriend_ClickComputer(object sender, EventArgs e)
        {
            m_PlayerType = "Computer";
            this.m_TextBoxFriend.Text = "- computer -";
            this.m_TextBoxFriend.Enabled = false;
            this.m_ButtonAgainstAFriend.Text = "Against a Friend";
            this.m_ButtonAgainstAFriend.Click -= m_ButtonAgainstAFriend_ClickComputer;
            this.m_ButtonAgainstAFriend.Click += m_ButtonAgainstAFriend_ClickFriend;
        }

        private void m_ButtonBoardSize_Click(object sender, EventArgs e)
        {
            m_BoardSizeIndex = (m_BoardSizeIndex + 1) % m_BoardSize.Count;
            this.m_ButtonBoardSize.Text = m_BoardSize[m_BoardSizeIndex];
        }
        private void m_ButtonStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
