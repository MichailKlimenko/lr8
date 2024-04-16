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
    public partial class Form2 : Form
    {
        // Абстрактный класс "Работник фирмы"
        public abstract class Employee
        {
            public string Name { get; set; }
            public int EmployeeID { get; set; }

            public Employee(string name, int employeeID)
            {
                Name = name;
                EmployeeID = employeeID;
            }

            // Общий метод для всех работников
            public virtual void Work(ListBox listBox)
            {
                listBox.Items.Add("Работник " + Name + " выполняет свои обязанности.");
            }
        }

        // Подкласс для программиста
        public class Programmer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            public Programmer(string name, int employeeID, string programmingLanguage) : base(name, employeeID)
            {
                ProgrammingLanguage = programmingLanguage;
            }

            // Переопределение метода работы для программиста
            public override void Work(ListBox listBox)
            {
                listBox.Items.Add("Программист " + Name + " пишет код на " + ProgrammingLanguage);
            }
        }

        // Подкласс для дизайнера
        public class Designer : Employee
        {
            public string DesignSoftware { get; set; }

            public Designer(string name, int employeeID, string designSoftware) : base(name, employeeID)
            {
                DesignSoftware = designSoftware;
            }

            // Переопределение метода работы для дизайнера
            public override void Work(ListBox listBox)
            {
                listBox.Items.Add("Дизайнер " + Name + " создает макеты в " + DesignSoftware);
            }
        }

        // Подкласс для тестировщика
        public class Tester : Employee
        {
            public string TestingMethodology { get; set; }

            public Tester(string name, int employeeID, string testingMethodology) : base(name, employeeID)
            {
                TestingMethodology = testingMethodology;
            }

            // Переопределение метода работы для тестировщика
            public override void Work(ListBox listBox)
            {
                listBox.Items.Add("Тестировщик " + Name + " проводит тестирование по методологии " + TestingMethodology);
            }
        }

        // Подкласс для менеджера
        public class Manager : Employee
        {
            public string Department { get; set; }

            public Manager(string name, int employeeID, string department) : base(name, employeeID)
            {
                Department = department;
            }

            // Переопределение метода работы для менеджера
            public override void Work(ListBox listBox)
            {
                listBox.Items.Add("Менеджер " + Name + " координирует работу " + Department);
            }
        }

        // Подкласс для аналитика
        public class Analyst : Employee
        {
            public string AreaOfExpertise { get; set; }

            public Analyst(string name, int employeeID, string areaOfExpertise) : base(name, employeeID)
            {
                AreaOfExpertise = areaOfExpertise;
            }

            // Переопределение метода работы для аналитика
            public override void Work(ListBox listBox)
            {
                listBox.Items.Add("Аналитик " + Name + " анализирует данные в области " + AreaOfExpertise);
            }
        }

        private List<Employee> employees = new List<Employee>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вызов метода работы для каждого работника в массиве
            foreach (Employee employee in employees)
            {
                employee.Work(listBox1);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Создание объектов работников и добавление их в массив
            employees.Add(new Manager("Иванов", 1, "Отдел продаж"));
            employees.Add(new Analyst("Петров", 2, "Финансовый анализ"));
            employees.Add(new Programmer("Сидоров", 3, "C#"));
            employees.Add(new Designer("Козлов", 4, "Adobe Photoshop"));
            employees.Add(new Tester("Смирнов", 5, "Agile"));
        }
    }
}
