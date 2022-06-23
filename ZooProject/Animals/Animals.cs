using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals
{
    internal abstract class Animals
    {
        // свойства животного
       public int identifier;
        public string name;
       public int height;
       public int weight;
       public int requiredAmountFeed;


        //конструктор животного
        public Animals(int identifier, string name, int height, int weight, int requiredAmountFeed)
        {
            this.identifier=identifier;
            this.name = name;
            this.height=height;
            this.weight=weight;
            this.requiredAmountFeed=requiredAmountFeed;
        }

        public abstract void feedCalculation();
    }
}
