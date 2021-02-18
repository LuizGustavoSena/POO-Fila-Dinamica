using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class Fila
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }

        public void push(OrdemServico aux)
        {
            if (vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }

        }

        public void imprimir()
        {
            if (vazia())
                Console.WriteLine("Fila vazia");
            else
            {
                OrdemServico aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine("-----------------------");
                    aux = aux.Proximo;
                } while (aux != null);
            }
        }

        public void pop()
        {
            if (vazia())
                Console.WriteLine("Fila Vaizia!");
            else
            {
                Head = Head.Proximo;
                if (Head == null)
                    Tail = null;
            }
        }

        public int qtd()
        {
            int contador = 0;
            if(Head != null)
            {
                OrdemServico aux = Head;
                do
                {
                    contador++;
                    aux = aux.Proximo;
                } while (aux != null);
            }
            return contador;
        }

        public void buscar(int tipo)
        {
            if (vazia())
                Console.WriteLine("Fila Vazia!");
            else { 
                OrdemServico aux = Head;
                bool encontra = false;
                do
                {
                    if(tipo == aux.Id) { 
                        Console.WriteLine(aux.ToString());
                        encontra = true;
                    }
                    aux = aux.Proximo;
                } while (aux != null);
                if (!encontra)
                    Console.WriteLine("Ordem não encontrada");
            }
        }

        private bool vazia()
        {
            if (Head == null && Tail == null)
                return true;
            return false;
        }
    }
}
