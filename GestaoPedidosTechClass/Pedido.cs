using System;

namespace GestaoPedidosTechClass
{
    public class Pedido
    {
        public int IdPedido { get; private set; }
        public DateTime DataPedido { get; private set; }
        protected double ValorPedido { get; private set; }

        public Pedido(int idPedido, DateTime dataPedido, double valorPedido)
        {
            IdPedido = idPedido;
            DataPedido = dataPedido;
            ValorPedido = valorPedido;
        }

        public virtual double CalculaTotal()
        {
            return ValorPedido;
        }
    }
}
