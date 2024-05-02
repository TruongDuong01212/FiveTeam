using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FiveTeam.Models;


namespace FiveTeam.Controllers
{
    public class CategoriesController : Controller
    {
        QuanLySanPhamEntities2 db = new QuanLySanPhamEntities2();

        // GET: Categories
        public ActionResult Categories()
        {
            return View(db.CategoriesFiveTeams.ToList());
        }
        public ActionResult DetailCategories(int id)
        {
            var chitiet = db.CategoriesFiveTeams.SingleOrDefault(n => n.ID == id);
            if (chitiet == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }

    }
}