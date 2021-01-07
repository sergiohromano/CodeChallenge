using System;
using System.Collections.Generic;
using System.Reflection;

namespace CodeChallenge.Data.Model
{
    public class Animal : IAnimal
    {
        public Animal()
        {
            FechaDeIngreso = DateTime.Now.Date;
        }
        public DateTime FechaDeIngreso { get; set; }
        public string Tipo { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public string LugarOrigen { get; set; }
        public double Peso { get; set; }
        public double PorcentajeCarne { get; set; }
        public double PorcentajeHierba { get; set; }
        public double Kilos { get; set; }
        public int CambioDePiel { get; set; }

        public virtual double CalcularAlimentoCarne()
        {
            return 0D;
        }
        public virtual double CalcularAlimentoHierba()
        {
            return 0D;
        }
        public virtual double CalcularAlimento()
        {
            return CalcularAlimentoCarne() + CalcularAlimentoHierba();
        }
        public virtual double CalcularAlimentoCarneMensual(DateTime fecha)
        {
            return CalcularAlimentoMensual(fecha, CalcularAlimentoCarne());
        }
        public virtual double CalcularAlimentoHierbaMensual(DateTime fecha)
        {
            return CalcularAlimentoMensual(fecha, CalcularAlimentoHierba());
        }
        public virtual double CalcularAlimentoMensual(DateTime fecha, double alimento)
        {
            var maximoDia = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            return alimento * maximoDia;
        }
        public void CopiarDatos(Animal animal)
        {
            FechaDeIngreso = animal.FechaDeIngreso;
            Especie = animal.Especie;
            Edad = animal.Edad;
            LugarOrigen = animal.LugarOrigen;
            Peso = animal.Peso;
            PorcentajeCarne = animal.PorcentajeCarne;
            PorcentajeHierba = animal.PorcentajeHierba;
            Kilos = animal.Kilos;
            CambioDePiel = animal.CambioDePiel;
        }
    }
}