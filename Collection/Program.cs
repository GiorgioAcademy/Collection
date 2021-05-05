using System;
using System.Collections;
using System.Collections.Generic;

// boxing - assegnare un tipo valore a object
// unboxing - conversione di un object in un tipo valore

namespace Collection
{
    class Program
    {
        static void AltroAncora()
        {
            HashSet<int> primi = new HashSet<int>() { 2, 3, 5, 7, 11, 13 };

            //            primi.Add(2)

            if (primi.Contains(5))
            {

            }

            primi.Add(17);
            primi.Add(13);
        }

        static void Altro()
        {
            var rubrica = new Dictionary<string, string>();
            // var n = 10.0m;

            rubrica.Add("Piero", "345 121-4547");
            rubrica["Gina"] = "311 456 4567";
            rubrica["Anna"] = "325 4546548";

            rubrica["Anna"] = "325 1111111";
            // rubrica.Add("Piero", "345 4444444");

            // if (rubrica.ContainsKey("Gina"))

            // rubrica.Remove("Anna");

            foreach (string nome in rubrica.Keys)
                Console.WriteLine(nome);

            foreach (string telefono in rubrica.Values)
                Console.WriteLine(telefono);

            foreach (var c in rubrica)
                Console.WriteLine($"Il numero di {c.Key} è {c.Value}");

            // Console.WriteLine($"Il numero di Anna è {rubrica["Anna"]}");
        }

        static void Main(string[] args)
        {
            Altro();

            double[] array = new double[100];

            // ArrayList l = new ArrayList();  // contiene objects
            List<int> l = new List<int>();  // contiene elementi del tipo specificato
            List<string> ls = new List<string>();

            l.Add(456); 
            l.Add(1000);
            l.Add(12);
            // l.Add("Pinco Pallino");

            l.Insert(1, 777);

            int x = l[2];  

            foreach (int n in l)
                Console.WriteLine(n);

            l.RemoveAt(1);

            for (int i = 0; i < l.Count; i++)
                Console.WriteLine(l[i]);

            l.Remove(456);
        }
    }
}
