using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TemperatureApp
{
    class TemperatureAnalizator
    {
        List<double> temperatures;
        double eps;

        public double Accuracy
        {
            get
            {
                return eps;
            }
            set
            {
                eps = value;
            }
        }
        public TemperatureAnalizator(double accuracy=0)
        {
            this.Accuracy = accuracy;
            temperatures = new List<double>();
        }
        public bool readTemperatureFromFile(string path)
        {
            StreamReader reader = File.OpenText("temperatures.txt");
            

            for (int i=0; reader.ReadLine() != null; i++)
            {
                temperatures[i] = reader.ReadLine();
            }
            reader.Close();

            return
        }
        //public double findMaxTemperature();
        //public double findMinTemperature();
        //public double findPopularTemperature();
        //public bool FindValue(int val);
        //public bool FindValue(double val);
        //public bool FindValue(string val);
        //public bool FindValue(double val, double eps);
    }
}
