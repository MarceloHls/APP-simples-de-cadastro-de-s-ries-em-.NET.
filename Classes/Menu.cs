using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series.Classes;

namespace Series
{
    class Menu
    {
        public static void exeMenu(RepositorioSerie repositorio)
        {
			string opcaoUsuario = Opcao.ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						MetodosMenu.ListarSeries(repositorio);
						break;
					case "2":
						MetodosMenu.InserirSerie(repositorio,true);
						break;
					case "3":
						MetodosMenu.AtualizarSerie(repositorio);
						break;
					case "4":
						MetodosMenu.ExcluirSerie(repositorio);
						break;
					case "5":
						MetodosMenu.VisualizarSerie(repositorio);
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = Opcao.ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

    }
}
