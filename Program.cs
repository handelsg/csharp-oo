Episodio ep1 = new Episodio(1, "Fundamentos", 45);
ep1.AdicionarConvidado("Paulo Silveira");
ep1.AdicionarConvidado("Guilherme Silveira");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(2, "Orientação a objetos", 45);
ep2.AdicionarConvidado("Paulo Silveira");
ep2.AdicionarConvidado("Guilherme Silveira");
ep2.AdicionarConvidado("Thiago Campos");

Podcast podcast = new Podcast("Hipsters Ponto Tech", "Paulo Silveira");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();