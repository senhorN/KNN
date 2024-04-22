using Knn.Class;
using Knn.Controller;
using System.IO;
using System.Diagnostics;


Console.Clear();
Console.WriteLine();
Console.WriteLine("Trabalho KNN");
Console.WriteLine("Desenvolvido por Nícolas Carloto");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.Write("Pressione pra continuar...");
Console.ReadKey();
Console.Clear();


KNN knn = new KNN();
Filmes[] arrayFilmes = new Filmes[12];
Filmes filme = new Filmes();

Console.WriteLine("Classifique o filme de 1 a 10 com base no tipo do genêro: \n");
Console.WriteLine();
Console.Write("Ação: ");
filme.wAcao = (Convert.ToDouble(Console.ReadLine())/10);

Console.Write("Comédia: ");
filme.wComedia = (Convert.ToDouble(Console.ReadLine())/10);

Console.Write("Romance: ");
filme.wRomance = (Convert.ToDouble(Console.ReadLine())/10);

Console.Write("Violência: ");
filme.wViolencia = (Convert.ToDouble(Console.ReadLine())/10);
Console.WriteLine();

Console.Write("Certo. \n");
Console.Write("Selecionando filmes com base na sua classficação...");
Thread.Sleep(5000);
Console.Clear();


Console.Write("Procurando os filmes no nosso banco de dados...");
Thread.Sleep(2000);
Console.Clear();


Console.Write("Procurando...");
Thread.Sleep(3000);
Console.Clear();

arrayFilmes = knn.RecomendarFilme(filme);



Console.WriteLine("Temos aqui 3 sugestões de filmes que você pode gostar: ");
Thread.Sleep(2000);

Console.WriteLine();



int i = 0; 
foreach (var item in arrayFilmes){
    
    i++;
    Console.WriteLine($"{i} - {item.Titulo.ToString()}");

}

#region base de teste 
//base de testes
//Transformando a saida em bloco de notas

string CamihoArquivo = @"C:\\Users\\nick6\\Desktop\\";

Process.Start("notepad.exe", $"{CamihoArquivo} filmes_recomendados.txt");

/*
if(!Directory.Exists(CamihoArquivo)){
    
    Directory.CreateDirectory(CamihoArquivo);
}

using (StreamWriter file = new StreamWriter(Path.Combine(CamihoArquivo, "filmes_recomendados.txt"))){
    
    foreach (var item in arrayFilmes){
        file.WriteLine($"{item.Titulo}");
    }
}

int y = 0;
foreach (var item in arrayFilmes){
    
    y++;
    Console.WriteLine($"{y} - {item.Titulo}");

}
*/
#endregion
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();
