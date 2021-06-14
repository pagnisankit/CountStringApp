using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountStringCharacters
{
    class CountStringCharacters
    {
        public void method()
        {
            string str = "";
            Console.Write("Provide a string");
            str = Console.ReadLine();
            Dictionary<string, int> strdic = new Dictionary<string, int>();

            for (int i = 0; i < str.Length; i++)
            {
                string key = str[i].ToString();
                char keychar = str[i];
                int val = str.Count(x=>(x==keychar));
                if (!strdic.ContainsKey(key))
                {
                    strdic.Add(key, val);
                }
            }

            foreach (var items in strdic)
            {
                Console.WriteLine(items.Key + " - " + items.Value);
            }
        }
    }
}
