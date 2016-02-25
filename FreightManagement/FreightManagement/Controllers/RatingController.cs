using System;
using System.ComponentModel;
using System.Linq;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using FreightManagement.Enums;
using FreightManagement.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace FreightManagement.Controllers
{
    [Authorize]
    public class RatingController : Controller
    {
        private readonly IAppRatingService _appRating;
        private readonly IAppCarrierService _appCarrier;
        private readonly IAppUserService _appUser;
        private readonly IMapper _mapper;

        public RatingController(IAppRatingService appRating, IAppCarrierService appCarrier, IAppUserService appUser, IMapper mapper)
        {
            _appRating = appRating;
            _appCarrier = appCarrier;
            _appUser = appUser;
            _mapper = mapper;
        }

        [Route("Encontrar-Classificacao", Name = "RatingIndex")]
        public ActionResult Index(RatingSearchViewModel filters)
        {
            var rating = _appRating.GetByFilter(filters.CompanyName, filters.RateType);
            var ratingViewModel = _mapper.Map<IEnumerable<Rating>, IEnumerable<RatingViewModel>>(rating);
            return View(ratingViewModel);
        }

        [Route("Cadastrar-Classificacao", Name = "RatingCreate")]
        public ActionResult Create()
        {
            var userId = User.Identity.GetUserId();
            var carrierWithoutRating = _appCarrier.GetAllWithoutRating(userId).ToList();
            if (!carrierWithoutRating.Any())
            {
                return Redirect("/Classificacoes-Finalizadas");
            }

            ViewBag.CarrierId = new SelectList(carrierWithoutRating, "Id", "CompanyName");
            var user = _appUser.GetByStringId(userId);
            var userViewModel = _mapper.Map<User, UserViewModel>(user);

            var ratingViewModel = new RatingViewModel { UserId = userViewModel.UserId, User = userViewModel };
            return View(ratingViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Cadastrar-Classificacao", Name = "PostRatingCreate")]
        public ActionResult Create(RatingViewModel rating)
        {
            if (ModelState.IsValid)
            {
                var ratingDomain = _mapper.Map<RatingViewModel, Rating>(rating);
                _appRating.Add(ratingDomain);

                TempData["msg"] = "Registro inserido com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Falha ao inserir o registro.";
            ViewBag.CarrierId = new SelectList(_appCarrier.GetAll(), "Id", "CompanyName", rating.CarrierId);
            return View(rating);
        }

        [Route("Editar-Classificacao", Name = "RatingEdit")]
        public ActionResult Edit(int id)
        {
            var rating = _appRating.GetById(id);
            var ratingViewModel = _mapper.Map<Rating, RatingViewModel>(rating);
            ViewBag.CarrierId = new SelectList(_appCarrier.GetAll(), "Id", "CompanyName", rating.CarrierId);
            return View(ratingViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Editar-Classificacao", Name = "PostRatingEdit")]
        public ActionResult Edit(int id, RatingViewModel rating)
        {
            if (ModelState.IsValid)
            {
                var ratingDomain = _mapper.Map<RatingViewModel, Rating>(rating);
                _appRating.Update(ratingDomain);

                TempData["msg"] = "Registro alterado com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Falha ao alterar o registro.";
            ViewBag.CarrierId = new SelectList(_appCarrier.GetAll(), "Id", "CompanyName", rating.CarrierId);
            return View(rating);
        }

        [Route("Remover-Classificacao", Name = "RatingDelete")]
        public ActionResult Delete(int id)
        {
            var rating = _appRating.GetById(id);
            var ratingViewModel = _mapper.Map<Rating, RatingViewModel>(rating);
            return View(ratingViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Remover-Classificacao", Name = "PostRatingDelete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var rating = _appRating.GetById(id);
            _appRating.Remove(rating);

            TempData["msg"] = "Registro excluído o registro.";
            return RedirectToAction("Index");
        }

        [Route("Classificacoes-Finalizadas", Name = "RatingFinished")]
        public ActionResult RatingFinished()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult GetFormSearch()
        {
            var vm = new RatingSearchViewModel
            {
                CompanyName = Request.Params["CompanyName"],
                RateType = (!string.IsNullOrEmpty(Request.Params["RateType"])) ? Convert.ToInt32(Request.Params["RateType"]) : (int?)null
            };

            return PartialView("_FormSearchPartial", vm);
        }

        public static string Description(Enum value)
        {
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
