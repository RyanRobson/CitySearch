using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace CitySearch
{
    class LoadData
    {
        public static Collection<string> InitData()
        {
            /**
            * Loads testing data from a CSV file stored as a resource.
            * Strips unneeded data from file and maps it to a Collection. 
            * <returns> Returns a Collection containing City Names</returns>
            */
            Collection<string> CityNames = new Collection<string>();

            StreamReader cityStream = new StreamReader("cities.csv");
            string curCity;
            int i = 0;
            while (!cityStream.EndOfStream)
            {
                curCity = cityStream.ReadLine();
                int index = curCity.IndexOf(",");
                if (index > 0)
                {
                    curCity = curCity.Substring(0, index);
                }
                curCity = curCity.Remove(0, 1);
                CityNames.Add(curCity);
                i++;
            }
            return (CityNames);
        }
    }
}