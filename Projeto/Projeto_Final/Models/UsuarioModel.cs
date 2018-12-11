using System;

namespace Projeto_Final.Models {

    [Serializable]
    public class UsuarioModel {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Administrador { get; set; }
    }
}