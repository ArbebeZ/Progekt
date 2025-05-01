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
    public partial class GeneralMenu : Form
    {
        private Player player;
        public GeneralMenu(Player player)
        {
            InitializeComponent();
            this.player = player;
            label1.Text = $"Привет, {player.Name}!";
            player.RestoreResources();
            showStats();

            showStats();
        }
        
        public void showStats()
        {
            label2.Text = "Рівень:" + player.Level;
            labelExp3.Text = player.Experience + "/" + player.LevelCup;
            expBar1.Maximum = player.LevelCup;
            expBar1.Value = player.Experience;
            

            HealthLabel3.Text = "Здоров'я: " + player.Health + "/" + player.MaxHealth;
            healthBar1.Maximum = player.MaxHealth;
            healthBar1.Value = player.Health;

            ManaLabel3.Text = "Мана: " + player.Mana + "/" + player.MaxMana;
            ManaBar1.Maximum = player.MaxMana;
            ManaBar1.Value = player.Mana;

            strengthBox.Text = "Сила: " + player.Strength;
            enduranceBox.Text = "Витривалість: " + player.Endurance;
            agilityBox.Text = "Спритність: " + player.Agility;
            intelligenceBox.Text = "Інтелект: " + player.Intelligence;
            critChanceBox.Text = "Шанс крит. удару: " + player.CriticalChance.ToString("F1") + "%";
            goldBox.Text = "Золото: " + player.Gold;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop shop = new Shop(player);
            shop.Show();
        }

    }
}
