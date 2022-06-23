using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals
{
    internal class Herbivorous : Animals
    {
        const string requiredTypeOfFood = "herb";

        public Herbivorous(int identifier, string name, int height, int weight, int requiredAmountFeed) : base(identifier, name, height, weight, requiredAmountFeed)
        {
        }

        public override void feedCalculation()
        {
            Console.WriteLine("Herbivorous with ID " + identifier + " needs " + requiredAmountFeed + " " + requiredTypeOfFood + " feed");

        }
    }
}
