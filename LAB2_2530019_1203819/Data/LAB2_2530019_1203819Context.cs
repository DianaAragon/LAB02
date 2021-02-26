using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LAB2_2530019_1203819.Models;

namespace LAB2_2530019_1203819.Data
{
    public class LAB2_2530019_1203819Context : DbContext
    {
        public LAB2_2530019_1203819Context (DbContextOptions<LAB2_2530019_1203819Context> options)
            : base(options)
        {
        }

        public DbSet<LAB2_2530019_1203819.Models.Farmaco> Farmaco { get; set; }

        public DbSet<LAB2_2530019_1203819.Models.PedidosFarmacos> PedidosFarmacos { get; set; }
    }
}
