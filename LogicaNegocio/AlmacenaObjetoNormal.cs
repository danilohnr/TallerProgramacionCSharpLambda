using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoNormal
    {
        //readonly significa que esta variable solo
        //se puede inicializar en el constructor
        private readonly Object[] _datosElemento;
        private int _contador = 0;
        //Constructor
        public AlmacenaObjetoNormal(int tamanno)
        {
            //Inicializar el arreglo
            _datosElemento = new Object[tamanno];
        }
    }    
}
