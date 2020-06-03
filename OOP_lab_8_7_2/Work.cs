using System;
using System.IO;
using System.Linq;

namespace OOP_lab_8_7_2
{
    class Work
    {
        public void Save()
        {
            StreamWriter file = new StreamWriter("base.txt");

            foreach (Weather weather in Program.weather)
            {
                file.WriteLine(weather.Date.ToShortDateString());
                file.WriteLine(weather.City);
                file.WriteLine(weather.Pressure);
                file.WriteLine(weather.Temperature);
                file.WriteLine(weather.WindSpeed);
            }

            file.Close();

            new Input().Read();
        }

        public void SortByDate()
        {
            Console.WriteLine();

            Program.weather.Sort();

        }

        public void SortByTemperature()
        {
            Console.WriteLine();

            Weather[] tempW = Program.weather.ToArray();

            Array.Sort(tempW, new Weather.SortByTemperature());

            Program.weather = tempW.ToList();

        }

        public void SortByWindSpeed()
        {
            Console.WriteLine();

            Weather[] tempW = Program.weather.ToArray();

            Array.Sort(tempW, new Weather.SortByWindSpeed());

            Program.weather = tempW.ToList();

        }

        public void SortByPerssure()
        {
            Console.WriteLine();

            Weather[] tempW = Program.weather.ToArray();

            Array.Sort(tempW, new Weather.SortByPressure());

            Program.weather = tempW.ToList();

        }
    }
}
