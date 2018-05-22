using System;
using System.Collections.Generic;

namespace _09_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
            countriesCapitals.Add("Israel", "Jerusalem");
            countriesCapitals.Add("Germany", "Berlin");
            countriesCapitals.Add("UK", "London");
            countriesCapitals.Add("France", "Paris");

            foreach (KeyValuePair<string,string> item in countriesCapitals)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.WriteLine($"Israel capital is: {countriesCapitals["Israel"]}");
            

            Dictionary<string,int> countriesPopulation = new Dictionary<string, int>();
            countriesPopulation.Add("Israel", 8527400);
            countriesPopulation.Add("Germany", 4527400);
            countriesPopulation.Add("UK", 28527400);
            countriesPopulation.Add("France", 1527400);


            foreach (KeyValuePair<string, int> item in countriesPopulation)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine($"Israel Population is: {countriesPopulation["Israel"]}");

            Dictionary<KeyValuePair<string, string>, int> countriesCapitalPopulation = new Dictionary<KeyValuePair<string, string>, int>();
            countriesCapitalPopulation.Add(new KeyValuePair<string, string>("Israel", "Jerusalem"), 3327400);
            countriesCapitalPopulation.Add(new KeyValuePair<string, string>("Germany", "Berlin"), 72400);
            countriesCapitalPopulation.Add(new KeyValuePair<string, string>("UK", "London"), 77400);
            countriesCapitalPopulation.Add(new KeyValuePair<string, string>("France", "Paris"), 127400);

            foreach (KeyValuePair<KeyValuePair<string, string>, int> item in countriesCapitalPopulation)
            {
                Console.WriteLine($"Country {item.Key.Key}, Capital: {item.Key.Value}, Population {item.Value}");
            }


            KeyValuePair<string, string> index = new KeyValuePair<string, string>("Israel", "Jerusalem");
            Console.WriteLine($"Israel Population is: {countriesCapitalPopulation[index]}");

        }
    }
}



/*
 
OUTPUT:
____________________

Israel Jerusalem
Germany Berlin
UK London
France Paris
Israel capital is: Jerusalem
Israel 8527400
Germany 4527400
UK 28527400
France 1527400
Israel Population is: 8527400
Country Israel, Capital: Jerusalem, Population 3327400
Country Germany, Capital: Berlin, Population 72400
Country UK, Capital: London, Population 77400
Country France, Capital: Paris, Population 127400
Israel Population is: 3327400
*/
