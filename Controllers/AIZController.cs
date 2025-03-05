using AssurantAIZ.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace AssurantAIZ.Controllers
{
    public class AIZController : Controller
    {
        // GET: AIZ
        public ActionResult Index()
        {
            Person person = new Person { Name = "Jose", Age = 25, IsMarried = true };
            return View(person);
        }

        [HttpPost]
        public ActionResult Index(Person model)
        {
            if (this.HttpContext.Request.Files.Count > 0)
            {

                var uploadedFile = this.HttpContext.Request.Files.Get(0);

                if (uploadedFile.ContentLength > 0)
                {
                    if (ModelState.IsValid)
                    {
                        //ViewBag.ResponseJavaScriptFunction = "console.log('Modelo valido');";
                        string responseString = "Es usted una verga bien parada y \nQue chingue a su puta madre el America";
                        byte[] bytes = Encoding.UTF8.GetBytes(responseString);
                        return File(bytes, "text/plain", "textFile1.txt");

                    }
                }  
                else
                {
                    //ViewBag.ResponseJavaScriptFunction = "alert('Por favor seleccione un archivo');";
                }
            }
            
            return View(model);
        }
    }
}