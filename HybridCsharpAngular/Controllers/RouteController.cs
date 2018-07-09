using HybridCsharpAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HybridCsharpAngular.Controllers
{
    [RoutePrefix("")]
    public class RouteController : Controller
    {

        string view = "~/angular/index.cshtml";


        [Route("~/")]
        public ActionResult Home()
        {

            var model = new OpenGraph
            {
                title = "Catáloko",
                description = "Teste da home",
                image = "https://assets.nike.com.br/ArquivoExibir/1148275.jpg"
            };

            return View(view, model);
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

            return View(view, model);
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

            return View(view, model);            
        }

        #endregion



    }
}
