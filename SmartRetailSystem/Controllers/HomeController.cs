using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartRetailSystem.Models;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SmartRetailSystem.Controllers
{
    public class HomeController : Controller
    {
        //private readonly BusinessLayer.BusinessFacade businessFacade = new BusinessLayer.BusinessFacade();
        private SRSDatabaseEntities db = new SRSDatabaseEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
          return View();
        }
        public ActionResult Shops(String searchString)
        {
            using (var shops = new SRSDatabaseEntities())
            {
                return View(shops.Shops.ToList());
            }
        }

        public ActionResult Items()
        {
            //Product prod = new Product();
            using (var items = new SRSDatabaseEntities())
            {
                return View(items.Products.ToList());
            }
        }

        //public ActionResult SingleShopItems(int? shoid, int? itid)
        //{
           
        //        var viewModel = new SRSDatabaseEntities();
        //        viewModel.Shops = db.Products
        //            .Include(i => i.Shops)
        //            .Include(i => i.Shops.Select(c => c.))
        //            .OrderBy(i => i.);

        //        if (id != null)
        //        {
        //            ViewBag.InstructorID = id.Value;
        //            viewModel.Courses = viewModel.Instructors.Where(
        //                i => i.ID == id.Value).Single().Courses;
        //        }

        //        if (courseID != null)
        //        {
        //            ViewBag.CourseID = courseID.Value;
        //            viewModel.Enrollments = viewModel.Courses.Where(
        //                x => x.CourseID == courseID).Single().Enrollments;
        //        }

        //        return View(viewModel);
        //    }
        //}
        public ActionResult Specials()
        {
            using (var itemsSpecial = new SRSDatabaseEntities())
            {
                return View(itemsSpecial.Shops.ToList());
            }
        }
        public ActionResult SearchFilter(string searchString)
        {
            SRSDatabaseEntities db = new SRSDatabaseEntities();

            return View(db.Shops.Where(x => x.ShopName.StartsWith(searchString) || searchString == null ).ToList());
        }

    }
}