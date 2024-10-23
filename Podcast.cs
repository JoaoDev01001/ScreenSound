class Podcast
{
    List<Episodio> episodios = new();
    public Podcast ( string host , string nome )
    {
        Host = host;
        Nome = nome;
    }

    string Host { get;}
    string Nome { get;}
    int TotalEp => episodios.Count;


    public void AddEpisodio (Episodio episodio)
    {
        episodios.Add( episodio );
    }

    public void ExibirDetalhes ()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este Podcast possui {TotalEp} episódios");
    }
}