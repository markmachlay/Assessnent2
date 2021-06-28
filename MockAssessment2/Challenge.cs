using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MockAssessment2
{
    public class Challenge
    {
        public int Result { get; set; }
        public string Max { get; set; }
        public double DroidAverage { get; set; }
        public List<string> ListOfPlanets { get; set; }
        public Challenge()
        {
        }
        public int AddStarWarsCharacters(string[] starWarsCharacters)
        {
            Result = 0;
            for (int i = 0; i < starWarsCharacters.Length; i++)
            {
                if(starWarsCharacters[i] == "Yoda")
                {
                    Result = i;
                }
            }
            return Result;
        }

        public string DeathStarCombat(Dictionary<string,int> starWarsPowerLevels)
        {
           Max = starWarsPowerLevels.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
           return Max;
        }

        public List<string> ConvertPlanets(string[] Planets)
        {
            ListOfPlanets = Planets.Reverse().ToList();
            return ListOfPlanets;
        }

        public double AverageDroids(List<int> Droids)
        {
            var doubleDroids = Droids.Select(i => (double)i).ToList();
            var evenDroids = new List<int>();
            foreach (var droid in Droids)
            {
                if (droid % 2 == 0)
                {
                    evenDroids.Add(droid);
                }
            }
            double total = evenDroids.Sum();
            DroidAverage = total / evenDroids.Count;
            return DroidAverage;
        }

        public string TryToCatchDarthVader(string Name)
        {
            try
            {
                int result = int.Parse(Name);
                Console.WriteLine("Vader Was Captured!");
            }
            catch (Exception)
            {
                Console.WriteLine("Vader Got Away!");
            }
            return null;
        }
    }
}
