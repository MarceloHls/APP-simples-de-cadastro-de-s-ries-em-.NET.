using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series.Classes
{
   public class RepositorioSerie : iRepositorio<Serie>
    {

        List<Serie> series = new List<Serie>();

        private int proximoId = 1;

        public int getProximoID() { return this.proximoId; }
        public void Atualiza(int id, Serie entidade)
        {
            Exclui(id);
            Insere(entidade);
        }

        public void Exclui(int id)  { series.First(x => x.getId() == id).setExcluido(true);}

        public Serie GetByID(int id){
            return series.First(x => x.getId() == id); 
        }

        public void Insere(Serie entidade) { series.Add(entidade); this.proximoId++;}

        public List<Serie> Lista() {return this.series; }

     
    }
}
