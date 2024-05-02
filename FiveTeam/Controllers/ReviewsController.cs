using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiveTeam.Models;

namespace FiveTeam.Controllers
{
    public class ReviewsController : Controller
    {
        QuanLySanPhamEntities2 db = new QuanLySanPhamEntities2();
        // GET: Revieww
        public ActionResult Reviews()
        {
            return View(db.ReviewFiveTeams.ToList());
        }
    }

}