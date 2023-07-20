class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
   
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => 
    $"A música {Nome} - pertence á Banda {Artista.Nome} ({Duracao} segundos)";

    

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Nome do Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível: {Disponivel}");

        if(Disponivel)
        {
            Console.WriteLine("A música está disponível");
        }
        else
        {
            Console.WriteLine("A música não está disponível");
        }
    }


}