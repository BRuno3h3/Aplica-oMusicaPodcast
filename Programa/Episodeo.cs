class Episodeo
{
    private List<String> convidados = new();
    public Episodeo(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    
    public void adicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}