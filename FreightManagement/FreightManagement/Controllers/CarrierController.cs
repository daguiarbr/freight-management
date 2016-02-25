using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using FreightManagement.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FreightManagement.Controllers
{
    [Authorize]
    public class CarrierController : Controller
    {
        private readonly IAppCarrierService _appCarrier;
        private readonly IMapper _mapper;

        public CarrierController(IAppCarrierService appCarrier, IMapper mapper)
        {
            _appCarrier = appCarrier;
            _mapper = mapper;
        }

        [Route("Encontrar-Transportadora", Name = "CarrierIndex")]
        public ActionResult Index(CarrierSearchViewModel filters)
        {
            var carrierViewModel = _mapper.Map<IEnumerable<Carrier>, IEnumerable<CarrierViewModel>>(_appCarrier.GetByFilter(filters.CompanyName, filters.Cnpj));
            return View(carrierViewModel);
        }

        [Route("Transportadora", Name = "CarrierDetails")]
        public ActionResult Details(int id)
        {
            var carrier = _appCarrier.GetById(id);
            var carrierViewModel = _mapper.Map<Carrier, CarrierViewModel>(carrier);

            return View(carrierViewModel);
        }

        [Route("Cadastrar-Transportadora", Name = "CarrierCreate")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Cadastrar-Transportadora", Name = "PostCarrierCreate")]
        public ActionResult Create(CarrierViewModel carrier)
        {
            if (ModelState.IsValid)
            {
                var carrierDomain = _mapper.Map<CarrierViewModel, Carrier>(carrier);
                _appCarrier.Add(carrierDomain);

                TempData["msg"] = "Registro inserido com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Falha ao inserir o registro.";
            return View(carrier);
        }

        [Route("Editar-Transportadora", Name = "CarrierEdit")]
        public ActionResult Edit(int id)
        {
            var carrier = _appCarrier.GetById(id);
            var carrierViewModel = _mapper.Map<Carrier, CarrierViewModel>(carrier);
            return View(carrierViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Editar-Transportadora", Name = "PostCarrierEdit")]
        public ActionResult Edit(int id, CarrierViewModel carrier)
        {
            if (ModelState.IsValid)
            {
                var carrierDomain = _mapper.Map<CarrierViewModel, Carrier>(carrier);
                _appCarrier.Update(carrierDomain);

                TempData["msg"] = "Registro alterado com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Falha ao alterar o registro.";
            return View(carrier);
        }

        [Route("Remover-Transportadora", Name = "CarrierDelete")]
        public ActionResult Delete(int id)
        {
            var carrier = _appCarrier.GetById(id);
            var carrierViewModel = _mapper.Map<Carrier, CarrierViewModel>(carrier);

            return View(carrierViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Remover-Transportadora", Name = "PostCarrierDelete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var carrier = _appCarrier.GetById(id);
            _appCarrier.Remove(carrier);

            TempData["msg"] = "Registro excluído o registro.";
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public PartialViewResult GetFormSearch()
        {
            var vm = new CarrierSearchViewModel
            {
                CompanyName = Request.Params["CompanyName"],
                Cnpj = Request.Params["Cnpj"]
            };

            return PartialView("_FormSearchPartial", vm);
        }
    }
}
