using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaAumento
    {
        public int CalcularAumento(int salario, int percentual)
        {
            return (salario * percentual) / 100; 
        }
        public int NovoSalario(int salario, int aumento)
        {
            return salario + aumento;
        }
    }
}
    



    
    
      