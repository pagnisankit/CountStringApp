using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountStringCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CountStringCharacters str = new CountStringCharacters();
                str.method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }
    }
}
