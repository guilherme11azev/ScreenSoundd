using System.Text.Json.Serialization;

namespace ScreenSoundd.Modelos
{
internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero {get; set; }

    public void ExibirDetalhesDaMusica()
    {
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Música: {Nome}");
        System.Console.WriteLine($"Gênero musical: {Genero}");
        System.Console.WriteLine($"Duração em segundos: {Duracao /1000}");
    }
}
}