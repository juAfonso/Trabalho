using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class AluguelCarro
    {
        private const int Diaria = 95;
        private const double PrecoKm = 0.35;

        public int CalcularCustoDiaria(int dias)
        {
            return dias * Diaria;
        }

        public double CalcularCustoKm(int kmPercorridos)
        {
            return kmPercorridos * PrecoKm;
        }

        public double CalcularTotal(double custoDiaria, double custoKm)
        {
            return custoDiaria + custoKm;
        }
    }
}