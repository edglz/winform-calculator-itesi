using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {
        public double n1, n2, n3, con = 0;
        public int x = 1;
        int c;
        public void addConx()
        {
            con++;
        }
        public double suma()
        {
            this.addConx();
            return this.n1 + this.n2;
        }
        public double resta()
        {
            this.addConx();
            return n1 - n2;
        }
        public double multiplica()
        {
            this.addConx();
            return this.n1 * this.n2;
        }
        public double division()
        {
            this.addConx();
            return this.n1 / this.n2;
        }
        public double potencia()
        {
            this.addConx();
            return Math.Pow(this.n1, this.n2);
        }
        public double raiz()
        {
            this.addConx();
            return Math.Pow(this.n1, 1 / this.n2);
        }
        public int factorial()
        {

            this.addConx();
            for (c = 1; c <= n1; c++)
            {

                x = x * c;
            }
            return x;

        }
    }
}
