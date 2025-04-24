using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class circulo
    {
        public float r;
        public circulo(float r)
        {
            this.r = r;
        }
        public float area() => 3.14f * r * r;
    }
}
