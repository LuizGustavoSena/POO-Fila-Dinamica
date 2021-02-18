using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila { Head = null, Tail = null };
            OrdemServico ordem;
            int op;

            do
            {
                op = menu(); // MENU

                Console.Clear(); // LIMPA TELA

                switch (op)
                {
                    case 1: // CADASTRO

                        ordem = lerOrdem(); // CADASTRA ORDEM

                        fila.push(ordem); // CADASTRA ORDEM NA FILA

                        break;
                    case 2: // IMPRIMIR

                        fila.imprimir(); // IMPRIME FILA

                        break;
                    case 3: // DELETAR

                        fila.pop(); // DELETA 1° DA FILA

                        break;
                    case 4: // QUANTIDADE

                        Console.WriteLine("Quantidade de Ordens de Serviço: " + fila.qtd()); // IMPRIME QUANTIDADE DE ORDENS NA FILA

                        break;
                    case 5: //BUSCAR
                        Console.WriteLine("Digite o Id da Ordem de Serviço");
                        fila.buscar(int.Parse(Console.ReadLine())); // BUSCA NA FILA E JÁ IMPRIME NO MÉTODO
                        break;
                }

            } while (op != 0);

            Console.ReadKey();
        }

        static int menu()
        {
            try
            {
                int op; // MENU
                Console.WriteLine("\n1 - Cadastrar Ordem de Serviço\n" +
                "2 - Imprimir Ordem de Serviço\n3 - Deletar primeira Ordem de Serviço\n" +
                "4 - Quantidade de Ordens de Serviço\n5 - Buscar Ordem de Serviço\n0 - Sair");
                op = int.Parse(Console.ReadLine());
                return op;
            }
            catch (Exception)
            {
                return menu(); // LAÇO RODA NOVAMENTE
            }
        }

        static OrdemServico lerOrdem()
        {
            try
            {
                int id, prazo;
                string tipo, descricao;

                Console.Write("Informe o Id da ordem: ");
                id = int.Parse(Console.ReadLine());

                do
                { // LAÇO CASO CAMPO ESTIVER VAZIO 
                    Console.Write("Informe o Tipo da ordem: ");
                    tipo = Console.ReadLine();
                } while (tipo == "");

                do
                { // LAÇO CASO CAMPO ESTIVER VAZIO
                    Console.Write("Informe a Descrição da ordem: ");
                    descricao = Console.ReadLine();
                } while (descricao == "");

                Console.Write("Prazo em dias da ordem: ");
                prazo = int.Parse(Console.ReadLine());

                OrdemServico s = new OrdemServico
                {
                    Id = id,
                    Tipo = tipo,
                    Descricao = descricao,
                    DataCriacao = DateTime.Now,
                    Prazo = prazo,
                    Proximo = null
                };
                return s;
            }
            catch (Exception)
            {
                Console.WriteLine("Informe os dados corretamente");
                OrdemServico ordem = lerOrdem();
                return ordem;
            }
        }
    }
}
