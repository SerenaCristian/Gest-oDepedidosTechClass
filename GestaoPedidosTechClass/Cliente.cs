using System;

namespace GestaoPedidosTechClass
{
    public class Cliente
    {
        public string Nome { get; private set; }
        private Pedido[] Pedidos;
        private int contadorPedidos;

        public Cliente(string nome, int capacidadePedidos)
        {
            Nome = nome;
            Pedidos = new Pedido[capacidadePedidos];
            contadorPedidos = 0;
        }


        public void AdicionarPedido(Pedido pedido)
        {
            if (contadorPedidos < Pedidos.Length)
            {
                Pedidos[contadorPedidos] = pedido;
                contadorPedidos++;
            }
            else
            {
                Console.WriteLine("Limite de pedidos atingido!");
            }
        }


        public void RemoverPedido(int idPedido)
        {
            for (int i = 0; i < contadorPedidos; i++)
            {
                if (Pedidos[i].IdPedido == idPedido)
                {
                    Pedidos[i] = null;

                    for (int j = i; j < contadorPedidos - 1; j++)
                    {
                        Pedidos[j] = Pedidos[j + 1];
                    }
                    Pedidos[contadorPedidos - 1] = null;
                    contadorPedidos--;
                    break;
                }
            }
        }

        public void ListarPedidos()
        {
            Console.WriteLine($"Pedidos de {Nome}:");
            for (int i = 0; i < contadorPedidos; i++)
            {
                if (Pedidos[i] != null)
                {
                    Console.WriteLine($"ID: {Pedidos[i].IdPedido}, Data: {Pedidos[i].DataPedido.ToShortDateString()}, Total: R${Pedidos[i].CalculaTotal():F2}");
                }
            }
        }
    }
}


