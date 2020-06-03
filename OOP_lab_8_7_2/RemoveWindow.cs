using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_lab_8_7_2
{
    public partial class RemoveWindow : Form
    {
        public RemoveWindow()
        {
            InitializeComponent();

            InitializeList();
        }

        private void InitializeList()
        {
            checkedListBox1.Items.Clear();

            foreach (Weather w in Program.weather)
            {
                checkedListBox1.Items.Add(w.Date.ToShortDateString() + " " + w.City + " " + w.Pressure + " " + w.Temperature + " " + w.WindSpeed);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            List<Weather> removeWeather = new List<Weather>();

            foreach (string remove in checkedListBox1.CheckedItems)
            {
                foreach (Weather weather in Program.weather)
                {
                    if (remove == weather.Date.ToShortDateString() + " " + weather.City + " " + weather.Pressure + " " + weather.Temperature + " " + weather.WindSpeed)
                    {
                        removeWeather.Add(weather);
                    }
                }
            }

            foreach (Weather weather in removeWeather)
            {
                Program.weather.Remove(weather);
            }

            new Work().Save();

            Close();
        }
    }
}
