using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals
{
    internal class Predators : Animals
    {

        const string requiredTypeOfFood = "meat";

        public Predators(int identifier, string name, int height, int weight, int requiredAmountFeed) : base(identifier, name, height, weight, requiredAmountFeed)
        {
        }

        public override void feedCalculation()
        {
            Console.WriteLine("Predator with ID " + identifier + " needs " + requiredAmountFeed + " " + requiredTypeOfFood + " feed");

        }
    }
}
