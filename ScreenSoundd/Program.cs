using System.Text.Json;
using ScreenSoundd.Modelos;
using ScreenSoundd.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta); 
        musicas[0].ExibirDetalhesDaMusica();
        LinqFilter.FiltrarTodososGerenerosMusicais(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
    
}