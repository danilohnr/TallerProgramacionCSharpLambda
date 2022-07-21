using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{   
    public class Cajero
    {
        /// <summary>
        /// Dinero actual del cliente, variable global privada
        /// </summary>
        /// //Campos
        private decimal _dineroActual = 10000;
        private int _contador = 0;      //Contador de intentos
        private const int MAXIMO = 5; //Máximo de intentos
        
        //Métodos constructores
        public Cajero()
        {
        }
        public Cajero(decimal dineroActual, int contador = 0)
        {
            //_dineroActual = dineroActual;
            DineroActual = dineroActual;
            _contador = contador;
        }
        
        //Propiedades
        public decimal DineroActual
        {
            get { return _dineroActual; }
            set { _dineroActual = value; }
        }

        //Métodos
        public decimal RetirarDinero(decimal montoRetiro, ref string mensaje) 
        {
            try
            {
                if (montoRetiro > DineroActual)
                {
                    mensaje = "El monto de retiro: " + montoRetiro + " es mayor que al disponible :( " + DineroActual;
                }
                else
                {
                    //Acumulador
                    DineroActual -= montoRetiro;
                    //Contador
                    _contador++;
                    mensaje = "Cuide su dinero. Tiene disponible: C$" + DineroActual;
                }
                return DineroActual;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
