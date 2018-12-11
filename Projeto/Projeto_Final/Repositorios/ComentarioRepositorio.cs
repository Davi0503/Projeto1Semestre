using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Projeto_Final.Models;

namespace Projeto_Final.Repositorios {
    public class ComentarioRepositorio {
        public List<ComentarioModel> ComentariosSalvos { get; set; }

        public ComentarioRepositorio () {

            if (File.Exists ("Comentarios.dat")) {

                ComentariosSalvos = Listar ();
            } else {
                ComentariosSalvos = new List<ComentarioModel> ();
            }
        }
        public ComentarioModel Cadastrar (ComentarioModel comentario) {

            comentario.Id = ComentariosSalvos.Count + 1;

            ComentariosSalvos.Add (comentario);

            SerealizarLista ();

            return comentario;

        }

        public static List<ComentarioModel> Listar () {

            if (!File.Exists ("Comentarios.dat")) {

                return new List<ComentarioModel> ();
            }

            byte[] bytesSerializados = File.ReadAllBytes ("Comentarios.dat");

            BinaryFormatter seralizador = new BinaryFormatter ();

            MemoryStream memoria = new MemoryStream (bytesSerializados);

            return (List<ComentarioModel>) seralizador.Deserialize (memoria);
        }

        public void SerealizarLista () {

            MemoryStream memoria = new MemoryStream ();
            BinaryFormatter serealizador = new BinaryFormatter ();

            serealizador.Serialize (memoria, ComentariosSalvos);

            File.WriteAllBytes ("Comentarios.dat", memoria.ToArray ());
        }

        public void Rejeitar (int id) {

            foreach (var item in ComentariosSalvos) {
                if (item.Id == id) {

                    item.Ativo = false;
                    SerealizarLista ();
                }
            }
        }

        public void Aprovar (int id) {

            foreach (var item in ComentariosSalvos) {
                if (item.Id == id) {

                    item.Aprovado = true;
                    SerealizarLista ();
                }
            }
        }

    }
}