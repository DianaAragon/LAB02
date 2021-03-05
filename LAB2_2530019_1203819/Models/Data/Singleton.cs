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
        public ArbolBinario<LlaveArbol> Arbol_Farmacos;
        public DoubleLinkedList<Farmaco> List2;//mi lista aqui 
        public DoubleLinkedList<PedidosFarmacos> Pedidos;
        public String nombre;
        public int Nit = 0;
        public String Nombrecliente = "";
        public string dirrecion = "";
        public int id;

        public Random random;

        private Singleton()
        {
            random = new Random();
            Pedidos = new DoubleLinkedList<PedidosFarmacos>();
            Arbol_Farmacos = new ArbolBinario<LlaveArbol>(LlaveArbol.Compare_Llave_Arbol); //Se inicializa el arbol binario por nombre de farmaco
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


