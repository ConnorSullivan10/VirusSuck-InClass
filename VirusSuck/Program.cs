using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            //add items to the list one at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Insert(0, "Shebola");
            names.Add("Stupidity");

            //remove items from the list
            names.Remove("Stupidity");
            names.RemoveAt(3);


            //add multiple items via collection initializer
            var people = new List<string> { "Nathan","Martin", "Randy's Kid"};
            names.AddRange(people);

            //remove multiple items
            names.RemoveRange(names.Count - 3, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //---------------------------------------------------------------------------------------------------
            //Dictionaries
            //---------------------------------------------------------------------------------------------------

            var symptoms = new Dictionary<string, string>();

            // adds single items
            symptoms.Add("COVID-19", "Dry cough, fever, respiratory problems");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            //get single thing
            var covidSymptoms = ["COVID-19"];

            //remove single item
            symptoms.Remove("Ebola");

            //collection initializer
            var otherDictionary = new Dictionary<string, int> { {"nathan", 33 }, { "martin", 35 } };

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown...");
                }
            }

            //---------------------------------------------------------------------------------------------------
            //Queues
            //---------------------------------------------------------------------------------------------------

            var diseasesToCure = new Queue<string>();

            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            //SARS
            var thingToCure = diseasesToCure.Dequeue();
            //COVID-19
            var nextThingToCure = diseasesToCure.Dequeue();

            //---------------------------------------------------------------------------------------------------
            //Hashset
            //---------------------------------------------------------------------------------------------------

            //good for heavy read operations

            var vectors = new HashSet<string>();

            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");

            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Cancels everything except work");
            covid19.NumberOfDeathsWorldwide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumberOfDeathsWorldwide = 50000000;

            var rabies = new Virus("rabies", 11);
            rabies.Symptoms.Add("Fever");
            rabies.Symptoms.Add("Excess salivation");
            rabies.NumberOfDeathsWorldwide = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies};

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} ");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms) }");
            }
        }
    }
}
