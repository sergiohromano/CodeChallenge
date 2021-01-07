using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Data.Model
{
    public class Herbivoro : Animal
    {
        public Herbivoro()
        {
            Tipo = "Hervíboro";
        }
        public Herbivoro(Animal animal)
        {
            Tipo = "Hervíboro";
            CopiarDatos(animal);
        }
        public override double CalcularAlimentoHierba()
        {
            return (2 * Peso) + Kilos;
        }
    }
}
