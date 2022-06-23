
using ZooProject.Animals;
using System;
using System.Collections.Generic;
using System.Linq;


class Zoo { 
static void Main(string[] args)
{

        // список животных
    Predators lion = new Predators(1,"Alex", 120, 190, 8);
    Predators tiger = new Predators(2,"Zoobie", 110, 180, 7);
    Predators panther = new Predators(3,"Pink", 100, 170, 7);
    Predators hyena = new Predators(4, "Borat", 90, 160, 5);

    Omnivorous bear = new Omnivorous(5,"Vinny", 180, 400, 15);
    Omnivorous rat = new Omnivorous(6, "Ratatouille", 10, 1, 1);
    Omnivorous raccon = new Omnivorous(7, "Spaceman", 40, 10, 2);

    Herbivorous zebra = new Herbivorous(8, "Martin", 130, 120, 6);
    Herbivorous deer = new Herbivorous(9, "Ben", 180, 250, 8);
    Herbivorous giraffe = new Herbivorous(10, "Melman", 500, 300, 9);


       

        List<Animals> notSorted = new List<Animals>() { lion, tiger, panther, hyena, bear, rat, raccon, zebra, deer, giraffe };

        List<Animals> sorted = notSorted.OrderByDescending(x => x.requiredAmountFeed)
                                    .ThenBy(x => x.name)
                                    .ToList();



        lion.feedCalculation();
        zebra.feedCalculation();
        bear.feedCalculation();

        Console.WriteLine("\n"+"Task A");
        for (int i = 0; i < sorted.Count;i++)
        {
            Console.WriteLine(String.Join(Environment.NewLine,
                "ID: " + sorted[i].identifier,
                "Name: " + sorted[i].name,
                "Required amount of feed: " + sorted[i].requiredAmountFeed +
                // "Type: " + Animals
               "\n" ));

        }


       




        Console.WriteLine("\n" + "Task B" + "\n");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(sorted[i].name);
        }



        Console.WriteLine("\n" + "Task C" + "\x0A");
        for (int i = 9; i > 6; i--) { 
        Console.WriteLine(sorted[i].identifier);
            }

    }
}
