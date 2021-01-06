using Dominio.Aplicacao;
using Dominio.DTO;
using Dominio.modelo;
using Dominio.Repositorio;
using Moq;
using Newtonsoft.Json;
using Servico.PedidoServico;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace TesteUnitario.Teste
{
    public class PedidoTeste
    {
        private readonly IPedidoService _service;
        private readonly Mock<IPedidoRepositorio> _mock = new Mock<IPedidoRepositorio>();

        public PedidoTeste()
        {
            _service = new PedidoServico(_mock.Object);
        }

        public List<PedidoDTO> ObterPedidosMock()
        {
            var json = File.ReadAllText(@"C:\Users\Amanda Rodrigues\source\repos\UCDBProduto\TesteUnitario\Mock\Pedido.json", Encoding.GetEncoding("iso-8859-1"));
            var lista = JsonConvert.DeserializeObject<List<PedidoDTO>>(json);
            return lista;
        }

        [Fact(Skip = "TestePedido")]
        public void ObterPedidosVencidos()
        {
            //arrange
            var pedidos = ObterPedidosMock().Where(x=>x.DataVencimento < DateTime.Now);
            //action
            var pedidoService = _service.ObterPedidosVencidos();
            //assert
            Assert.Equal(pedidos, pedidoService);

        }
    }
}
