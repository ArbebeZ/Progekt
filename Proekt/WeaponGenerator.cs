using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    internal class WeaponGenerator
    {
        string[] weaponNames = { "Кровавый клинок", "Звёздный меч", "Теневой топор", "Светящийся щит",
            "Ледяная секира", "Молниеносный жезл", "Серебряная булава", "Духовный кинжал", "Тёмный арбалет" };
        Random random = new Random();

        public Weapon GenerateWeapon()
        {
            int price = generateRandomAttackBonus();
            Weapon weapon = new Weapon(generateRandomNames(), generateRandomPrice(price), price);

            return weapon;
        }

        public List<Weapon> GenerateWeapons(int count)
        {
            List<Weapon> weapons = new List<Weapon>();
            for (int i = 0; i < count; i++)
            {
                weapons.Add(GenerateWeapon());
            }
            return weapons;
        }


        public string generateRandomNames()
        {
            return weaponNames[random.Next(weaponNames.Length)];
        }

        public int generateRandomAttackBonus()
        {
            return random.Next(10,1000);
        }

        public int generateRandomPrice(int attackBonus)
        {
            return attackBonus * 5;
        }
    }
}
