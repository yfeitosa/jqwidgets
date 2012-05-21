using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demonstracao1.Models;

namespace Demonstracao1.Controllers
{
    public class LinguagemController : Controller
    {
        /// <summary>
        /// Esse método simulei o retorno de uma tabela (4 REGISTROS)
        /// E CARREGUEI OS REGISTROS DENTRO DA COLEÇÃO DO MODELO (Linguagem)
        /// </summary>
        /// <returns></returns>
        private List<Linguagem> CarregarLinguagens()
        {
            return new List<Linguagem>()
            {
                new Linguagem { Codigo = 1, Nome = "Visual C#"},
                new Linguagem { Codigo = 2, Nome = "VB.NET"},
                new Linguagem { Codigo = 3, Nome = "IronRuby"},
                new Linguagem { Codigo = 4, Nome = "IronPython"}
            };
        }

        /// <summary>
        /// LOAD DA PÁGINA
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Carreguei a COLEÇÃO DE REGISTROS DENTRO DO OBJETO IENUMERABLE<Linguagem>
            List<Linguagem> lstLinguagens = this.CarregarLinguagens();

            //Carreguei a PÁGINA(PASSANDO O PARAMETRO DE ENTRADA QUE ELA ESTA ESPERANDO)
            return View(lstLinguagens);
        }

        public ActionResult Editar(Int32 Codigo)
        {
            Linguagem LinguagemSelecionada = 
            this.CarregarLinguagens().Where(x => x.Codigo == Codigo).First();

            return View(LinguagemSelecionada);
        }

        [HttpPost]
        public ActionResult Editar(Linguagem Modelo)
        {
            List<Linguagem> lstLinguagens = this.CarregarLinguagens();

            return View("Index", lstLinguagens);
        }
    }
}
