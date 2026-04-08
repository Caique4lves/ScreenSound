class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine("Lista de músicas do álbum {0}:\n", Nome);
        foreach (var musica in musicas)
        {
            Console.WriteLine("Música: {0}", musica.Nome);
        }

        Console.WriteLine("\nPara ouvir esse albúm inteiro, você precisa de {0} segundos.", DuracaoTotal);
    }
}
