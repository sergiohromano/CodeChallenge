using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Data.Model
{
    public class Carnivoro : Animal
    {
        public Carnivoro()
        {
            Tipo = "Carnívoro";
        }
        public Carnivoro(Animal animal)
        {
            Tipo = "Carnívoro";
            CopiarDatos(animal);
        }
        public override double CalcularAlimentoCarne()
        {
            return Peso * PorcentajeCarne;
        }
    }
}
