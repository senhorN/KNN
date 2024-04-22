using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knn.Class;
namespace Knn.Controller
{
    public class KNN
    {
        private Filmes[] arrayFilmes  = new Filmes[12];

        private double resultViolencia, resultAcao, resultRomance, resultComedia, somatoria;

        public void ListarFilme(){

            arrayFilmes[0] = new Filmes { Id = 1, Titulo = "As patricinhas de Beverly Hills"       , wViolencia = 0.0, wAcao = 0.3, wRomance = 0.3, wComedia = 0.8 };
            arrayFilmes[1] = new Filmes { Id = 2, Titulo = "De repente 30"                         , wViolencia = 0.0, wAcao = 0.2, wRomance = 0.1, wComedia = 0.7 };
            arrayFilmes[2] = new Filmes { Id = 3, Titulo = "Ela é demais para mim"                 , wViolencia = 0.0, wAcao = 0.1, wRomance = 0.4, wComedia = 0.6 };
            arrayFilmes[3] = new Filmes { Id = 4, Titulo = "Simplesmente acontece"                 , wViolencia = 0.0, wAcao = 0.2, wRomance = 0.8, wComedia = 0.3 };
            arrayFilmes[4] = new Filmes { Id = 5, Titulo = "E se fosse verdade"                    , wViolencia = 0.1, wAcao = 0.2, wRomance = 0.8, wComedia = 0.4 };
            arrayFilmes[5] = new Filmes { Id = 6, Titulo = "Wall-E"                                , wViolencia = 0.0, wAcao = 0.5, wRomance = 0.5, wComedia = 0.5 };
            arrayFilmes[6] = new Filmes { Id = 7, Titulo = "Divergente: Insurgente"                , wViolencia = 0.3, wAcao = 0.8, wRomance = 0.4, wComedia = 0.1 };
            arrayFilmes[7] = new Filmes { Id = 8, Titulo = "Guardiões da Galáxia"                  , wViolencia = 0.2, wAcao = 0.5, wRomance = 0.2, wComedia = 0.2 };
            arrayFilmes[8] = new Filmes { Id = 9, Titulo = "Capitão América 2: O Soldado Invernal" , wViolencia = 0.2, wAcao = 0.8, wRomance = 0.3, wComedia = 0.1 };
            arrayFilmes[9] = new Filmes { Id = 10, Titulo = "Assassinos por natureza"              , wViolencia = 0.9, wAcao = 0.8, wRomance = 0.3, wComedia = 0.8 };
            arrayFilmes[10] = new Filmes { Id = 11, Titulo = "Rambo IV"                            , wViolencia = 1.0, wAcao = 0.9, wRomance = 0.1, wComedia = 0.3 };
            arrayFilmes[11] = new Filmes { Id = 12, Titulo = "Scarface"                            , wViolencia = 1.0, wAcao = 1.0, wRomance = 0.2, wComedia = 0.8 };
            //gerando mais filmes 
            /*arrayFilmes[12] = new Filmes { Id = 13, Titulo = "O Senhor dos Anéis: A Sociedade do Anel"      , wViolencia = 0.2, wAcao = 0.8, wRomance = 0.1, wComedia = 0.0 };
            arrayFilmes[13] = new Filmes { Id = 14, Titulo = "Harry Potter e a Pedra Filosofal"             , wViolencia = 0.1, wAcao = 0.7, wRomance = 0.2, wComedia = 0.1 };
            arrayFilmes[14] = new Filmes { Id = 15, Titulo = "Interestelar"                                 , wViolencia = 0.1, wAcao = 0.6, wRomance = 0.1, wComedia = 0.0 };
            arrayFilmes[15] = new Filmes { Id = 16, Titulo = "O Poderoso Chefão"                            , wViolencia = 0.9, wAcao = 0.3, wRomance = 0.2, wComedia = 0.0 };
            arrayFilmes[16] = new Filmes { Id = 17, Titulo = "Matrix"                                       , wViolencia = 0.8, wAcao = 0.9, wRomance = 0.1, wComedia = 0.0 };
            arrayFilmes[17] = new Filmes { Id = 18, Titulo = "O Rei Leão"                                   , wViolencia = 0.1, wAcao = 0.3, wRomance = 0.7, wComedia = 0.2 };
            arrayFilmes[18] = new Filmes { Id = 19, Titulo = "Forrest Gump"                                 , wViolencia = 0.1, wAcao = 0.3, wRomance = 0.8, wComedia = 0.3 };
            arrayFilmes[19] = new Filmes { Id = 20, Titulo = "Cidade de Deus"                               , wViolencia = 0.9, wAcao = 0.8, wRomance = 0.1, wComedia = 0.0 };
            arrayFilmes[20] = new Filmes { Id = 21, Titulo = "O Labirinto do Fauno"                         , wViolencia = 0.7, wAcao = 0.4, wRomance = 0.3, wComedia = 0.0 };
            arrayFilmes[21] = new Filmes { Id = 22, Titulo = "O Show de Truman"                             , wViolencia = 0.1, wAcao = 0.2, wRomance = 0.8, wComedia = 0.5 };*/

        }
        public Filmes[] RecomendarFilme(Filmes pFilme){
            
            ListarFilme();

            foreach (var item in arrayFilmes)
            {

                resultViolencia = Math.Pow((pFilme.wViolencia - item.wViolencia), 2);
                resultAcao      = Math.Pow((pFilme.wAcao      - item.wAcao)          , 2);
                resultRomance   = Math.Pow((pFilme.wRomance   - item.wRomance)    , 2);
                resultComedia   = Math.Pow((pFilme.wComedia   - item.wComedia)    , 2);


                somatoria = resultViolencia + resultAcao + resultRomance + resultComedia;

                item.wPesoFinal = Math.Sqrt(somatoria);
            }

            Console.WriteLine("Mostrando calculos");
            Console.Write("\n");

            Console.WriteLine("Lista ordenada por pesos");
            Console.Write("\n");

            Array.Sort(arrayFilmes, (x, y) => x.wPesoFinal.CompareTo(y.wPesoFinal));

            foreach (var item in arrayFilmes)
            {
                Console.WriteLine($"{item.Titulo } - {item.wPesoFinal}");
            }
            Console.Write("\n");
            Console.WriteLine("Top 3 menores pesos");
            Console.Write("\n");

            Filmes[] filmesRecomendados = new Filmes[3];
            Array.Copy(arrayFilmes, filmesRecomendados, 3);

            foreach (var item in filmesRecomendados)
            {

                Console.WriteLine($"{item.Titulo } - {item.wPesoFinal}");
            }

            Console.Write("\n");
            Console.WriteLine("Aperte qualquer tecla para prosseguir...");
            Console.ReadKey();
            Console.Clear();

            return filmesRecomendados;
        }
    }
}