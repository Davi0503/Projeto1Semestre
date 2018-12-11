using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;
using Projeto_Final.util;

namespace Projeto_Final.Controllers {
    public class UsuarioController : Controller {

        [HttpGet]
        public IActionResult Cadastrar () {

            return View ();

        }

        [HttpPost]

        public IActionResult Cadastrar (IFormCollection form) {

            UsuarioModel usuario = new UsuarioModel ();
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            usuario.Id = 1;
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.Administrador = false;

            if(string.IsNullOrEmpty(usuario.Nome)){

                ViewBag.Mensagem = "todos os campos devem ser preechidos";
                
                return View();
            }
            if(string.IsNullOrEmpty(usuario.Email)){

                 ViewBag.Mensagem = "todos os campos devem ser preechidos";

                   return View();


            }

            if(string.IsNullOrEmpty(usuario.Senha)){

                ViewBag.Mensagem = "todos os campos devem ser preechidos";

                  return View();
            }

            

            if (usuarioRepositorio.BuscarPorEmail (usuario.Email) != null) {

                ViewBag.Mensagem = "Email já cadastrado";

                return View ();

            }

            usuarioRepositorio.Cadastrar (usuario);

            return RedirectToAction ("Login");
        }

        [HttpGet]
        public IActionResult Listar () {

            List<UsuarioModel> usuarios = UsuarioRepositorio.Listar ();

            ViewData["bananinha"] = usuarios;

            return View ();

        }

        [HttpGet]
        public IActionResult Login () {

            if(HttpContext.Session.GetObjectFromJson<UsuarioModel> ("Usuario") == null){
                return View();
            }

            return RedirectToAction("Checar", "Comentario");
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {

            UsuarioModel usuarioLogado = new UsuarioModel ();

            if(string.IsNullOrEmpty(form["email"]) || string.IsNullOrEmpty(form["senha"])){

                @ViewBag.Mensagem = "Preecha todos os campos"; 

                return View();           

            }

            usuarioLogado = UsuarioRepositorio.Login (email: form["email"], senha: form["senha"]);

            if (usuarioLogado != null) {

                HttpContext.Session.SetObjectAsJson ("Usuario", usuarioLogado);

                return RedirectToAction ("Checar", "Comentario");
            }

            @ViewBag.Mensagem = "Usuário inválido";

            return View ();
        }

         public IActionResult Deslogar(){

            HttpContext.Session.SetObjectAsJson ("Usuario", null);


            return RedirectToAction("ListarDeslog", "Comentario");
            

        }
      

    }
}