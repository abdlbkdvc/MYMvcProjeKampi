﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContentByHeading(int id)
        {
            var contentValues = cm.GetListByHeadingIdi(id);
            return View(contentValues);
        }
    }
}
