
class Album
{

    private List<Musica> musicas = new List<Musica>();

    public Album (string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public int Duracao => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica muscia )
    {
        musicas.Add( muscia );
    }

    public void ExibirAlbum ()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}\n");
        foreach (var item in musicas)
        {
            Console.WriteLine($"Música: {item.Nome}");
        }
        Console.WriteLine($"\nDuração total do álbum: {Duracao}");
    }


}