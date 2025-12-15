using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_FinalProject_WinForm
{
    public abstract class SpecialDog : Card
    {
        SpecialDog(string cardName, int health, int damage, int manaCost, Image art) 
            : base(cardName, health, damage, manaCost, art)
        {

        }

    }
}
