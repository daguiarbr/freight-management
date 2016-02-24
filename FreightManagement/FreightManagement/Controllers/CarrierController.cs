using Application.Interfaces.Services;
using System.Web.Mvc;

namespace FreightManagement.Controllers
{
    public class CarrierController : Controller
    {
        private readonly IAppCarrierService _appCarrierService;
        private readonly IAppCarrierPhoneNumberService _appCarrierPhoneNumberService;

        public CarrierController(IAppCarrierService appCarrierService, IAppCarrierPhoneNumberService appCarrierPhoneNumberService)
        {
            _appCarrierService = appCarrierService;
            _appCarrierPhoneNumberService = appCarrierPhoneNumberService;
        }

        // GET: Carrier
        public ActionResult Index()
        {
            return View();
        }

        // GET: Carrier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Carrier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carrier/Create
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

        // GET: Carrier/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Carrier/Edit/5
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

        // GET: Carrier/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Carrier/Delete/5
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
