using System;
using System.Collections.Generic;

namespace ArbolBinario
{
    public class ArbolBinario <T> 
    {
        public ArbolBinario(Comparador<T> Funcomparador) //Esta es la funcion
        {
            this.comparador = Funcomparador; // el apuntador de la linea 12 que apunte a la funcion. 
        }
        Nodo<T> root;
        Comparador<T> comparador; //una de las propiedades del arbol es el comparador

        public void Add(T dato)
        {
            if (root==null)
            {
                root = new Nodo<T>();
                root.Value = dato;
            }
            else
            {
                if (comparador.Invoke(root.Value, dato) > 0) //si es currentroot es mayor que el dato 
                {
                    if (root.Left == null) //si no hay nada guardado que guarde el nuevo. 
                    {
                        root.Left = new Nodo<T>();
                       root.Left.Value = dato;
                    }
                    else
                    {
                        Add(dato, root.Left); //recursividad, para que vaya al siguiente nivel y encuentre donde agregarlo. 
                    }
                }
                if (comparador.Invoke(root.Value, dato) < 0) //si es currentroot es menor que el dato 
                {
                    if (root.Right == null) //si no hay nada guardado que guarde el nuevo. 
                    {
                        root.Right = new Nodo<T>();
                        root.Right.Value = dato;
                    }
                    else
                    {
                        Add(dato, root.Right); //recursividad, para que vaya al siguiente nivel y encuentre donde agregarlo. 
                    }
                }
            }
        }
        public delegate int Comparador<T>(T a, T b); //El tipo del Apuntador del delegado
        private void Add(T dato, Nodo<T> CurrentRoot)
        {
            if (comparador.Invoke(CurrentRoot.Value, dato) > 0) //si es currentroot es mayor que el dato 
            {
                if (CurrentRoot.Left==null) //si no hay nada guardado que guarde el nuevo. 
                {
                    CurrentRoot.Left = new Nodo<T>();
                    CurrentRoot.Left.Value = dato;
                }
                else
                {
                    Add(dato, CurrentRoot.Left); //recursividad, para que vaya al siguiente nivel y encuentre donde agregarlo. 
                }
            }
            else if (comparador.Invoke(CurrentRoot.Value, dato) < 0) //si es currentroot es menor que el dato 
            {
                if (CurrentRoot.Right == null) //si no hay nada guardado que guarde el nuevo. 
                {
                    CurrentRoot.Right = new Nodo<T>();
                    CurrentRoot.Right.Value = dato;
                }
                else
                {
                    Add(dato, CurrentRoot.Right); //recursividad, para que vaya al siguiente nivel y encuentre donde agregarlo. 
                }
            }
            else
            {
                throw new Exception("Item repetido"); //ya que no puede haber otro con el mismo valor. 
            }
        }
        public List<T> ConvertirLista()
        {
            var list = new List<T>(); //se crea la lista nueva de resultados
            ConvertirLista(list, root); //recursividad a la funcion privada ya con los valores agregados
            return list;
        }
        private void ConvertirLista( List<T> lista, Nodo<T> CurrentRoot)
        {
            if (CurrentRoot != null) //osea que si hay algo adentro
            {
                //recorrido in order
                ConvertirLista(lista, CurrentRoot.Left);
                lista.Add(CurrentRoot.Value);
                ConvertirLista(lista, CurrentRoot.Right);
            }
        }
        public T Find(T buscador)
        {
            return Find(buscador, root);
        }
        private T Find(T buscador, Nodo<T> currentRoot)
        {
            if (currentRoot is null) return default(T);
            var comparacion = comparador.Invoke(currentRoot.Value, buscador);
            if (comparacion == 0) return currentRoot.Value;
            if (comparacion > 0) return Find(buscador, currentRoot.Left);
            return Find(buscador, currentRoot.Right);
        }
    }
}
