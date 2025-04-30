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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox5.Text.Trim();

            if (!string.IsNullOrEmpty(Name))
            {
                Player player = new Player();
                player.Name = Name;
                GeneralMenu generalMenu = new GeneralMenu(player);
                generalMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введите имя!");
            }
        }
    }
}
