﻿using Application.Interfaces.Services;
using System.Web.Mvc;

namespace FreightManagement.Controllers
{
    public class RatingController : Controller
    {
        private readonly IAppCarrierService _appCarrierService;
        private readonly IAppRatingService _appRatingService;

        public RatingController(IAppCarrierService appCarrierService, IAppRatingService appRatingService)
        {
            _appCarrierService = appCarrierService;
            _appRatingService = appRatingService;
        }

        // GET: Rating
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rating/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rating/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rating/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rating/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rating/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rating/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rating/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
