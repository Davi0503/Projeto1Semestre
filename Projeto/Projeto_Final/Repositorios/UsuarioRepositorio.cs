using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Projeto_Final.Controllers;
using Projeto_Final.Models;

namespace Projeto_Final.Repositorios {

    public class UsuarioRepositorio {
        public List<UsuarioModel> UsuariosSalvos { get; private set; }

 
        public UsuarioRepositorio () {

            if (File.Exists ("usuarios.dat")) {
                UsuariosSalvos = Listar ();
            } else {
                UsuariosSalvos = new List<UsuarioModel> ();
            }

        }

        public UsuarioModel Cadastrar (UsuarioModel usuario) {

            usuario.Id = UsuariosSalvos.Count + 1;

            UsuariosSalvos.Add (usuario);

            SerealizarLista ();

            return usuario;

        }

        public void SerealizarLista () {

            MemoryStream memoria = new MemoryStream ();
            BinaryFormatter serializador = new BinaryFormatter ();

            //Serializa e guarda os dados dentro do MemoryStream
            serializador.Serialize (memoria, UsuariosSalvos);

            File.WriteAllBytes ("usuarios.dat", memoria.ToArray ());
        }

        public static List<UsuarioModel> Listar () {

            if (!File.Exists ("usuarios.dat")) {

                return new List<UsuarioModel> ();
            }

            byte[] bytesSerializados = File.ReadAllBytes ("usuarios.dat");

            BinaryFormatter serealizador = new BinaryFormatter ();

            MemoryStream memoria = new MemoryStream (bytesSerializados);

            return (List<UsuarioModel>) serealizador.Deserialize (memoria);
        }

        public static UsuarioModel Login (string email, string senha) {

            List<UsuarioModel> usuariosLogin = UsuarioRepositorio.Listar ();

            foreach (var item in usuariosLogin) {
                if (email == item.Email && senha == item.Senha) {

                    return item;
                }

            }
            return null;

        }

        public UsuarioModel BuscarPorEmail (string email) {

            foreach (var item in UsuariosSalvos) {
                if (email == item.Email) {
                    return item;
                }

            }
            return null;
        }

        
    }
}

//Terminar login no startUp adicionando o id do usuario na sessão, segue o baile