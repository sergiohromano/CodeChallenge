using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Data.Model
{
    public interface IAnimal
    {
        double CalcularAlimento();
        double CalcularAlimentoCarne();
        double CalcularAlimentoHierba();
        double CalcularAlimentoCarneMensual(DateTime fecha);
        double CalcularAlimentoHierbaMensual(DateTime fecha);
        double CalcularAlimentoMensual(DateTime fecha, double alimento);
    }
}
