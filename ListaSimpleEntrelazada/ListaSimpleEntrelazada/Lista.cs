using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleEntrelazada
{
    class Lista
    {
        public Nodo primero = null;
        Nodo raiz;

        public Lista()
        {

        }
        //AGREGAR
        public void agregar(Nodo nodo)
        {
            if (primero == null)
                primero = nodo;
            else
                agregar(primero, nodo);


            //Nodo raiz = primero;
            //if (primero == null)
            //{
            //    primero = nodo;


            //}
            //else
            //{
            //    nodo.siguiente = raiz.siguiente;
            //    raiz.siguiente = nodo;
            //}

        }

        private void agregar(Nodo ultimo, Nodo nodo)
        {
            if (ultimo.siguiente == null)
                ultimo.siguiente = nodo;
            else
                agregar(ultimo.siguiente, nodo);

        }
        //BUSQUEDA
        public Nodo buscar(int codigo)
        {
            Nodo search = primero;
            while (search != null)
            {
                if (search.Codigo == codigo)
                {
                    return search;
                }
                else
                {
                    search = search.siguiente;
                }
            }
            return null;
        }
        //ELIMINAR
        public void eliminar(int codigo)
        {
            if (primero.Codigo==codigo)
            {
                primero = primero.siguiente;
           
            }
            else
            {
                Nodo temporal = primero;

                while (temporal.siguiente != null)
                {
                    if (temporal.siguiente.Codigo == codigo)
                    {
                        temporal.siguiente = temporal.siguiente.siguiente;
                        
                        break;
                    }
                    else
                    {
                        temporal = temporal.siguiente;
                    }
                }
            }

        }
        //INSERTAR
        public void insertar(Nodo producto, int posicion)
        {
            {
                if ((primero != null) && (posicion > 0))
                {
                    Nodo temp = primero;
                    int inicio = 1;
                    while (true)
                    {
                        if (inicio <= posicion)
                        {
                            producto.siguiente = temp.siguiente;
                            temp.siguiente = producto;
                            break;
                        }
                        else
                        {
                            inicio++;
                            temp = temp.siguiente;
                        }
                    }
                }

            }
        }
   
        //LISTA
        public string lista()
        {
            string show = ToString() + Environment.NewLine;
            Nodo temporal = primero;
            while (temporal != null)
            {
                show += " " + Environment.NewLine;
                show += temporal.ToString();
                temporal = temporal.siguiente;
            }
            return show;
        }

    }
}
   