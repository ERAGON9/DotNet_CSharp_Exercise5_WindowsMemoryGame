using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Logic.MemoryGame
{
    public class GameData
    {
        private List<Player> m_Players; //List because if in the future we want to change the number of players during the game.
        private GameBoard m_Board;
        private Turn m_CurrentTurn;
        private readonly Random r_Random;
        private List<string> m_AvailableSquares;

        public GameData(int i_NumOfPlayers, string[] i_PlayersNames, string[] i_PlayersTypes)
        {
            m_Players = new List<Player>(i_NumOfPlayers);
            for (int i = 0; i < i_NumOfPlayers; i++)
            {
                m_Players.Add(new Player(i_PlayersNames[i], i_PlayersTypes[i]));
            }

            r_Random = new Random();
            m_AvailableSquares = new List<string>();
        }

        public string FirstPlayerName
        {
            get 
            { 
                return m_Players[0].Name;
            }
        }
        public string SecondPlayerName
        {
            get
            {
                return m_Players[1].Name;
            }
        }

        public GameBoard Board
        {
            get
            {
                return m_Board;
            }
        }

        public void InitialTurn()
        {
            m_CurrentTurn = new Turn(m_Players[0]);
        }

        public void InitialBoard(int i_Rows, int i_Cols)
        {
            m_Board = new GameBoard();
            m_Board.InitialGameBoard(i_Rows, i_Cols);
            initializeAvailableSquares();
        }

        private void initializeAvailableSquares()
        {
            char colChar;
            string square;

            for (int i = 1; i <= m_Board.Height; i++)
            {
                for (int j = 1; j <= m_Board.Width; j++)
                {
                    colChar = (char)('A' + j - 1);
                    square = $"{colChar}{i}";
                    m_AvailableSquares.Add(square);
                }
            }
        }

        public string ComputerChoosingSquare()
        {
            int randomIndex = r_Random.Next(m_AvailableSquares.Count);

            return m_AvailableSquares[randomIndex];
        }

        public string GetCurrenPlayerType()
        {
            return getPlayerTypeFromEnum(m_CurrentTurn.CurrentPlayer.Type);
        }

        private string getPlayerTypeFromEnum(ePlayerType i_PlayerTypeEnum)
        {
            string value;

            if (i_PlayerTypeEnum.Equals(ePlayerType.Player))
            {
                value = "Player";
            }
            else
            {
                value = "Computer";
            }

            return value;
        }

        public void FlipCardInCurrentTurn(string i_Square, int i_PartOfTurn)
        {
            int row, col;

            extractRowAndColFromSquareString(i_Square, out row, out col);
            if (i_PartOfTurn.Equals(1))
            {
                m_CurrentTurn.Card1 = m_Board.GetCard(row, col);
                m_CurrentTurn.FlipCard1();
            }
            else // i_PartOfTurn.Equals(2)
            {
                m_CurrentTurn.Card2 = m_Board.GetCard(row, col);
                m_CurrentTurn.FlipCard2();
            }

            m_AvailableSquares.Remove(i_Square);
        }

        public bool IsValidSquareInput(string i_Square, out string o_Message)
        {
            int row, col;
            bool isValid;

            extractRowAndColFromSquareString(i_Square, out row, out col);
            isValid = m_Board.IsValidSquare(row, col, out o_Message);

            return isValid;
        }

        public string GetPlayerNameOfCurrentTurn()
        {
            string playerName = getPlayerOfCurrentTurn().Name;

            return playerName;
        }

        public bool IsThereUnflippedCardsOnBoard()
        {
            return m_Board.IsThereUnflippedCards();
        }

        public void OperatesByChosenCards()
        {
            bool isAPair = isCardsTheSame();

            if (isAPair)
            {
                addPointToCurrentPlayer();
            }
            else
            {
                unflippCardsForCurrentTurn();
                addCardsToAvailableSquares();
                switchToNextPlayer();
            }

            System.Threading.Thread.Sleep(2000);
        }

        private bool isCardsTheSame()
        {
            bool isAPair = m_CurrentTurn.Card1.Content == m_CurrentTurn.Card2.Content;
            
            return isAPair;
        }

        private void addPointToCurrentPlayer()
        {
            m_CurrentTurn.CurrentPlayer.AddPointToPlayer();
        }

        private void unflippCardsForCurrentTurn()
        {
            m_CurrentTurn.UnflippedCards();
        }

        private void addCardsToAvailableSquares()
        {
            //m_AvailableSquares.Add(m_CurrentTurn.Card1.Location); לטפל בזה!
            //m_AvailableSquares.Add(m_CurrentTurn.Card2.Location);
        }

        private void switchToNextPlayer()
        {
            Player currentPlayer = m_CurrentTurn.CurrentPlayer;

            for (int i = 0; i < m_Players.Count; i++)
            {
                if (m_Players[i] == currentPlayer)
                {
                    int nextPlayerIndex = (i + 1) % m_Players.Count;
                    m_CurrentTurn.SwitchPlayerTurn(m_Players[nextPlayerIndex]);
                    break;
                }
            }
        }

        private Player getPlayerOfCurrentTurn()
        {
            return m_CurrentTurn.CurrentPlayer;
        }

        public int[] GetPlayersScore()
        {
            int[] playersScores = new int[m_Players.Count];

            for (int i = 0; i < m_Players.Count; i++)
            {
                playersScores[i] = m_Players[i].Points;
            }

            return playersScores;
        }
        
        public string[] GetPlayersNames()
        {
            string[] playersNames = new string[m_Players.Count];

            for (int i = 0; i < m_Players.Count; i++)
            {
                playersNames[i] = m_Players[i].Name;
            }

            return playersNames;
        }

        private void extractRowAndColFromSquareString(string i_Square, out int o_Row,
                                                      out int o_Col)
        {
            char colChar = i_Square[0];
            char rowChar = i_Square[1];

            o_Col = (colChar - 'A') + 1;
            o_Row = rowChar - '0';
        }
    }
}
