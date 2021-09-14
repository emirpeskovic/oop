using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using MoreEverything;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave A
            // 1.
            List<Planet> planets = new List<Planet>();

            // 2.
            planets.Add(new Planet("Mercury", 0.330, new Distance(DistanceIndicator.Kilometers, 4879), 5427, 3.7, new Time(TimePeriod.Hours, 1407.6), new Time(TimePeriod.Hours, 4222.6), new Distance(DistanceIndicator.Kilometers, 57.9), new Time(TimePeriod.Days, 88.0), 47.4, 167, 0, false));
            planets.Add(new Planet("Earth", 5.97, new Distance(DistanceIndicator.Kilometers, 12756), 5514, 9.8, new Time(TimePeriod.Hours, 23.9), new Time(TimePeriod.Hours, 24.0), new Distance(DistanceIndicator.Kilometers, 149.6), new Time(TimePeriod.Days, 365.2), 29.8, 15, 1, false));
            planets.Add(new Planet("Mars", 0.642, new Distance(DistanceIndicator.Kilometers, 6792), 3933, 3.7, new Time(TimePeriod.Hours, 24.6), new Time(TimePeriod.Hours, 24.7), new Distance(DistanceIndicator.Kilometers, 227.9), new Time(TimePeriod.Days, 687.0), 24.1, -65, 2, false));
            planets.Add(new Planet("Jupiter", 1898, new Distance(DistanceIndicator.Kilometers, 142984), 1326, 23.1, new Time(TimePeriod.Hours, 9.9), new Time(TimePeriod.Hours, 9.9), new Distance(DistanceIndicator.Kilometers, 778.6), new Time(TimePeriod.Days, 4331), 13.1, -110, 67, true));
            planets.Add(new Planet("Saturn", 568, new Distance(DistanceIndicator.Kilometers, 120536), 687, 9.0, new Time(TimePeriod.Hours, 10.7), new Time(TimePeriod.Hours, 10.7), new Distance(DistanceIndicator.Kilometers, 1433.5), new Time(TimePeriod.Days, 10747), 9.7, -140, 62, true));
            planets.Add(new Planet("Uranus", 86.8, new Distance(DistanceIndicator.Kilometers, 51118), 1271, 8.7, new Time(TimePeriod.Hours, -17.2), new Time(TimePeriod.Hours, 17.2), new Distance(DistanceIndicator.Kilometers, 2872.5), new Time(TimePeriod.Days, 30589), 6.8, -195, 27, true));
            planets.Add(new Planet("Neptune", 102, new Distance(DistanceIndicator.Kilometers, 49528), 1638, 11.0, new Time(TimePeriod.Hours, 16.1), new Time(TimePeriod.Hours, 16.1), new Distance(DistanceIndicator.Kilometers, 4495.1), new Time(TimePeriod.Days, 59.8), 5.4, -200, 14, true));
            planets.Add(new Planet("Pluto", 0.0146, new Distance(DistanceIndicator.Kilometers, 2370), 2095, 0.7, new Time(TimePeriod.Hours, -153.3), new Time(TimePeriod.Hours, 153.3), new Distance(DistanceIndicator.Kilometers, 5906.4), new Time(TimePeriod.Days, 90.56), 4.7, 225, 5, false));

            // 3.
            foreach (var planet in planets)
                Console.WriteLine(planet.PlanetName);

            // 4.
            planets.Insert(1, new Planet("Venus", 4.87, new Distance(DistanceIndicator.Kilometers, 12104), 5243, 8.9, new Time(TimePeriod.Hours, -5832.5), new Time(TimePeriod.Hours, 2802.0), new Distance(DistanceIndicator.Kilometers, 108.2), new Time(TimePeriod.Days, 224.7), 35.0, 464, 0, false));

            // 5.
            foreach (var planet in planets)
                Console.WriteLine(planet.PlanetName);

            // 6.
            var pluto = planets.Find(p => p.PlanetName == "Pluto"); // temporary
            planets.Remove(pluto);

            // 7.
            foreach (var planet in planets)
                Console.WriteLine(planet.PlanetName);

            // 8.
            planets.Add(pluto);

            // 9.
            Console.WriteLine(planets.Count);

            // 10.
            var planetsBelowZero = planets.Where(p => p.MeanTemperature < 0).ToList();

            // 11.
            var planetsOver10kKm = planets.Where(p => p.Diameter > new Distance(DistanceIndicator.Kilometers, 10000) && p.Diameter < new Distance(DistanceIndicator.Kilometers, 50000)).ToList();

            // 12.
            planets.Clear();
        }
    }
}
