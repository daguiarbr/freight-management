using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using FreightManagement.ViewModels;
using System.Web.Mvc;

namespace FreightManagement.Controllers
{
    [Authorize]
    public class RatingController : Controller
    {
        private readonly IAppRatingService _appRating;
        private readonly IAppCarrierService _appCarrier;
        private readonly IMapper _mapper;

        public RatingController(IAppRatingService appRating, IAppCarrierService appCarrier, IMapper mapper)
        {
            _appRating = appRating;
            _appCarrier = appCarrier;
            _mapper = mapper;
        }

        [Route("Encontrar-Classificação", Name = "RatingIndex")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("{Classificação}/{id:int}", Name = "RatingDetails")]
        public ActionResult Details(int id)
        {
            var carrier = _appRating.GetById(id);
            var carrierViewModel = Mapper.Map<Rating, RatingViewModel>(carrier);

            return View(carrierViewModel);
        }

        [Route("Cadastrar-Classificação", Name = "RatingCreate")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Cadastrar-Classificação", Name = "PostRatingCreate")]
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

        [Route("Editar-Classificação", Name = "RatingEdit")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("Editar-Classificação", Name = "PostRatingEdit")]
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

        [Route("Remover-Classificação", Name = "RatingDelete")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("Remover-Classificação", Name = "PostRatingDelete")]
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
