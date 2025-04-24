using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class listas_ejemplos
    {
        public void start()
        {
            circulo t1 = new circulo(39);
            circulo t2 = new circulo(48);

            List<circulo> list = new List<circulo>();
            list.Add(t1);
            list.Add(t2);
            foreach (circulo t in list)
            {
                Console.WriteLine(t.area());
            }
        }
    }
}
