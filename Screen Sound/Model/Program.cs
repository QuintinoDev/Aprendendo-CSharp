//Criação de musicas
Musica  musica1 = new Musica("Mansão Tug Stronda", "Leo Stronda", 60);
Musica  musica2 = new Musica("Play Love", "Leo Stronda", 90);
Musica  musica3 = new Musica("XXT ", "Leo Stronda", 360);
//Criação de um ALbum onde tem vairias musicas
Album album1 = new Album("Putaria Stronda");
album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
album1.AdicionarMusica(musica3);
album1.ExibirMusicasAlbum();
//Criação de uma banda onde tem varios Albuns
Banda banda = new Banda("Bonde da Stronda");
banda.AdicionarAlbum(album1);
banda.ExibirDiscografia();
Console.WriteLine("**************************************************************");
Episodio ep1 = new(1, "futibol da semana", 45);
ep1.AdicionarConvidados("yuri22");
ep1.AdicionarConvidados("dona");
Episodio ep2 = new(2, "resenha boa", 30);
ep2.AdicionarConvidados("casemiro");

