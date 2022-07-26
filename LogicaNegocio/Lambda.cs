using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
