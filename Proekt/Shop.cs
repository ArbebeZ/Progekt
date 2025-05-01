using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    public partial class Shop : Form
    {
        private Player player;
        WeaponGenerator generator = new WeaponGenerator();
        private List<Weapon> myWeapons;

        public Shop(Player player)
        {
            
            InitializeComponent();

            ShowWeapons();
            this.player = player;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (player.SpendGold(myWeapons[0].Price))
            {
                player.Gold -= myWeapons[0].Price;
                player.Strength += myWeapons[0].AttackBonus;
                MessageBox.Show($"Вы купили {myWeapons[0].Name}");
            }
            else
            {
                MessageBox.Show("Недостаточно золота!");
            }
        }

        private void ShowWeapons()
        {
            myWeapons = generator.GenerateWeapons(5);

            label1.Text = $"{myWeapons[0].Name} — Атака: {myWeapons[0].AttackBonus}, Цена: {myWeapons[0].Price}";
            label1.BringToFront();
            label2.Text = $"{myWeapons[1].Name} — Атака: {myWeapons[1].AttackBonus}, Цена: {myWeapons[1].Price}";
            label2.BringToFront();
            label3.Text = $"{myWeapons[2].Name} — Атака: {myWeapons[2].AttackBonus}, Цена: {myWeapons[2].Price}";
            label3.BringToFront();
            label4.Text = $"{myWeapons[3].Name} — Атака: {myWeapons[3].AttackBonus}, Цена: {myWeapons[3].Price}";
            label4.BringToFront();
            label5.Text = $"{myWeapons[4].Name} — Атака: {myWeapons[4].AttackBonus}, Цена: {myWeapons[4].Price}";
            label5.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GeneralMenu generalMenu = new GeneralMenu(player);
            this.Hide();
            generalMenu.Show();
            generalMenu.showStats();
        }
    }
}
