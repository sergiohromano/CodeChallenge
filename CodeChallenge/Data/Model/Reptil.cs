using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Data.Model
{
    public class Reptil : Animal
    {
        public Reptil()
        {
            Tipo = "Reptil";
        }
        public Reptil(Animal animal)
        {
            Tipo = "Reptil";
            CopiarDatos(animal);
        }
        public override double CalcularAlimentoCarne()
        {
            return Peso * PorcentajeCarne;
        }
        public override double CalcularAlimentoHierba()
        {
            return Peso * PorcentajeHierba;
        }
        public override double CalcularAlimentoMensual(DateTime fecha, double alimento)
        {
            var tiempoDeEspera = 3;
            var alimentoPorDia = alimento / 7;
            var maximoDia = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            var periodos = maximoDia / (CambioDePiel + tiempoDeEspera);
            var resto = maximoDia % (CambioDePiel + tiempoDeEspera);
            var sum = periodos * CambioDePiel * alimentoPorDia + (resto >= CambioDePiel ?
                CambioDePiel * alimentoPorDia : resto * alimentoPorDia);
            return sum;
        }
    }
}
