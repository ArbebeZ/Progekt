using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proekt
{
    public partial class Shop : Form
    {
        private Player player;
        WeaponGenerator generator = new WeaponGenerator();
        ArmorGenerator armorGenerator = new ArmorGenerator();
        private List<Armor> myArmors;
        private List<Weapon> myWeapons;
        private bool isWeaponShop;

        public Shop(Player player)
        {
            
            InitializeComponent();
            Random random = new Random();
            int shopWA = random.Next(1, 3);

            if (shopWA == 1)
            {
                ShowWeapons();
            }
            else
            {
                ShowArmor();
            }
            
            this.player = player;
        }

        private void buttonBuy(int i)
        {
            if (isWeaponShop)
            {
                if (player.SpendGold(myWeapons[i].Price))
                {
                    player.setWeapon(myWeapons[i]);
                    MessageBox.Show($"Вы купили оружие: {player.weapon.Name}");
                }
                else
                {
                    MessageBox.Show("Недостаточно золота!");
                }
            }
            else
            {
                if (player.SpendGold(myArmors[i].Price))
                {
                    player.setArmor(myArmors[i]);
                    MessageBox.Show($"Вы купили броню: {player.armor.Name}");
                }
                else
                {
                    MessageBox.Show("Недостаточно золота!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonBuy(0);
        }

        private void fillingLabel(Label label, Weapon weapon)
        {
            label.Text = $"{weapon.Name} — Атака: {weapon.AttackBonus}, Цена: {weapon.Price}";
            label.BringToFront();
        }
        private void fillingLabelArmor(Label label, Armor armor)
        {
            label.Text = $"{armor.Name} — Броня: {armor.DefenseBonus}, Цена: {armor.Price}";
            label.BringToFront();
        }

        private void ShowWeapons()
        {
            isWeaponShop = true;
            myWeapons = generator.GenerateWeapons(5);
            Label[] labels = { label1 , label2 , label3 , label4 , label5 };

            for (int i = 0; i < myWeapons.Count; i++)
            {
                fillingLabel(labels[i], myWeapons[i]);
            }
        }
        private void ShowArmor()
        {
            isWeaponShop = false;
            myArmors = armorGenerator.GenerateArmors(5);
            Label[] labels = { label1, label2, label3, label4, label5 };

            for (int i = 0; i < myArmors.Count; i++)
            {
                fillingLabelArmor(labels[i], myArmors[i]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GeneralMenu generalMenu = new GeneralMenu(player);
            this.Hide();
            generalMenu.Show();
            generalMenu.showStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonBuy(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonBuy(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonBuy(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonBuy(4);
        }
    }
}
