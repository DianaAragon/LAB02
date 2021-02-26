using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LAB2_2530019_1203819.Models
{
    public class PedidosFarmacos
    {
        public int Id { get; set; }
        [Required]
        public string Nombre_Cliente { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Nit { get; set; }
        [Required]
        public string Listado_Farmacos { get; set; }
        [Required]
        public double Total_Cancelar  { get; set; }






       
    }
}
