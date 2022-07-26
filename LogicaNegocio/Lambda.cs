using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicaNegocio
{
    public class Lambda
    {
        public int LambdaSuma(int a, int b) 
        {   
            //Expresión Lambda
            Func<int,int,int> suma =(a,b) => a + b;
            int resultado = suma(a,b);
            return resultado;
        }

        public int LambdaMayorNumeros(int a, int b) 
        {
            Func<int, int, int> mayor = (a, b) =>
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            };
            int resultado = mayor(a, b);
            return resultado;
        }

        public IEnumerable<int> ObtenerPares() 
        {
            //var colas = LogicaNegocio.Lista.Cola();
            int[] colas = LogicaNegocio.Lista.Cola().ToArray();
            Func<int, bool> SacarPares = (numero) => numero % 2 == 0;
            //Usando Linq
            var pares = colas.Where(SacarPares);
            //Otra manera de hacerlo sin una función anónima
            //var paresSinEncapsular = colas.Where((numero) => numero % 2 == 0);
            return pares;
        }
    }
}
