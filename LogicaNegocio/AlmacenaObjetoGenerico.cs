using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoGenerico<T>
    {
        //La T indica que es un arreglo de genéricos
        private readonly T[] _datosElemento;
        private int _contador = 0;
        //Constructor
        public AlmacenaObjetoGenerico(int tamanno) 
        {
            _datosElemento = new T[tamanno];
        }
        //Métodos
        public void Agregar(T obj) 
        {
            _datosElemento[_contador] = obj;
            _contador++;
        }
        public T ObtenerElemento(int posicion) 
        {
            return _datosElemento[posicion];
        }
    }    
}
