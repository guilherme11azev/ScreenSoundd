using System.Linq;
using ScreenSoundd.Modelos;

namespace ScreenSoundd.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodososGerenerosMusicais(List<Musica> musicas)
    {
        var todosOsGerenosMusicais = musicas.Select(generos => generos.Genero).Distinct()
            .ToList();
        foreach (var genero in todosOsGerenosMusicais)
        {
            System.Console.WriteLine($"- {genero}");
        }
    }
}