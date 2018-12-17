using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_paskaita_2018_12_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, int> manoZodynas = new Dictionary<string, int>()
            {
                {"vienas", 11 },
                {"du", 12 },
                {"trys", 13 }
            };

           
            Console.WriteLine(manoZodynas["vienas"]);

            Console.WriteLine(manoZodynas.Count);

            manoZodynas.Add("keturi", 14);
            Console.WriteLine(manoZodynas["keturi"]);

            manoZodynas.Remove("du");

            foreach (var item in manoZodynas)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine(manoZodynas.Contains(new KeyValuePair<string, int>("trys", 13)));

            manoZodynas.ContainsValue(12);

            manoZodynas.ContainsKey("trys");

            //manoZodynas.Clear();

            Console.WriteLine(manoZodynas.TryGetValue("trys", out int value));
            Console.WriteLine(value);

            foreach (KeyValuePair<string,int> keyValuePair in manoZodynas)
            {
                Console.WriteLine(keyValuePair);
            }
            */

            Stack<int> skaitlynas = new Stack<int>();

            skaitlynas.Push(234);
            skaitlynas.Push(43);
            

            //skaitlynas.Pop();

            skaitlynas.Peek();
            Console.WriteLine(skaitlynas.Contains(23));

            skaitlynas.ToArray();

            //skaitlynas.Clear();

            Console.WriteLine(skaitlynas.Count());

            foreach (int skaicius in skaitlynas)
            {
                Console.WriteLine(skaicius);
            }

            Console.ReadKey();


        }
    }
}
