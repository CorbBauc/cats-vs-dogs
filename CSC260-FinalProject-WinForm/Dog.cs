using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_FinalProject_WinForm
{
    public abstract class Dog : Card
    {
        public Dog(int health, int damage, int manaCost ) 
            : base(health, damage, manaCost)
        {

        }
    }
}
