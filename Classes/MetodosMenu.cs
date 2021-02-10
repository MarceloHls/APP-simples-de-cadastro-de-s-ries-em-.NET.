using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series.Classes;

namespace Series
{
    public class MetodosMenu
    {

        public static void ListarSeries(RepositorioSerie repositorio)
        {
            Console.WriteLine("Listar series");
            if(repositorio.Lista().Count == 0)
            {
                Console.WriteLine("Lista Vazia");
                return;
            }

            repositorio.Lista().ForEach(x => {
                if (x.getExcluido()) return;
                Console.WriteLine($"ID: {x.getId()} Titulo :{x.getTitulo()}");
            });
        }
        public static Serie InserirSerie(RepositorioSerie repositorio,bool adicionar)
        {
           foreach(int item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{item} - {Enum.GetName(typeof(Genero), item)}");
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(ID: repositorio.getProximoID(),
                                        Genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        Ano: entradaAno,
                                        Descricao: entradaDescricao);


            if (adicionar)
            {
                repositorio.Insere(novaSerie);
            }

            return novaSerie;



        }

        public static void AtualizarSerie(RepositorioSerie repositorio)
        {
            Console.Write("Digite o ID da serie: ");
            int id = int.Parse(Console.ReadLine());
            Serie novaSerie = InserirSerie(repositorio, false);
            repositorio.Atualiza(id, novaSerie);
        }

        public static void ExcluirSerie(RepositorioSerie repositorio) {
            Console.Write("Digite o ID da serie: ");
            int id = int.Parse(Console.ReadLine());
            repositorio.Exclui(id);
        }
        public static void VisualizarSerie(RepositorioSerie repositorio) {
            Console.Write("Digite o ID da serie: ");
            int id = int.Parse(Console.ReadLine());

           Console.WriteLine( repositorio.GetByID(id).ToString());
        }
    }
}
