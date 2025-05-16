using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula01._1bim
{
    public class AdivinharNumero
    {
        private int numeroSorteado;

        public AdivinharNumero()
        {
            Random random = new Random();
            numeroSorteado = random.Next(0, 100);
        }


        public string VerificarTentativa(int tentativa)
        {
            if (tentativa < numeroSorteado)
                return "O número é maior.";

            if (tentativa > numeroSorteado)
                return "O número é menor.";

            return "Acertou!";
        }

        public bool Acertou(int tentativa)
        {
            return tentativa == numeroSorteado;
        }
    }
}



