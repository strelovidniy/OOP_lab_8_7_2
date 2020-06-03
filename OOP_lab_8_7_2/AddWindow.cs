using System;
using System.IO;
using System.Windows.Forms;

namespace OOP_lab_8_7_2
{
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("base.txt", true);

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
                Form Exception = new WrongFormatException();
                Exception.Show();
            }

            file.Close();

            new Input().Read();

            Close();
        }
    }
}
