using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Memoria
    {
        private Double Valor = 0.00;
        public Double get()
        {
            return this.Valor;
        }
        public void set(Double valor)
        {
            this.Valor = valor;
        }
    }
}
