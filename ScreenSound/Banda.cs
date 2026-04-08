class Banda
{
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDicografia()
    {
        Console.WriteLine("Discografia da banda: {0}", Nome);
        foreach(Album album in albuns)
        {
            Console.WriteLine("Álbum: {0} ({1} segundos)", album.Nome, album.DuracaoTotal);
        }

    }
}