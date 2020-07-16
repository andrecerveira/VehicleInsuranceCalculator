using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.MVC.ViewModels;

namespace VehicleAssuredCalculator.MVC.Controllers
{
    public class AssuredController : Controller
    {
        private readonly IAssuredAppService _assuredApp;
        public AssuredController(IAssuredAppService assuredApp)
        {
            _assuredApp = assuredApp;
        }

        [HttpGet]
        [Route("Assured/GetMockAssured")]
        public ActionResult GetMockAssured()
        {
            var assured = _assuredApp.GetMockAssured();
            return Json(assured, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            var assuredViewModel = Mapper.Map<IEnumerable<Assured>, IEnumerable<AssuredViewModel>>(_assuredApp.GetAll());
            return View(assuredViewModel);
        } // GET: Assureds/Details/5
        public ActionResult Details(int id)
        {
            var assured = _assuredApp.GetById(id);
            var assuredViewModel = Mapper.Map<Assured, AssuredViewModel>(assured);

            return View(assuredViewModel);
        }

        // GET: Assureds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assureds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssuredViewModel assured)
        {
            if (ModelState.IsValid)
            {
                var assuredDomain = Mapper.Map<AssuredViewModel, Assured>(assured);
                _assuredApp.Add(assuredDomain);

                return RedirectToAction("Index");
            }
            return View(assured);
        }

        // GET: Assureds/Edit/5
        public ActionResult Edit(int id)
        {
            var assured = _assuredApp.GetById(id);
            var assuredViewModel = Mapper.Map<Assured, AssuredViewModel>(assured);

            return View(assuredViewModel);
        }

        // POST: Assureds/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AssuredViewModel assured)
        {
            if (ModelState.IsValid)
            {
                var assuredDomain = Mapper.Map<AssuredViewModel, Assured>(assured);
                _assuredApp.Update(assuredDomain);

                return RedirectToAction("Index");
            }
            return View(assured);
        }

        // GET: Assureds/Delete/5
        public ActionResult Delete(int id)
        {
            var assured = _assuredApp.GetById(id);
            var assuredViewModel = Mapper.Map<Assured, AssuredViewModel>(assured);

            return View(assuredViewModel);
        }

        // POST: Assureds/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var assured = _assuredApp.GetById(id);
            _assuredApp.Remove(assured);
            return RedirectToAction("Index");
        }
    }
}