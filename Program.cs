using System;
using System.Collections.Generic;

namespace planets
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> planetList = new List<string>(){
            "Mercury",
            "Mars"
        };

        planetList.Add("Jupiter");
        planetList.Add("Saturn");

        List<string> outterPlanets = new List<string>(){
            "Uranus",
            "Neptune"
        };

        planetList.AddRange(outterPlanets);

        planetList.Insert(1, "Venus");
        planetList.Insert(2, "Earth");

        planetList.Add("Pluto");


        // string[] output = planetList.GetRange(0, 4).ToArray();
        // foreach (string rockyPlanet in output){
        // Console.WriteLine(output);
        // }
        // planetList.Remove("Pluto");

        foreach (string planet in planetList)
        Console.WriteLine(planet);

        Probes viking = new Probes("Viking", "Mars");
        Probes opportunity = new Probes("Opportunity", "Mars");
        Probes curiosity = new Probes("Curiosity", "Mars");
        Probes mariner = new Probes("Mariner", "Venus");
        Probes venera = new Probes("Venera", "Venus");

List<Probes> probeDestinations = new List<Probes>(){
viking,
curiosity,
mariner,
venera,
opportunity

};



foreach(Probes probe in probeDestinations)
Console.WriteLine($"{probe.probeName} : {probe.planetName}" );

                }
            }}




