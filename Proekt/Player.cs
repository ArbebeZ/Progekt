using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    
    public class Player
    {
        public string Name { get; set; }

        public int Level = 1;
        public int LevelCup = 1000;
        public int Experience = 0;

        public int Strength = 0;
        public double CriticalChance = 0;

        public int Endurance = 0;
        public int Agility = 0;
        public int Intelligence = 0;

        public int Health = 0;
        public int MaxHealth = 100;
        public int Mana = 0;
        public int MaxMana = 100;
        public int Gold = 0;

        public Weapon weapon = null;
        public Armor armor = null;

        public void setWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }
        public void setArmor(Armor armor)
        {
            this.armor = armor;
        }

        //експа
        public void AddExperience(int value)
        {
            Experience += value;
            if (Experience >= LevelCup)
            {
                Experience -= LevelCup;
                Level++;
                LevelCup = LevelCup * Level; 
                MaxHealth += 10;
                MaxMana += 10;
                Health = MaxHealth;
                Mana = MaxMana;
            }
        }

        // Урон 
        public int getDamage()
        {
            int damage = Strength;

            if (weapon != null)
            {
                damage += weapon.AttackBonus;
            }
            return damage;
        }

        public void TakeDamage(int value)
        {
            Health -= value;
            if (Health < 0)
                Health = 0;
        }

        // Вос здоровья
        public void Heal(int value)
        {
            Health += value;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        // Исп маны
        public bool UseMana(int value)
        {
            if (Mana >= value)
            {
                Mana -= value;
                return true;
            }
            return false;
        }

        // Вос маны
        public void RestoreMana(int value)
        {
            Mana += value;
            if (Mana > MaxMana)
                Mana = MaxMana;
        }

        //деньги
        public void AddGold(int value)
        {
            Gold += value;
        }

        public bool SpendGold(int value)
        {
            if (Gold >= value)
            {
                Gold -= value;
                return true;
            }
            return false;
        }

        public void RestoreResources()
        {
            Health = MaxHealth;
            Mana = MaxMana;
        }
    }

}
