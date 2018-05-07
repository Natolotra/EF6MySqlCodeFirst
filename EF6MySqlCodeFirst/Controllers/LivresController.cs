using EF6MySqlCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF6MySqlCodeFirst.Controllers
{
    public class LivresController : Controller
    {
        // GET: Livres
        public ActionResult Index()
        {
            using (var context = new MyContext())
            {
                var livres = context.Livres.ToList();
                return View(livres);
            }
        }
    }
}