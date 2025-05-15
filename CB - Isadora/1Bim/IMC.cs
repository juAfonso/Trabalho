using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculadoraIMC
    {
        public double Calcular(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public string Classificar(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc < 24.9)
                return "Peso normal";
            else if (imc < 29.9)
                return "Sobrepeso";
            else if (imc < 34.9)
                return "Obesidade grau I";
            else if (imc < 39.9)
                return "Obesidade grau II";
            else
                return "Obesidade grau III";
        }
    }
}
