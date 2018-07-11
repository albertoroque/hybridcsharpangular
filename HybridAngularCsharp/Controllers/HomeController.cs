using HybridAngularCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HybridAngularCsharp.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        string view = "~/Views/Home/Index.cshtml";


        [Route("~/")]
        public ActionResult Home()
        {

            var model = new OpenGraph
            {
                title = "Catáloko",
                description = "Teste da home",
                image = "https://assets.nike.com.br/ArquivoExibir/1148275.jpg"
            };

            ViewBag.OpenGraph = model;

            return View(view);
        }
      
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("~/e")]
        public ActionResult Error()
        {
            var r = Request.QueryString["aspxerrorpath"];
            return Redirect("#" + r);
        }


        #region Notícia
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("~/n/{title}/{id:long:min(1)}")]
        public ActionResult Noticia(string title, long id)
        {

            var model = new OpenGraph
            {
                title = "Noticia",
                description = "Teste de noticia 2018 será lançado em breve",
                image = "https://assets.nike.com.br/ArquivoExibir/1148275.jpg"
            };

            ViewBag.OpenGraph = model;

            return View(view);
        }

        [Route("~/noticias")]
        public ActionResult Noticias()
        {

            var model = new OpenGraph
            {
                title = "Notícias",
                description = "Lista de notícias",
                image = "https://assets.nike.com.br/ArquivoExibir/1148275.jpg"
            };

            ViewBag.OpenGraph = model;

            return View(view);
        }

        #endregion
    }
}