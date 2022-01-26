using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }
        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " Lançou uma magia super efetiva com bonus de "+bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força franca de "+bonus;
            }
            
        }
    }
}
