using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using FreightManagement.ViewModels;
using System.Web.Mvc;

namespace FreightManagement.Controllers
{
    [Authorize]
    public class CarrierPhoneNumberController : Controller
    {
        private readonly IAppCarrierService _appCarrier;
        private readonly IAppCarrierPhoneNumberService _appCarrierPhoneNumber;
        private readonly IMapper _mapper;

        public CarrierPhoneNumberController(IAppCarrierService appCarrier, IAppCarrierPhoneNumberService appCarrierPhoneNumber, IMapper mapper)
        {
            _appCarrier = appCarrier;
            _appCarrierPhoneNumber = appCarrierPhoneNumber;
            _mapper = mapper;
        }

        [Route("Cadastrar-Telefone", Name = "CarrierPhoneNumberCreate")]
        public ActionResult Create(int carrierId)
        {
            var carrier = _appCarrier.GetById(carrierId);
            if (carrier.Id == 0)
            {
                return Redirect("/Encontrar-Transportadora");
            }

            var carrierViewModel = _mapper.Map<Carrier, CarrierViewModel>(carrier);
            var carrierPhoneNumberViewModel = new CarrierPhoneNumberViewModel { CarrierId = carrierId, Carrier = carrierViewModel };
            return View(carrierPhoneNumberViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Cadastrar-Telefone", Name = "PostCarrierPhoneNumberCreate")]
        public ActionResult Create(CarrierPhoneNumberViewModel carrierPhoneNumber)
        {
            if (ModelState.IsValid)
            {
                var carrierPhoneNumberDomain = _mapper.Map<CarrierPhoneNumberViewModel, CarrierPhoneNumber>(carrierPhoneNumber);
                _appCarrierPhoneNumber.Add(carrierPhoneNumberDomain);

                return Redirect(string.Format("/Transportadora?id={0}", carrierPhoneNumber.CarrierId));
            }

            return View(carrierPhoneNumber);
        }

        [Route("Editar-Telefone", Name = "CarrierPhoneNumberEdit")]
        public ActionResult Edit(int id)
        {
            var carrierPhoneNumber = _appCarrierPhoneNumber.GetById(id);
            var carrierPhoneNumberViewModel = _mapper.Map<CarrierPhoneNumber, CarrierPhoneNumberViewModel>(carrierPhoneNumber);
            return View(carrierPhoneNumberViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Editar-Telefone", Name = "PostCarrierPhoneNumberEdit")]
        public ActionResult Edit(int id, CarrierPhoneNumberViewModel carrierPhoneNumber)
        {
            if (ModelState.IsValid)
            {
                var carrierPhoneNumberDomain = _mapper.Map<CarrierPhoneNumberViewModel, CarrierPhoneNumber>(carrierPhoneNumber);
                _appCarrierPhoneNumber.Update(carrierPhoneNumberDomain);

                return Redirect(string.Format("/Transportadora?id={0}", carrierPhoneNumber.CarrierId));
            }

            return View(carrierPhoneNumber);
        }

        [Route("Remover-Telefone", Name = "CarrierPhoneNumberDelete")]
        public ActionResult Delete(int id)
        {
            var carrierPhoneNumber = _appCarrierPhoneNumber.GetById(id);
            var carrierPhoneNumberViewModel = _mapper.Map<CarrierPhoneNumber, CarrierPhoneNumberViewModel>(carrierPhoneNumber);

            return View(carrierPhoneNumberViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Remover-Telefone", Name = "PostCarrierPhoneNumberDelete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var carrierPhoneNumber = _appCarrierPhoneNumber.GetById(id);
            _appCarrierPhoneNumber.Remove(carrierPhoneNumber);

            return Redirect(string.Format("/Transportadora?id={0}", carrierPhoneNumber.CarrierId));
        }

    }
}
