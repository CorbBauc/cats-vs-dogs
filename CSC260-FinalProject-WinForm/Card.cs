using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_FinalProject_WinForm
{
    public abstract class Card
    {
        protected string cardName;
        protected int health;
        protected int damage;
        protected int manaCost;
        protected Image art;

        public Card(string cardName, int health, int damage, int manaCost,Image art)
        {
            this.cardName = cardName;
            this.health = health;
            this.damage = damage;
            this.manaCost = manaCost;
            this.art = art;
        }

        public int Health
        {
            get {  return health; }
            set { health = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Mana
        {
            get { return manaCost; }
            set { manaCost = value; }
        }

        public Image Art
        {
            get { return art; }
            set { art = value; }
        }

        protected virtual void useSpecialAbility()
        {

        }

        protected void TakeCardDamage()
        {

        }

        protected void IncreaseCardDamage()
        {

        }

        protected void IncreaseCardHealth()
        {

        }

        protected void DecreaseManaCost()
        {

        }

    }
}
