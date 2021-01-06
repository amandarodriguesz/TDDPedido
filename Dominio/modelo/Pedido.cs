using System;

namespace Dominio.modelo
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

    }
}
