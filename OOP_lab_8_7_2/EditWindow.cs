using System;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace OOP_lab_8_7_2
{
    public partial class EditWindow : Form
    {
        public EditWindow()
        {
            InitializeComponent();

            InitializeList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = comboBox1.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {

            }
        }

        private void InitializeList()
        {
            comboBox1.Items.Clear();

            foreach (Weather weather in Program.weather)
            {
                comboBox1.Items.Add(weather.Date.ToShortDateString() + " " + weather.City + " " + weather.Pressure + " " + weather.Temperature + " " + weather.WindSpeed);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("base.txt");

            foreach (Weather weather in Program.weather)
            {
                if (weather.Date.ToShortDateString() + " " + weather.City + " " + weather.Pressure + " " + weather.Temperature + " " + weather.WindSpeed == comboBox1.SelectedItem.ToString())
                {
                    string[] temp = richTextBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    try
                    {
                        file.WriteLine(DateTime.Parse(temp[0]).ToShortDateString());
                        file.WriteLine(temp[1]);
                        file.WriteLine(int.Parse(temp[2]));
                        file.WriteLine(int.Parse(temp[3]));
                        file.WriteLine(int.Parse(temp[4]));
                    }
                    catch (Exception)
                    {
                        file.WriteLine(weather.Date.ToShortDateString());
                        file.WriteLine(weather.City);
                        file.WriteLine(weather.Pressure);
                        file.WriteLine(weather.Temperature);
                        file.WriteLine(weather.WindSpeed);

                        Form Exception = new WrongFormatException();
                        Exception.Show();
                    }
                }
                else
                {
                    file.WriteLine(weather.Date.ToShortDateString());
                    file.WriteLine(weather.City);
                    file.WriteLine(weather.Pressure);
                    file.WriteLine(weather.Temperature);
                    file.WriteLine(weather.WindSpeed);
                }
            }

            file.Close();

            new Input().Read();

            Close();
        }
    }
}
