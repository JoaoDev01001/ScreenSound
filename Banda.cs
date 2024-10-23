class Banda
{
    
    private List<Album> albums = new List<Album>();

    public string Nome { get;}

    public Banda(string nome)
    {
        Nome = nome;
    }


    public void AdicionarAlbum(Album album )
    {
        albums.Add( album );
    }

    public void ExibiDiscografia ()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var item in albums)
        {
            Console.WriteLine($"Álbum: {item.Nome} ({item.Duracao})");
        }
    }
}