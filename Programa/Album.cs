class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Músicas: {musica.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao}");
        }

        Console.WriteLine($"Para ouvir esse album inteiro você precisa de {DuracaoTotal}");
    }
}