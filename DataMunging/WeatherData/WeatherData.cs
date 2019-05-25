using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WeatherData
{
    public class WeatherData
    {
        struct Weather
        {
            public int Dy, MxT, MnT;

            public Weather(GroupCollection args)
            {
                Console.WriteLine(args[1].Value +" day " + args[2].Value + " max " + args[3].Value + " min");
                Dy = args[1].Value == "mo" ? -1 : Int32.Parse(args[1].Value);
                MxT = Int32.Parse(args[2].Value);
                MnT   = Int32.Parse(args[3].Value);
            }

            public int Spread()
            {
                return MxT - MnT;
            }
        }

        string _path = "weather.dat";

        private List<Weather> ExtractData()
        {
            string[] lines = System.IO.File.ReadAllLines(_path);

            // First line is the names, and the second is empty
            List<Weather> data = new List<Weather>();

            for (var i = 2; i < lines.Length -1; i++)
            {
                string line = lines[i];
                Match match = Regex.Match(line,@"\s+([\d]+)\*?\s+([\d]+)\*?\s+([\d]+)\*?.*");

                Weather day = new Weather(match.Groups);              
                data.Add(day);
            }

            return data;
        }

        public int SmallestSpread()
        {
            List<Weather> data = ExtractData();

            int smallest = 99999;
            int dayNumber = -1;
            foreach (Weather day in data)
            {
                int spread = day.Spread();
                if (spread < smallest)
                {
                    dayNumber = day.Dy;
                    smallest = spread;
                }
            }

            return dayNumber;
        }
    }
}
