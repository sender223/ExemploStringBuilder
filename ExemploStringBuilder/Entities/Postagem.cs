using System;
using ExemploStringBuilder.Entities;
using System.Text;
using System.Collections.Generic;

namespace ExemploStringBuilder.Entities {
    class Postagem {

        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        public List<Comentarios> Comentarios { get; set; } = new List<Comentarios>();

        public Postagem() {

        }

        public Postagem(DateTime momento, string titulo, string conteudo, int curtidas ) {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtidas = curtidas;
        }

        public void AdicionarComentarios(Comentarios comentario) {
            Comentarios.Add(comentario);
        }
        public void RemoverComentarios(Comentarios comentario) {
            Comentarios.Remove(comentario);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários:");
            //precisaremos percorrer todos os comentários vinculados na postagem
            //para isso vamos usar o foreach, para cada coment dentro de Comentarios, imprimir 
            //coment.texto
            foreach (Comentarios coment in Comentarios) {
                sb.AppendLine(coment.Texto);
            }
            //finalizando para retornar o valor do sb convertido em ToString();
            return sb.ToString();
        }
    }
}
