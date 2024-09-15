using System;

namespace GestaoPedidosTechClass
{
    public class PedidoNacional : Pedido
    {
        private const double ImpostoNacional = 0.15;

        public PedidoNacional(int idPedido, DateTime dataPedido, double valorPedido) : base(idPedido, dataPedido, valorPedido) { }

        public override double CalculaTotal()
        {
            return ValorPedido + (ValorPedido * ImpostoNacional);
        }
    }
}