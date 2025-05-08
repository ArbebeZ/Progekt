using System;
using System.Collections.Generic;

namespace Proekt
{
    internal class ArmorGenerator
    {
        string[] armorNames = { "Кожаный доспех", "Стальной шлем", "Магический плащ", "Щит света",
            "Темные латы", "Кольчуга дракона", "Огненный доспех", "Сапоги молнии", "Шлем мудреца" };
        Random random = new Random();

        public Armor GenerateArmor()
        {
            int defense = generateRandomDB();
            Armor armor = new Armor(generateRandomName(), generateRandomPrice(defense), defense);
            return armor;
        }

        public List<Armor> GenerateArmors(int count)
        {
            List<Armor> armors = new List<Armor>();
            for (int i = 0; i < count; i++)
            {
                armors.Add(GenerateArmor());
            }
            return armors;
        }

        public string generateRandomName()
        {
            return armorNames[random.Next(armorNames.Length)];
        }

        public int generateRandomDB()
        {
            return random.Next(10, 500);
        }

        public int generateRandomPrice(int defenseBonus)
        {
            return defenseBonus * 5;
        }
    }
}