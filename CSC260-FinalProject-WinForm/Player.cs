using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_FinalProject_WinForm
{
    internal class Player
    {
        private string _chosenTeam;
        private int _health;
        private int _mana;
        public List<Card> hand;

        public Player(string team)
        {
            _chosenTeam = team;
        }

        public void takeDamage(int damage)
        {

        }

        public void consumeMana(int mana)
        {

        }

        public void playCard(Card card)
        {

        }
    }
}
