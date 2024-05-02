using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiveTeam.Models;

namespace FiveTeam.Controllers
{
    public class ProductController : Controller
    {
        QuanLySanPhamEntities2 db = new QuanLySanPhamEntities2();
        // GET: Produtt
        public ActionResult Product()
        {
            return View(db.ProductFiveTeams.ToList());
        }

        public ActionResult DetailProduct(int id)
        {
            var chitiet = db.ProductFiveTeams.SingleOrDefault(n => n.ID == id);
            if (chitiet == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }

    }
}