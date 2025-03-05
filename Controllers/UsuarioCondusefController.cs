using AssurantAIZ.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssurantAIZ.Controllers
{
    public class UsuarioCondusefController : Controller
    {
        // GET: UsuarioCondusef
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioCondusefModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View(model);
        }


        [HttpGet]
        [Route("Personas")]
        public ActionResult Personas(int draw, int start, int length)
        {
            string searchText = this.HttpContext.Request.QueryString["search[value]"];

            List<Person> personas = new List<Person>();
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                personas.Add(new Person { Name = "Persona " + (i + 1).ToString(), Age = random.Next(15, 90), IsMarried = (i%2) == 0 ? true : false });
            }

            List<Person> filteredList = personas.Where(p => p.Name.Contains(searchText)).ToList();
            
            List<Person> paginatedResults = filteredList.Skip(start).Take(length).ToList();

            return Json(new { draw = draw, data = paginatedResults, recordsTotal = personas.Count, recordsFiltered = filteredList.Count }, JsonRequestBehavior.AllowGet);
        }
    }
}