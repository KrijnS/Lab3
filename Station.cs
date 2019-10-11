using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Station
    {
        Dictionary<string, KeyValuePair<string, int>[]> prices;
        string name;
        string[] allLines = File.ReadAllLines("Stations.txt", Encoding.UTF8);

        public Station(Dictionary<string, KeyValuePair<string, int>[]> prices, string name)
        {
            this.prices = prices;
            this.name = name;
        }

        public String[] readStations()
        {
            String[] stations = allLines[0].Split(',');
            return stations;
        }

        public int getTariefEenheden(string from, string to)
        {
            String[] stations = readStations();
            int indexFrom = -1;
            int indexTo = -1;
            if(stations.Length > 0)
            {
                for(int i = 0; i < stations.Length; i++)
                {
                    if(stations[i] == from)
                    {
                        
                        indexFrom = i;
                        Console.WriteLine(indexFrom + " " + i);
                        if (indexTo != -1)
                        {
                            break;
                        }
                    }
                    if(stations[i] == to)
                    {
                        indexTo = i;
                        Console.WriteLine(indexTo + " " + i);
                        if (indexFrom != -1)
                        {
                            break;
                        }
                    }
                }
                if(indexFrom == -1 || indexTo == -1)
                {
                    throw new Exception("Unknown stations");
                }
                if(indexTo < indexFrom)
                {
                    int temp = indexTo;
                    indexTo = indexFrom;
                    indexFrom = temp;
                }
                indexTo++;
                Console.WriteLine(allLines[indexTo]);
                string[] prices = allLines[indexTo].Split(',');
                Console.WriteLine(prices[indexFrom]);
                int price = Int32.Parse(prices[indexFrom]);
                return price;
            }
            else
            {
                throw new Exception("No stations");
            }
        }
    }
}
