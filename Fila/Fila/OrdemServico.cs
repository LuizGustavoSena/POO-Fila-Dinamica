using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class OrdemServico
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Prazo { get; set; }
        public OrdemServico Proximo { get; set; }

        // IMPRESSAO
        public override string ToString()
        {
            return "ORDEM DE SERVIÇO\nId: " + Id + 
                "\nTipo: " + Tipo + "\nDescrição: " + Descricao +
                "\nData: " + DataCriacao +
                "\nPrazo: " + Prazo + " Dias";
        }
    }
}
