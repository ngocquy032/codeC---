using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi2
{
     class Lion:Animal
    {

        public Lion(int weight, string name) {
            this.name= name;
            this.weight = weight;
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }
    }
}
