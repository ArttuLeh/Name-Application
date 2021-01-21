using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System;

namespace Name_Application
{
    class Names : IComparer<Names>
    {
        public string name { get; set; }
        public int amount { get; set; }
        public List<Names> names { get; set; }
        // get Json from url
        public List<Names> GetJson()
        {
            var url = "https://raw.githubusercontent.com/solita/dev-academy-2021/main/names.json";
            var json = new WebClient().DownloadString(url);
            Names result = JsonConvert.DeserializeObject<Names>(json);
            return result.names;
        }
        // compare amount and return most popular first
        public int Compare(Names x, Names y)
        {
            int compareAmount = x.amount.CompareTo(y.amount);
            if (compareAmount == 0)
            {
                return x.amount.CompareTo(y.amount);
            }
            return -compareAmount;
        }
        // Sums amount and return total amount of the all names
        public int Sum(List<Names> lists)
        {
            int sum = lists.Sum(i => i.amount);
            return sum;
        }
    }
    // compare names, return names alphabetical order
    class SortByNames : IComparer<Names>
    {
        public int Compare(Names x, Names y)
        {
            int compareName = x.name.CompareTo(y.name);
            if (compareName == 0)
            {
                return x.name.CompareTo(y.name);
            }
            return compareName;
        }
    }
}
