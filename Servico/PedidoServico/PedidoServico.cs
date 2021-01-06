using Dominio.Aplicacao;
using Dominio.DTO;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.PedidoServico
{
    public class PedidoServico : IPedidoService
    {
        private readonly IPedidoRepositorio _repo;

        public PedidoServico(IPedidoRepositorio repo)
        {
            _repo = repo;
        }
        public List<PedidoDTO> ObterPedidosQuaseVencidos()
        {
            throw new NotImplementedException();
        }

        public List<PedidoDTO> ObterPedidosValidos()
        {
            throw new NotImplementedException();
        }

        public List<PedidoDTO> ObterPedidosVencidos()
        {
            throw new NotImplementedException();
        }

        public List<PedidoDTO> ValorComDesconto(PedidoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
