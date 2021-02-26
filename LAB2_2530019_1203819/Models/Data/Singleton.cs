using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArbolBinario;
using DoubleLinkedListLibrary1;


namespace LAB2_2530019_1203819.Models.Data
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public ArbolBinario<Farmaco> Arbol_Farmacos;
        public DoubleLinkedList<Farmaco> List2;//mi lista aqui 
        private Singleton()
        {
            Arbol_Farmacos = new ArbolBinario<Farmaco>(Farmaco.Compare_Nombre_Farmaco); //Se inicializa el arbol binario por nombre de farmaco
            List2 = new DoubleLinkedList<Farmaco>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
