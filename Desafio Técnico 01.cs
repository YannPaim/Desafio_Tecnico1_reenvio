using System;
class DesafioTécnico 
{
  static void Main() {
     int idade = 18; //pelo q pesquisei 12 ou 18 depende da hora do filme
     int entrada = 0;
     int seguidores = 5;
     int seguir = 0;
     int videos = 1;
     double altura = 1.82; //pesquisei e falaram q é 6 feet e convertendo deu isso
     //float = ;
     //bool ;
     //bool =  ;
     //char ;
     //char
     string nome = "Shoya Ishida";
     string redesocial = "whispers of screams";
     string cidade = "Ōgaki";
     
     Console.WriteLine("Bem vindo ao: " + redesocial);
     Console.WriteLine("nome: " + nome);
     Console.WriteLine("idade: "+ idade);
     Console.WriteLine("altura: "+ altura);
     Console.WriteLine("deseja entrar no perfil de " + nome + " para ver mais informações?");
     Console.WriteLine("se sim digite 1 caso contrario digite 2");
     entrada = Convert.ToInt32(Console.ReadLine());
     
     if (entrada == 1)
    {
     Console.WriteLine("nome: " + nome);
     Console.WriteLine("idade: "+ idade);
     Console.WriteLine("altura: "+ altura);
     Console.WriteLine("videos: "+ videos);
     Console.WriteLine("seguidores: "+ seguidores);
    }
    else
    {
        Console.WriteLine("Proximo perfil: ");
    }
    Console.WriteLine("deseja seguir este perfil? se sim digite 1 se não digite 2.");
    seguir = Convert.ToInt32(Console.ReadLine());
    if(seguir == 1)
    {
     Console.WriteLine("nome: " + nome);
     Console.WriteLine("idade: "+ idade);
     Console.WriteLine("altura: "+ altura);
     Console.WriteLine("cidade: "+ cidade);
      Console.WriteLine("videos: "+ videos);
     Console.WriteLine(seguidores++);
     Console.WriteLine("seguidores: "+ seguidores);
     
    }
}
  }