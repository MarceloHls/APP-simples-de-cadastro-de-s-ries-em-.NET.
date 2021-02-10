using System;
using Series.Classes;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioSerie repositorio = new RepositorioSerie();

            Menu.exeMenu(repositorio);

        }
    }
}
