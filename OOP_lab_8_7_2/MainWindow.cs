using System;
using System.Windows.Forms;
using System.Linq;

namespace OOP_lab_8_7_2
{
    public partial class MainWindow
    {
        public const string Format = "{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form Add = new AddWindow();
            Add.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Form Edit = new EditWindow();
            Edit.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Form Remove = new RemoveWindow();
            Remove.Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Write();
        }

        private void SortByDate_Click(object sender, EventArgs e)
        {
            Program.weather.Sort();

            Write();
        }

        private void SortByTemperature_Click(object sender, EventArgs e)
        {
            Weather[] tempW = Program.weather.ToArray();

            Array.Sort(tempW, new Weather.SortByTemperature());

            Program.weather = tempW.ToList();

            Write();
        }

        private void SortByPressure_Click(object sender, EventArgs e)
        {
            Weather[] tempW = Program.weather.ToArray();

            Array.Sort(tempW, new Weather.SortByPressure());

            Program.weather = tempW.ToList();

            Write();
        }

        private void SortByWindSpeed_Click(object sender, EventArgs e)
        {
            Weather[] tempW = Program.weather.ToArray();

            Array.Sort(tempW, new Weather.SortByWindSpeed());

            Program.weather = tempW.ToList();

            Write();
        }

        private void Write()
        {
            richTextBox1.Text = "";

            richTextBox1.Text += "     " + "Дата" + "         " + "Мiсто" + "   " + "Атмосферний тиск" + "   " + "Температура повiтря" + "   " + "Швидкiсть вiтру" + "\r\n";

            foreach (Weather w in Program.weather)
            {
                richTextBox1.Text += w.Date.ToShortDateString() + "   " + w.City + "                " + w.Pressure + "                            " + w.Temperature + "                                 " + w.WindSpeed + "\r\n";
            }
        }
    }
}
