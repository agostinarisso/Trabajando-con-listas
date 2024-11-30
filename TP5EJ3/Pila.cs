using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5EJ3
{
    class Pila
    {
        Nodo _tope;
        public Nodo Tope()
        {
            return _tope;
        }
        public void Apilar(Nodo unNodo)
        {
            if(_tope == null)
            {
                _tope = unNodo;
            }
            else
            {
                //dejar el nodo anterior abajo para poder poner el nuevo en el tope
                Nodo aux = _tope;
                _tope = unNodo;
                _tope.Siguiente = aux;
            }
        }

        public void Desapilar()
        {
            if (_tope != null)
            {
                _tope = _tope.Siguiente;
            }
        }



    }
}
