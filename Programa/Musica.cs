class Musica
{
  public Musica(string nome, Banda artista)
  {
    Nome = nome;
    Artista = artista;
  }

  public string Nome { get; }
  public Banda Artista { get; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }
  public string DescricaoResumida => $"A Musica {Nome} pertence á banda {Artista}";

}