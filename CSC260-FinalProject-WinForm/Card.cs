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

        public Card(string cardName, int health, int damage, int manaCost)
        {
            this.cardName = cardName;
            this.health = health;
            this.damage = damage;
            this.manaCost = manaCost;
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
