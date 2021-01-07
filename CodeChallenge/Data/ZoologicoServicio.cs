using CodeChallenge.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge.Data
{
    public class ZoologicoServicio
    {
        public List<Animal> _animales;
        public ZoologicoServicio()
        {
            _animales = new List<Animal>();
        }
        public List<string> TiposAnimales => new List<string>() { "Carnívoro", "Herbívoro", "Reptil" };

        public void AgregarAnimal(Animal animal)
        {
            _animales.Add(animal);
        }
        public double CalcularTotalComidaMensual(DateTime fecha)
        {
            var result = _animales.Sum(a => a.CalcularAlimentoCarneMensual(fecha) + a.CalcularAlimentoHierbaMensual(fecha));
            return result;
        }
    }
}
