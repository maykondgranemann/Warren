using Dojo2508.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo2508.View
{
    internal class AnimalView
    {
        public static void Executa()
        {
            Animal animal = new Animal();
            animal.Id = 0;
            animal.Especie = "Jaguar";
            animal.Name = "Jonathan";
            animal.Peso = 100.3;

            Console.WriteLine(animal);
        }
    }
}
