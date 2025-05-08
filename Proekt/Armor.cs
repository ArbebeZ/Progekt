using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    public class Armor
    {
        public string Name { get; set; } = "";
        public int Price { get; set; } = 0;
        public int DefenseBonus { get; set; } = 0;

        public Armor(string Name, int Prise, int DefenseBonus)
        {
            this.Name = Name;
            this.Price = Prise;
            this.DefenseBonus = DefenseBonus;
        }
    }
}
