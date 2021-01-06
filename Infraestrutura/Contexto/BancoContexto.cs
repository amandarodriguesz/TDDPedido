using Dominio.modelo;
using Infraestrutura.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura
{
    public class BancoContexto : DbContext
    {
        public BancoContexto()
        {
        }

        public BancoContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pedido> Pedido {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoMapping());

        }
    }
}
