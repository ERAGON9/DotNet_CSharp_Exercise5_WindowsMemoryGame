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
        private GameData m_GameEngine;
        private ButtonCard[,] m_ButtonCards;
        private int m_TurnPart;
        private bool m_WantAnotherRound;
        private bool m_GameOver;

        public FormGame()
        {
            InitializeComponent();
            m_TurnPart = 1;
            m_WantAnotherRound = false;
            m_GameOver = false;
        }

        public bool WantAnotherGame
        {
            get 
            {
                return m_WantAnotherRound;
            }
        }

        public void SetWindowView(GameData i_GameEngine)
        {
            m_GameEngine = i_GameEngine;
            GameBoard gameBoard = m_GameEngine.Board;
            int boardRows = gameBoard.Height;
            int boardCols = gameBoard.Width;
            m_ButtonCards = new ButtonCard[boardRows, boardCols];

            setBoardCards(gameBoard, boardRows, boardCols);
            setLabels(boardRows, boardCols);
            setWindowSize(boardRows, boardCols);
        }

        private void setBoardCards(GameBoard i_GameBoard, int i_BoardRows, int i_BoardCols)
        {
            for (int i = 0; i < i_BoardRows; i++)
            {
                for (int j = 0; j < i_BoardCols; j++)
                {
                    ButtonCard buttonCard = new ButtonCard(i_GameBoard.GetCard(i, j));
                    int xLocation = 20 + j * (buttonCard.Width + 10);
                    int yLocation = 20 + i * (buttonCard.Height + 10);
                    buttonCard.Location = new Point(xLocation, yLocation);
                    buttonCard.Click += ButtonCard_Click;
                    Controls.Add(buttonCard);
                    m_ButtonCards[i, j] = buttonCard;
                }
            }
        }

        private void setLabels(int i_BoardRows, int i_BoardCols)
        {
            string[] playersNames = m_GameEngine.GetPlayersNames();
            int[] playersScores = m_GameEngine.GetPlayersScore();

            m_CurrentPlayer.Text = $"Current Player: {m_GameEngine.GetPlayerNameOfCurrentTurn()}";
            int xLocation = 25;
            int yLocation = 25 + i_BoardRows * m_ButtonCards[0, 0].Height + (i_BoardRows - 1) * 10 + 20;
            m_CurrentPlayer.Location = new Point(xLocation, yLocation);

            m_FirstPlayer.Text = $"{playersNames[0]}: {playersScores[0]} Pairs";
            xLocation = 25;
            yLocation += m_CurrentPlayer.Height + 10;
            m_FirstPlayer.Location = new Point(xLocation, yLocation);

            m_SecoundPlayer.Text = $"{playersNames[1]}: {playersScores[1]} Pairs";
            xLocation = 25;
            yLocation += m_SecoundPlayer.Height + 10;
            m_SecoundPlayer.Location = new Point(xLocation, yLocation);

        }

        private void setWindowSize(int i_BoardRows, int i_BoardCols)
        {
            int width = i_BoardCols * m_ButtonCards[0, 0].Width + (i_BoardCols - 1) * 10 + 40;
            int height = i_BoardRows * m_ButtonCards[0, 0].Height + (i_BoardRows - 1) * 5
                + m_CurrentPlayer.Height + m_CurrentPlayer.Height + m_SecoundPlayer.Height + 100;
            this.ClientSize = new Size(width, height);
        }

        public void ReseWindowView()
        {
            m_WantAnotherRound = false;
            m_GameOver = false;
            resetBoard();
            resetLabels();
        }

        private void resetBoard()
        {
            GameBoard gameBoard = m_GameEngine.Board;
            int boardRows = gameBoard.Height;
            int boardCols = gameBoard.Width;

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardCols; j++)
                {
                    ButtonCard buttonCard = m_ButtonCards[i, j];
                    buttonCard.Card = gameBoard.GetCard(i, j);
                    unFlipCardUI(buttonCard);
                }
            }
        }

        private void resetLabels()
        {
            string[] playersNames = m_GameEngine.GetPlayersNames();
            int[] playersScores = m_GameEngine.GetPlayersScore();

            updateCurrentPlayerLabelUI();
            m_FirstPlayer.Text = $"{playersNames[0]}: {playersScores[0]} Pairs";
            m_SecoundPlayer.Text = $"{playersNames[1]}: {playersScores[1]} Pairs";
        }

        public void ButtonCard_Click(object sender, EventArgs e)
        {
            playPartOfTurn(sender, m_TurnPart);
            if (m_TurnPart == 2)
            {
                m_TurnPart = 1;
                m_GameEngine.OperatesByChosenCards();
                if (m_GameEngine.IsCardsTheSame())
                {
                    updateScoreUI();
                    if (checkIfGameOver() == true)
                    {
                        m_GameOver = true;
                        endGameMessage();
                    }
                }
                else
                {
                    unflipCardsUI();
                    updateCurrentPlayerLabelUI();
                }

                if (!m_GameOver && m_GameEngine.GetCurrentPlayerType().Equals("Computer"))
                {
                    computerTurn();
                }
            }
            else
            {
                m_TurnPart = 2;
            }
        }

        private void endGameMessage()
        {
            int[] playersScores = m_GameEngine.GetPlayersScore();
            string[] playersNames = m_GameEngine.GetPlayersNames();
            string gamefinishPosition = finishPosition(out string caption);
            string text = $@"--------GAME OVER--------
{playersNames[0]} score: {playersScores[0]} pairs.
{playersNames[1]} score: {playersScores[1]} pairs.
{gamefinishPosition}
Want another round?";

            DialogResult action = MessageBox.Show(text, caption,MessageBoxButtons.YesNo);
            if (action.Equals(DialogResult.Yes))
            {
                m_WantAnotherRound = true;
            }

            this.Close();
        }

        private string finishPosition(out string o_Caption)
        {
            int[] playersScores = m_GameEngine.GetPlayersScore();
            string[] playersNames = m_GameEngine.GetPlayersNames();
            string finishPosition;

            if (playersScores[0] > playersScores[1])
            {
                finishPosition = $"{playersNames[0]} win!";
                o_Caption = "Win";
            }
            else if (playersScores[0] < playersScores[1])
            {
                finishPosition = $"{playersNames[1]} win!";
                o_Caption = "Win";
            }
            else
            {
                finishPosition = $"It's a draw!";
                o_Caption = "Draw";
            }

            return finishPosition;
        }

        private void playPartOfTurn(object i_sender,int i_PartOfTurn)
        {
            if (i_sender != null)
            {
                ButtonCard buttomCardSender = i_sender as ButtonCard;
                m_GameEngine.FlipCardInCurrentTurn(buttomCardSender.Card.Row, buttomCardSender.Card.Col, m_TurnPart);
                flipCardUI(buttomCardSender);
            }
        }

        private void flipCardUI(ButtonCard i_ButtonCard)
        {
            i_ButtonCard.BackColor = m_CurrentPlayer.BackColor;
            i_ButtonCard.Text = getCardContent(i_ButtonCard.Card.Content).ToString();
            i_ButtonCard.Enabled = false;
        }

        private char getCardContent(uint i_Content)
        {
            return (char)('A' + i_Content);
        }

        private void updateScoreUI()
        {
            string[] playersNames = m_GameEngine.GetPlayersNames();
            int[] playersScores = m_GameEngine.GetPlayersScore();

            m_FirstPlayer.Text = $"{playersNames[0]}: {playersScores[0]} Pairs";
            m_SecoundPlayer.Text = $"{playersNames[1]}: {playersScores[1]} Pairs";
        }

        private bool checkIfGameOver()
        {
            bool isLeftCardsToChoose = m_GameEngine.IsThereUnflippedCardsOnBoard();
            bool gameOver = !isLeftCardsToChoose;

            return gameOver;
        }

        private void unflipCardsUI()
        {
            Card[] cards = m_GameEngine.GetCurrentTurnCards();
            ButtonCard firstButtonCard = m_ButtonCards[cards[0].Row, cards[0].Col];
            unFlipCardUI(firstButtonCard);
            ButtonCard secondButtonCard = m_ButtonCards[cards[1].Row, cards[1].Col];
            unFlipCardUI(secondButtonCard);
        }

        private void unFlipCardUI(ButtonCard i_ButtonCard)
        {
            i_ButtonCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            i_ButtonCard.Text = string.Empty;
            i_ButtonCard.Enabled = true;
        }

        private void updateCurrentPlayerLabelUI()
        {
            string playerName = m_GameEngine.GetPlayerNameOfCurrentTurn();

            m_CurrentPlayer.Text = $"Current Player: {playerName}";
            if (playerName.Equals(getNameFromTextUntilColon(m_FirstPlayer.Text)))
            {
                m_CurrentPlayer.BackColor = m_FirstPlayer.BackColor;
            }
            else
            {
                m_CurrentPlayer.BackColor = m_SecoundPlayer.BackColor;
            }

        }

        private string getNameFromTextUntilColon(string i_Text)
        {
            int colonIndex = i_Text.IndexOf(':');
            string onlyName = i_Text.Substring(0, colonIndex);

            return onlyName;
        }

        private void computerTurn()
        {
            computerPartOfTurn();
            System.Threading.Thread.Sleep(1000);
            computerPartOfTurn();
        }

        private void computerPartOfTurn()
        {
            Card computerCard = m_GameEngine.ComputerChoosingCard();
            ButtonCard_Click(m_ButtonCards[computerCard.Row, computerCard.Col], EventArgs.Empty);
        }
    }
}
