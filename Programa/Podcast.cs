class Podcast
{
    private List<Episodeo> episodeos = new List<Episodeo>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodeos => episodeos.Count;

    public void AdicionarEpisodeo(Episodeo episodeo)
    {
        episodeos.Add(episodeo);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome}, apresentado por {Host})\n");
        foreach (Episodeo episodeo in episodeos.OrderBy(e => e.Ordem))
        {
           Console.WriteLine(episodeo.Resumo);
        } 
        Console.WriteLine($"Este Podcast possui {TotalEpisodeos} Episodeo(s)");
    }   
}