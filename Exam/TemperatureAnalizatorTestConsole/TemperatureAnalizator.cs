using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TemperatureAnalizatorTestConsole
{
    class TemperatureAnalizator
    {
        //MAX
        public double FindValue(double x)
        {
            double t = 0; // t = temperature
            StreamReader reader = File.OpenText("input.txt");
            string input = "0";
            while ((input = reader.ReadLine()) != null)
            {
                if (t < double.Parse(input))
                {
                    t = double.Parse(input);
                }
                
            }
            Console.WriteLine($" Max temperature: {t}");
            return t;
        }

        //MIN
        public double FindValue(int x)
        {
            double t = 10000;
            StreamReader reader = File.OpenText("input.txt");
            string input = "0";
            while ((input = reader.ReadLine()) != null)
            {
                if (t > double.Parse(input))
                    t = double.Parse(input);
            }
            
                Console.WriteLine($" Min tempetature {t}");
            return t;
        }

        //THE SAME
        public double FindValue(string x)
        {
            StreamReader reader = File.OpenText("input.txt");
            string input = "0";
            List<double> arr = new List<double>();
            while ((input = reader.ReadLine()) != null)
            {
                arr.Add(double.Parse(input));
            }

            double t = 0;
            int count = 0;
            
            for (int i = 0; i < arr.Count; i++)
            {
                double temp = arr[i];
                int c = 0;
                for (int j = 1; j < arr.Count; j++)
                {
                    if (arr[j] == temp)
                        c++;
                }

                if (c > count)
                {
                    count = c;
                    t = temp;
                }
            }

            Console.WriteLine($"The most frequent temperature is {t}. It was be {count} times");
            return t;
        }


        //THE SAME TREE TIMES
        public double FindValue(double x, double epsilon = 4.5)
        {
            StreamReader reader = File.OpenText("input.txt");
            string input = "0";
            double[] arr = new double[3];

            while ((input = reader.ReadLine()) != null)
            {
                arr[0] = arr[1];
                arr[1] = arr[2];
                arr[2] = double.Parse(input);

                if (arr.Length < 3)
                    continue;

                if (arr[0] == arr[1] && arr[1] == arr[2])
                {
                    Console.WriteLine($"Three times in a row meets {arr[2]}");
                    return arr[2];
                }
            }

            return -1000;
        }
    }
}
