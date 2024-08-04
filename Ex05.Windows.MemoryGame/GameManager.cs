using Ex05.Logic.MemoryGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.Windows.MemoryGame
{
    internal class GameManager
    {
        private GameData m_GameEngine;
        private FormSettings m_FormSettings;
        private FormGame m_FormGame;
        private const int k_NumOfPlayers = 2;

        public GameManager()
        {
            m_FormSettings = new FormSettings();
            m_FormGame = new FormGame();
        }

        public void RunProgram()
        {
            setGameProperties();
            startNewGame();
        }

        private void setGameProperties()
        {
            m_FormSettings.ShowDialog();

            string[] playersNames = new string[k_NumOfPlayers];
            string[] playersTypes = new string[k_NumOfPlayers];

            playersNames[0] = m_FormSettings.FirstPlayerName;
            playersTypes[0] = "Player";
            playersNames[1] = m_FormSettings.SecondPlayerName;
            playersTypes[1] = m_FormSettings.PlayerType;
            m_GameEngine = new GameData(k_NumOfPlayers, playersNames, playersTypes);
        }

        private void startNewGame()
        {
            initialTurnAndBoard();
            m_FormGame.SetWindowView(m_GameEngine);
            m_FormGame.ShowDialog();

            while (m_FormGame.WantAnotherGame)
            {
                initialTurnAndBoard();
                initialPlayersScore();
                m_FormGame.ReseWindowView();
                m_FormGame.ShowDialog();
            }
        }

        private void initialTurnAndBoard()
        {
            m_GameEngine.InitialTurn();
            extractBoardRowsCols(m_FormSettings.BoardSize, out int boardRows, out int boardCols);
            m_GameEngine.InitialBoard(boardRows, boardCols);
        }

        private void initialPlayersScore()
        {
            m_GameEngine.InitialPlayersScore();
        }

        private void extractBoardRowsCols(string i_BoardSize, out int o_BoardRows, out int o_BoardCols)
        {
            o_BoardCols = i_BoardSize[0] - '0';
            o_BoardRows = i_BoardSize[4] - '0';
        }

//        private void runGame()
//        {
//            bool gameOver = false;

//            while (!gameOver)
//            {
//                updateScreenState();
//                playTurn();
//                if (!m_ProgramStillRunning)
//                {
//                    break;
//                }

//                m_GameEngine.OperatesByChosenCards();
//                gameOver = checkifGameOver();
//            }

//            if (gameOver)
//            {
//                printStatistics();
//                if (!toPlayAgain())
//                {
//                    quitGame();
//                }
//            }
//        }

//        private void updateScreenState()
//        {
//            //m_Board.PrintBoard(m_GameEngine.Board);
//        }

//        private void playTurn()
//        {
//            int partOfTurn = 1;

//            playPartOfTurn(partOfTurn, out bool isPlayerQuit);
//            if (!isPlayerQuit)
//            {
//                partOfTurn = 2;
//                playPartOfTurn(partOfTurn, out isPlayerQuit);
//            }
//        }

//        private void playPartOfTurn(int i_PartOfTurn, out bool o_IsPlayerQuit)
//        {
//            o_IsPlayerQuit = false;
//            Console.WriteLine("{0} turn, choose square:", m_GameEngine.GetPlayerNameOfCurrentTurn());
//            string chosenSquare = chooseSquare();

//            if (isPlayerQuit(chosenSquare))
//            {
//                o_IsPlayerQuit = true;
//                quitGame();
//                return;
//            }

//            m_GameEngine.FlipCardInCurrentTurn(chosenSquare, i_PartOfTurn);
//            updateScreenState();
//        }

//        private string chooseSquare()
//        {
//            string chosenSquare;
//            string currentPlayerType = m_GameEngine.GetCurrenPlayerType();

//            if (currentPlayerType == "Computer")
//            {
//                chosenSquare = m_GameEngine.ComputerChoosingSquare();
//            }
//            else
//            {
//                chosenSquare = getValidSquareFromPlayer();
//            }

//            return chosenSquare;
//        }

//        private string getValidSquareFromPlayer()
//        {
//            bool isValidSquare = false;
//            string square = null;
//            string errorMessage;

//            while (!isValidSquare)
//            {
//                square = getSquare();
//                if (isPlayerQuit(square))
//                {
//                    break;
//                }

//                isValidSquare = m_GameEngine.IsValidSquareInput(square, out errorMessage);
//                if (!isValidSquare)
//                {
//                    Console.WriteLine(errorMessage);
//                }
//            }

//            return square;
//        }

//        private bool isPlayerQuit(string i_PlayerInput)
//        {
//            const string k_QuitString = "Q";
//            bool isPlayerQuit = i_PlayerInput == k_QuitString;

//            return isPlayerQuit;
//        }

//        private void quitGame()
//        {
//            m_ProgramStillRunning = false;
//        }

//        private string getSquare()
//        {
//            bool isValidSquare = false;
//            string playerInput = null; // Always get value, always first iteration of while loop happens.

//            while (!isValidSquare)
//            {
//                Console.WriteLine("Please enter square to uncover letter for column and number for row (like: B2) or Q for Quit");
//                playerInput = Console.ReadLine();
//                if (isPlayerQuit(playerInput))
//                {
//                    break;
//                }

//                isValidSquare = checkSquareUIValidation(playerInput);
//            }

//            return playerInput;
//        }

//        private bool checkSquareUIValidation(string i_Square)
//        {
//            bool isValid = true;

//            if (i_Square.Length != 2 || !char.IsLetter(i_Square[0])
//                || !char.IsDigit(i_Square[1]))
//            {
//                Console.WriteLine("Input is not 1 letter and 1 digit. (form of: B2)");
//                isValid = false;
//            }

//            return isValid;
//        }

//        private bool checkifGameOver()
//        {
//            bool isLeftCardsToChoose = m_GameEngine.IsThereUnflippedCardsOnBoard();
//            bool gameOver = !isLeftCardsToChoose;

//            return gameOver;
//        }

//        private void printStatistics()
//        {
//            int[] playersScores = m_GameEngine.GetPlayersScore();
//            string[] playersNames = m_GameEngine.GetPlayersNames();

//            Console.WriteLine($@"--------GAME OVER--------
//{playersNames[0]} score: {playersScores[0]} points.
//{playersNames[1]} score: {playersScores[1]} points.");
//        }

//        private bool toPlayAgain()
//        {
//            const string k_PlayAgainOption = "yes";

//            Console.WriteLine(@"Want another round?
//For play again choose 'yes' else 'no'.");
//            string playAgainOption = getPlayAgainOption();
//            bool playAgain = playAgainOption == k_PlayAgainOption;

//            return playAgain;
//        }

//        private string getPlayAgainOption()
//        {
//            bool isValidInput = false;
//            const string k_PlayAgainOption = "yes";
//            const string k_QuitOption = "no";
//            string input = null;

//            while (!isValidInput)
//            {
//                input = Console.ReadLine();
//                if (input.Equals(k_PlayAgainOption) || input.Equals(k_QuitOption))
//                {
//                    break;
//                }

//                Console.WriteLine("Invalid option, try again");
//            }

//            return input;
//        }
    }
}
