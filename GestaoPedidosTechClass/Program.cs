using System;

namespace GestaoPedidosTechClass
{
    class Program
    {
        // Variável estática para auto-incrementar o ID do pedido
        private static int proximoIdPedido = 1;

        static void Main(string[] args)
        {
            // Solicitar o nome do cliente
            Console.WriteLine("Por favor, digite seu nome:");
            string nomeCliente = Console.ReadLine();

            Cliente cliente = new Cliente(nomeCliente, 10); // Cliente com nome fornecido

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine($"Bem-vindo {nomeCliente} ao Sistema de Gestão de Pedidos");
                Console.WriteLine("Escolha o tipo de pedido:");
                Console.WriteLine("1. Pedido Nacional");
                Console.WriteLine("2. Pedido Internacional");
                Console.WriteLine("0. Sair");

                int escolhaTipoPedido = int.Parse(Console.ReadLine());

                if (escolhaTipoPedido == 0)
                {
                    continuar = false;
                    break;
                }

               
                int idPedido = proximoIdPedido++;

               
                DateTime dataPedido = DateTime.Now;

                double valorBase = 0.0;
                int quantidadeItens = 0;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Menu de Lanchonete:");
                    Console.WriteLine("1. Hambúrguer - R$15.00");
                    Console.WriteLine("2. Batata Frita - R$10.00");
                    Console.WriteLine("3. Refrigerante - R$5.00");
                    Console.WriteLine("0. Finalizar Pedido");

                    int escolhaMenu = int.Parse(Console.ReadLine());

                    if (escolhaMenu == 0)
                    {
                        break;
                    }

                    switch (escolhaMenu)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu Hambúrguer.");
                            valorBase += 15.00;
                            quantidadeItens++;
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu Batata Frita.");
                            valorBase += 10.00;
                            quantidadeItens++;
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu Refrigerante.");
                            valorBase += 5.00;
                            quantidadeItens++;
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                 
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

                Pedido pedido;

                if (escolhaTipoPedido == 1)
                {
                    pedido = new PedidoNacional(idPedido, dataPedido, valorBase);
                }
                else if (escolhaTipoPedido == 2)
                {
                    pedido = new PedidoInternacional(idPedido, dataPedido, valorBase);
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                
                cliente.AdicionarPedido(pedido);

               
                Console.WriteLine("\nDetalhes do Pedido:");
                Console.WriteLine($"Nome do Cliente: {nomeCliente}");
                Console.WriteLine($"ID do Pedido: {idPedido}");
                Console.WriteLine($"Data do Pedido: {dataPedido.ToShortDateString()}");
                Console.WriteLine($"Quantidade de Itens: {quantidadeItens}");
                Console.WriteLine($"Total do Pedido: R${pedido.CalculaTotal():0.00}");

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

           
            cliente.ListarPedidos();

            Console.WriteLine("Obrigado por usar o Sistema de Gestão de Pedidos!");
        }
    }
}
