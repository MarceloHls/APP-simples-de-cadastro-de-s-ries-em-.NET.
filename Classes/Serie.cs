using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
   public class Serie:EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }
        private string Descriçao { get; set; }

        private int Ano { get; set; }

        private bool excluido { get; set; }

        public Serie(int ID,Genero Genero,string Titulo,string Descricao, int Ano)
        {
            this.Ano = Ano;
            this.Titulo = Titulo;
            this.Descriçao = Descriçao;
            this.Genero = Genero;
            this.excluido = false;
            this.ID = ID;
        }



        public override string ToString()
        {
            string retorno = "";
            retorno += $"Genero: {this.Genero}" + Environment.NewLine;
            retorno += $"Titulo: {this.Titulo}" + Environment.NewLine;
            retorno += $"Descriçao: {this.Descriçao}" + Environment.NewLine;
            retorno += $"Ano: {this.Ano}";

            return retorno;
        }

        public string getTitulo() { return this.Titulo; }
        public int getId() { return this.ID; }

        public void setExcluido(bool situacao) { this.excluido = situacao; }
        public bool getExcluido() { return this.excluido; }


    }
}
