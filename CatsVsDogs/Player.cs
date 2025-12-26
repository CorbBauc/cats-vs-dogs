using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsVsDogs
{
    public class Player
    {
        private string _name;
        private string _team;
        private int _health;
        private int _mana;
        public List<Card> Hand;

        public Player()
        {
            _health = 15;
            _mana = 2;
            Hand = new List<Card>();
        }

        public Player(string name, string team)
        {
            _name = name;
            _team = team;
            _health = 15;
            _mana = 2;
            Hand = new List<Card>();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }

        public int Health
        {
            get { return _health; } 
            set { _health = value; }
        }

        public int Mana
        {
            get { return _mana; }  
            set { _mana = value; }
        }

        public void takeDamage(int damage)
        {

        }

        public void consumeMana(int mana)
        {
            _mana -= mana;
        }

        public void playCard(Card card)
        {

        }
    }
}
