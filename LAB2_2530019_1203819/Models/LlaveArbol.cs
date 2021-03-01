using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB2_2530019_1203819.Models
{
    public class LlaveArbol
    {
        public int Fila { get; set; }
        public string Nombre_Farmaco { get; set; }
        public static int Compare_Llave_Arbol(LlaveArbol x, LlaveArbol y) //Funcion del delegado
        {
            int r = x.Nombre_Farmaco.CompareTo(y.Nombre_Farmaco);
            return r;
        }
    }
}
