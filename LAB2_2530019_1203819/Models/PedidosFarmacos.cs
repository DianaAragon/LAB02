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
        public string NombreDelCliente { get; set; }
        [Required]
        public string Dirrecion { get; set; }
        [Required]
        public int Nit { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public string Nombre { get; set; }

    }
}