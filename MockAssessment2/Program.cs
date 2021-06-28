using System;
using System.Collections.Generic;

namespace MockAssessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var starWarsArray = new string[] { "Yoda", "Leia", "Luke", "Rey" };
            var challenge = new Challenge();
            var result = challenge.AddStarWarsCharacters(starWarsArray);
            Console.WriteLine(result);

            var starWarsPowerLevels = new Dictionary<string, int>();
            starWarsPowerLevels.Add("Luke Skywalker", 910);
            starWarsPowerLevels.Add("Darth Vader", 225);
            starWarsPowerLevels.Add("Obi-wan Kenobi", 120);
            starWarsPowerLevels.Add("Yoda", 100);
            var challenge2 = new Challenge();
            var max = challenge2.DeathStarCombat(starWarsPowerLevels);
            Console.WriteLine(max);

            var planets = new string[] { "Dagobah", "Yavin-4", "Tatooine", "Datooine" };
            var challenge3 = new Challenge();
            var reversePlanets = challenge3.ConvertPlanets(planets);
            foreach (var planet in reversePlanets)
            {
                Console.WriteLine(planet);
            }

            List<int> listOfDroids = new List<int>();
            listOfDroids.Add(1000);
            listOfDroids.Add(2000);
            listOfDroids.Add(4000);
            listOfDroids.Add(3000);
            var challenge4 = new Challenge();
            var evenDroids = challenge4.AverageDroids(listOfDroids);
            Console.WriteLine(evenDroids);


            var challenge5 = new Challenge();
            var isDarthVader = challenge5.TryToCatchDarthVader("Nope");
            var isDarthVaderAgain = challenge5.TryToCatchDarthVader(null);
        }
    }
}
