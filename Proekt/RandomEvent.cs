using System;
using System.Windows.Forms;

namespace Proekt
{
    public class RandomEvent
    {
        public void RandomEvents(Player player)
        {
            Random random = new Random();
            int Event = random.Next(1, 11);

            switch (Event)
            {
                case 1:
                    player.Gold += random.Next(100, 10000);
                    MessageBox.Show("Ви знайшли скарб! +золото");
                    break;
                case 2:
                    player.Health = Math.Min(player.MaxHealth, player.Health + 30);
                    MessageBox.Show("Зілля здоров’я! +30 HP");
                    break;
                case 3:
                    player.Strength += 1;
                    MessageBox.Show("+1 Сила");
                    break;
                case 4:
                    player.Intelligence += 1;
                    MessageBox.Show("+1 Інтелект");
                    break;
                case 5:
                    player.CriticalChance += 2.0;
                    MessageBox.Show("Прокачка крит. шансу! +2%");
                    break;
                case 6:
                    player.Agility += 1;
                    MessageBox.Show("+1 Спритність");
                    break;
                case 7:
                    player.Endurance += 1;
                    MessageBox.Show("+1 Витривалість");
                    break;
                case 8:
                    int lostGold = random.Next(100, 100000);
                    player.Gold = Math.Max(0, player.Gold - lostGold);
                    MessageBox.Show($"Вас пограбували! -{lostGold} золота");
                    break;
                case 9:
                    player.Health = Math.Max(0, player.Health - random.Next(20, 51));
                    MessageBox.Show("Вас вдарили! Ви втратили частину здоров’я");
                    break;
                case 10:
                    player.Strength = Math.Max(0, player.Strength - 10);
                    MessageBox.Show("Прокляття слабкості! -10 Сила");
                    break;
            }
        }
    }
}