class Banda
{
    private List<Album> Albuns = new List<Album>();
     public Banda(String nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void ExibirDiscografia()
    {   
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
