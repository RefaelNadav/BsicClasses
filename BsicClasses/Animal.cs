using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicClasses
{
    internal class Animal 
    {
        protected string Species;
        //constructor that get species
        public Animal(string species) => Species = species;
        public string GetSpecies()
        {
            return Species;
        }
    }
    internal class Dog: Animal
    {
        public Dog(string species) : base(species)
        {
        }
        public string species()
        {
            return GetSpecies();
        }
    }
}
