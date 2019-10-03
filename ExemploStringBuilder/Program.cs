using System;
using ExemploStringBuilder.Entities;

namespace ExemploStringBuilder {
    class Program {
        static void Main(string[] args) {
            //aqui estamos instanciando as classes, e atribuindo valores a elas.
            //iremos fazer dois tipos de Instanciação para diversificar as situações.
            //mas as duas dará o mesmo resultado. Primeiro a classe Comentários
            Comentarios c1 = new Comentarios () {
                Texto = "Tenha uma Boa Viagem."
            };
            Comentarios c2 = new Comentarios {
                Texto = "Uau, Isso é Incrivel"
            };
            Comentarios c3 = new Comentarios {
                Texto = "Boa noite"
            };
            Comentarios c4 = new Comentarios {
                Texto = "Que a força esteja com você"
            };
            //instanciando a classe Postagem, e atribuindo os valores diretamente,
            //conforme o enunciado. 
            Postagem p1 = new Postagem(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para Nova Zelandia",
                "Indo Conhecer esse Maravilhoso País",
                12);
            //após criar o objeto p1 do tipo Postagem vamos adicionar os comentários a ela.
            p1.AdicionarComentarios(c1);
            p1.AdicionarComentarios(c2);


            Postagem p2 = new Postagem(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa Noite Pessoal",
                "Vejo vocês amanhã",
                5);
            //após criar o objeto p2 do tipo Postagem vamos adicionar os comentários a ela.
            p2.AdicionarComentarios(c3);
            p2.AdicionarComentarios(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
