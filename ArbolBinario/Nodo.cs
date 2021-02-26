using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class Nodo<T>
    {
        public T Value;

        public Nodo<T> Left;
        public Nodo<T> Right;
        public Nodo()
        {
            this.Left = null;
            this.Right = null;
        }
    }
}
