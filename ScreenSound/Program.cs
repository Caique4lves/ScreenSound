Banda top = new Banda("Twenty One Pilots");

Album albumTop1 = new Album("Trench");

Musica musica1 = new Musica(top, "Chlorine")
{
    Duracao = 324,
    Disponivel = true
};

Musica musica2 = new Musica(top, "Jumpsuit")
{
    Duracao = 238,
    Disponivel = false
};

albumTop1.AdicionarMusica(musica1);
albumTop1.AdicionarMusica(musica2);
top.AdicionarAlbum(albumTop1);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumTop1.ExibirMusicasDoAlbum();
top.ExibirDicografia();



