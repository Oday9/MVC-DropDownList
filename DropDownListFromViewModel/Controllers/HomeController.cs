﻿using DropDownListFromViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListFromViewModel.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        // GET: Home
        public ActionResult Index()
        {
            //IsName >> Is name DropDownList
            //typeID >> Is data value
            //typeValue >> Is data text
            ViewBag.IsName = new SelectList(_dbContext.Model2.ToList(), "typeID", "typeValue");
            return View();
        }
        public ActionResult ByViewModel()
        {
            List<ViewModel> items = _dbContext.Model2.Select(m => new ViewModel()
            {
                typeID = m.typeID,
                typeValue = m.typeValue
            }).ToList();

            //IsName >> Is name DropDownList
            //typeID >> Is data value
            //typeValue >> Is data text
            ViewBag.IsName = new SelectList(items, "typeID", "typeValue");
            return View();
        }
    }
}