using Dominio.Repositorio;
using Infraestrutura.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Injetor
{
    public class Injetor
    {
        public void RegistrarServicos(IServiceCollection services)
        {
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
        }

    }
}
