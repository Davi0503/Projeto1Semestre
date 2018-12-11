using System;

namespace Projeto_Final.Models {

    [Serializable]
    public class ComentarioModel {

        public int Id { get; set; }

        public UsuarioModel Usuario { get; set; }

        public string Texto { get; set; }

        public DateTime DataCriacao { get; set; }

        public bool Aprovado { get; set; }

        public bool Ativo { get; set; }


        
    }
}