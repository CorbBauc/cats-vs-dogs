using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_FinalProject_WinForm
{
    public class Game
    {
        private Player _playerOne;
        private Player _playerTwo;
        private Player _currentPlayer;

        public Game()
        {
            
        }

        public Game(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _currentPlayer = playerOne;
        }

        public Player PlayerOne 
        {
            get { return _playerOne; } 
            set { _playerOne = value; }
        }

        public Player PlayerTwo
        {
            get { return _playerTwo; }
            set { _playerTwo = value; }
        }

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
        }

        public void startGame()
        {

        }

        public void endGame()
        {

        }

        public void startTurn() 
        { 

        }

        public void endTurn()
        {
            if(_currentPlayer == _playerOne)
            {
                _currentPlayer = _playerTwo;
                _playerTwo.Mana += 1;
            }
            else
            {
                _currentPlayer = _playerOne;
                _playerOne.Mana += 1;
            }
        }


    }
}
