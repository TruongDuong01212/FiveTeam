using FiveTeam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;



namespace FiveTeam.Controllers
{
    public class BlogsController : Controller
    {
        QuanLySanPhamEntities2 db = new QuanLySanPhamEntities2();   
        /*thêm sản phẩm vào giao diện Product*/
        public ActionResult Blogs()
        {
            return View(db.BlogsFiveTeams.ToList());
        }
        public ActionResult DetailBlogs(int id)
        {
            var chitiet = db.BlogsFiveTeams.SingleOrDefault(n => n.ID == id);
            if (chitiet == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }


    }
}
