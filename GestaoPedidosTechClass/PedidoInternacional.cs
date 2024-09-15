namespace GestaoPedidosTechClass
{
    public class PedidoInternacional : Pedido
    {
        private const double TaxaImportacao = 0.30;

        public PedidoInternacional(int idPedido, DateTime dataPedido, double valorPedido) : base(idPedido, dataPedido, valorPedido) { }

        public override double CalculaTotal()
        {
            return ValorPedido + (ValorPedido * TaxaImportacao);
        }
    }
}
