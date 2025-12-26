using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsVsDogs
{
    public abstract class SpecialDog : Card
    {
        SpecialDog(string cardName, int health, int damage, int manaCost, Image art) 
            : base(cardName, health, damage, manaCost, art)
        {

        }

    }
}
