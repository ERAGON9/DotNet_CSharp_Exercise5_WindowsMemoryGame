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
    public partial class FormGame : Form
    {
        ButtonCard[,] m_ButtonCards;

        public FormGame()
        {
            InitializeComponent();
        }

        public void SetWindowView(GameData i_GameEngine)
        {
            GameBoard gameBoard = i_GameEngine.Board;
            int boardRows = gameBoard.Height;
            int boardCols = gameBoard.Width;
            m_ButtonCards = new ButtonCard[boardRows, boardCols];

            setBoardCards(gameBoard, boardRows, boardCols);
            setLabels(i_GameEngine, boardRows, boardCols);
            setWindowSize(boardRows, boardCols);
        }

        private void setBoardCards(GameBoard i_GameBoard, int i_BoardRows, int i_BoardCols)
        {
            for (int i = 0; i < i_BoardRows; i++)
            {
                for (int j = 0; j < i_BoardCols; j++)
                {
                    ButtonCard buttomCard = new ButtonCard(i_GameBoard.GetCard(i, j));
                    int xLocation = 20 + j * (buttomCard.Width + 10);
                    int yLocation = 20 + i * (buttomCard.Height + 10);
                    buttomCard.Location = new Point(xLocation, yLocation);
                    Controls.Add(buttomCard);
                    m_ButtonCards[i, j] = buttomCard;
                }
            }
        }

        private void setWindowSize(int i_BoardRows, int i_BoardCols)
        {
            int width = i_BoardCols * m_ButtonCards[0, 0].Width + (i_BoardCols - 1) * 10 + 40;
            int height = i_BoardRows * m_ButtonCards[0, 0].Height + (i_BoardRows - 1) * 5
                + m_CurrentPlayer.Height + m_CurrentPlayer.Height + m_SecoundPlayer.Height + 100;
            this.ClientSize = new Size(width, height);
        }

        private void setLabels(GameData i_GameEngine, int i_BoardRows, int i_BoardCols)
        {
            string[] playersNames = i_GameEngine.GetPlayersNames();
            int[] playersScores = i_GameEngine.GetPlayersScore();

            m_CurrentPlayer.Text = $"Current Player: {i_GameEngine.GetPlayerNameOfCurrentTurn()}";
            int xLocation = 25 ;
            int yLocation = 25 + i_BoardRows * m_ButtonCards[0, 0].Height + (i_BoardRows - 1) * 10 + 20;
            m_CurrentPlayer.Location = new Point(xLocation, yLocation);

            m_FirstPlayer.Text = $"{playersNames[0]}: {playersScores[0]} Pairs";
            xLocation = 25;
            yLocation += m_CurrentPlayer.Height  + 10;
            m_FirstPlayer.Location = new Point(xLocation, yLocation);

            m_SecoundPlayer.Text = $"{playersNames[1]}: {playersScores[1]} Pairs";
            xLocation = 25;
            yLocation += m_SecoundPlayer.Height + 10;
            m_SecoundPlayer.Location = new Point(xLocation, yLocation);

        }

    }
}
