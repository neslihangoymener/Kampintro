using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> AdYas = new Dictionary<int, string>();
            AdYas.Add(41, "Neslihan");
            AdYas.Add(43, "Murat");

            Console.WriteLine(AdYas[41]);

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            MyDictionary<int,string> AdYas2 = new MyDictionary<int, string>();

            AdYas2.Add(15, "Azra");
            AdYas2.Add(11, "Emir");

            
            Console.WriteLine(AdYas2[15] + " 15 yaşındadır");
            Console.WriteLine(AdYas2[11] +" 11 yaşındadır");

            Console.ReadLine();
        }
    }
    
}
