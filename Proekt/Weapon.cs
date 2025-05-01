using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    internal class Weapon
    {
        public string Name { get; set; }

        public int Price { get; set; } = 0;
        public int AttackBonus { get; set; } = 0;

        public Weapon(string Name, int Prise, int AttackBonus) 
        { 
            this.Name = Name;
            this.Price = Prise;
            this.AttackBonus = AttackBonus;
        }
    }
}
