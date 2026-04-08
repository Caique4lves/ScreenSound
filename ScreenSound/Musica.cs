using System.Threading.Channels;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"\nA música {Nome} pertence à banda {Artista}"; // Apago o set pois não quero que o valor seja alterado, somente lido (get).

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("\nNome: {0}", Nome);
        Console.WriteLine("Artista: {0}", Artista.Nome);
        Console.WriteLine("Duração: {0}", Duracao);
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+.");
        }
    }
    
}





