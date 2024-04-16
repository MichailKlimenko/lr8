using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр8
{
    public partial class Form1 : Form
    {
        // Интерфейс для кораблей
        public interface IShip
        {
            void Move(ListBox listBox);
            void Attack(ListBox listBox);
        }

        // Абстрактный класс для военных кораблей
        public abstract class Warship : IShip
        {
            public abstract void Move(ListBox listBox);
            public abstract void Attack(ListBox listBox);
        }

        // Класс для авианосца, который является подклассом военного корабля
        public class AircraftCarrier : Warship
        {
            public override void Move(ListBox listBox)
            {
                Random rnd = new Random();
                int result = rnd.Next(3);
                string[] moveResults = {
                "Авианосец движется по морю.",
                "Авианосец поворачивает на ветру.",
                "Авианосец сбрасывает якорь и останавливается."
            };
                listBox.Items.Add(moveResults[result]);
            }

            public override void Attack(ListBox listBox)
            {
                Random rnd = new Random();
                int result = rnd.Next(3);
                string[] attackResults = {
                "Авианосец выпускает самолеты для атаки.",
                "Авианосец запускает ракеты во вражеский флот.",
                "Авианосец начинает бомбардировку береговых укреплений."
            };
                listBox.Items.Add(attackResults[result]);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем объект авианосца
            Warship aircraftCarrier = new AircraftCarrier();
            // Вызываем метод движения и передаем listBox1 для вывода результатов
            aircraftCarrier.Move(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем объект авианосца
            Warship aircraftCarrier = new AircraftCarrier();
            // Вызываем метод атаки и передаем listBox1 для вывода результатов
            aircraftCarrier.Attack(listBox1);
        }
    }
}
