Episodeo ep1 = new(1, "Técnicas de facilitação",45);
ep1.adicionarConvidados("Maria");
ep1.adicionarConvidados("Bruno");
ep1.adicionarConvidados("Cesar");
Console.WriteLine(ep1.Resumo);

Episodeo ep2 = new(2, "Técnicas de facilitação",45);
ep2.adicionarConvidados("Cesar");
Console.WriteLine(ep2.Resumo);


Episodeo ep3 = new(3, "Técnicas de facilitação",45);
ep3.adicionarConvidados("Bruno");
Console.WriteLine(ep3.Resumo);


Episodeo ep4 = new(4, "Técnicas de facilitação",45);
ep4.adicionarConvidados("Maria");
Console.WriteLine(ep4.Resumo);

Podcast podcast = new("Podcast Serelepe", "Bruno");
podcast.AdicionarEpisodeo(ep1);
podcast.AdicionarEpisodeo(ep2);
podcast.AdicionarEpisodeo(ep3);
podcast.AdicionarEpisodeo(ep4);

podcast.ExibirDetalhes();