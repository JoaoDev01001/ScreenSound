Banda queen = new Banda("Queen");


Album albumDoQueen = new Album("A nigth at the opera");

Musica musica1 = new Musica(queen , "Love of my live")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen , "Bohemia Rhapsody")
{
    Duracao = 354 ,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.AdicionarMusica(musica1);

queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibiDiscografia();
albumDoQueen.ExibirAlbum();

Console.WriteLine("\n");
Console.WriteLine("\n");


Episodio ep1 = new Episodio(1 , "Basio e avançado C#" , 45);
ep1.AdicionarConvidados("Joao Paulo");

Podcast cSharp = new Podcast("Joao Paulo","Curso de C#");
cSharp.AddEpisodio(ep1);

cSharp.ExibirDetalhes();




