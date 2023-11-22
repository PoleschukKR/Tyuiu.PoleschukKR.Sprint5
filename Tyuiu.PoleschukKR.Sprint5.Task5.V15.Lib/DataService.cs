using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PoleschukKR.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            
            StreamReader reader = new StreamReader(path);
            
            double res = 99999999;
            string line;
            double x;
            while ((line = reader.ReadLine()) != null)
            {
                
                x = Convert.ToDouble(line);
                if (x % 5 == 0 && x < res)
                {
                    res = x;
                    
                }
           
            }
            return res;
           
           
        }
    }
}
