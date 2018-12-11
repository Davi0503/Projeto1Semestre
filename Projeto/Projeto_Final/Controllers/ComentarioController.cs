using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;
using Projeto_Final.util;

namespace Projeto_Final.Controllers {
    public class ComentarioController : Controller {

        [HttpGet]
        public IActionResult Cadastrar () {

            if (null == HttpContext.Session.GetObjectFromJson<UsuarioModel> ("Usuario")) {

                return RedirectToAction ("Login", "Usuario");
            }

            return View ();
        }

        [HttpPost]

        public IActionResult Cadastrar (IFormCollection form) {

            ComentarioModel comentario = new ComentarioModel ();

            comentario.Id = 1;
            comentario.Texto = form["texto"];
            comentario.Aprovado = false;
            comentario.DataCriacao = DateTime.Now;
            comentario.Ativo = true;
            comentario.Usuario = HttpContext.Session.GetObjectFromJson<UsuarioModel> ("Usuario");

            if(string.IsNullOrEmpty(comentario.Texto)){
                
                @ViewBag.Mensagem = "Nenhum comentario foi digitado!";
            }

            ComentarioRepositorio novoComentario = new ComentarioRepositorio ();

            novoComentario.Cadastrar (comentario);

            return RedirectToAction ("Listar");

        }

        public IActionResult Checar () {

            if (HttpContext.Session.GetObjectFromJson<UsuarioModel> ("Usuario").Administrador == true) {

                return RedirectToAction ("ListarAdm");
            }
            return RedirectToAction ("Cadastrar");
        }

        [HttpGet]
        public IActionResult Listar () {

            List<ComentarioModel> comentarios = ComentarioRepositorio.Listar ();

             ViewData["banana"] = comentarios.OrderByDescending (c => c.Id).ToList();

            return View ();

        }

        [HttpGet]
        public IActionResult ListarAdm () {

            List<ComentarioModel> comentarios = ComentarioRepositorio.Listar ();

             ViewData["banana"] = comentarios.OrderByDescending (c => c.Id).ToList();

            return View ();

        }

        [HttpGet]
        public IActionResult Aprovar (int id) {

            ComentarioRepositorio Aprovar = new ComentarioRepositorio ();

            Aprovar.Aprovar (id);

            return RedirectToAction ("ListarAdm");
        }

        [HttpGet]
        public IActionResult Rejeitar (int id) {

            ComentarioRepositorio Rejeitar = new ComentarioRepositorio ();
            Rejeitar.Rejeitar (id);

            return RedirectToAction ("ListarAdm");
        }

        [HttpGet]
        public IActionResult ListarDeslog () {

            List<ComentarioModel> comentarios = ComentarioRepositorio.Listar ();

            

            ViewData["banana"] = comentarios.OrderByDescending (c => c.Id).ToList();

            return View ();

        }

    }
}