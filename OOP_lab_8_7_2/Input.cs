using System;
using System.IO;

namespace OOP_lab_8_7_2
{
    class Input
    {
        public void Read()
        {
            Program.weather.Clear();

            StreamReader file = new StreamReader("base.txt");

            string[] tempStr = file.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tempStr.Length; i += 5)
            {
                Program.weather.Add(new Weather(DateTime.Parse(tempStr[i]), tempStr[i + 1], int.Parse(tempStr[i + 2]), int.Parse(tempStr[i + 3]), int.Parse(tempStr[i + 4])));
            }

            file.Close();
        }
    }
}
