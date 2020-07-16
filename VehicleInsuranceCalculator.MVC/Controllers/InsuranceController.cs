using AutoMapper;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.MVC.ViewModels;

namespace VehicleInsuranceCalculator.MVC.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly IInsuranceAppService _insuranceApp;
        private readonly IAssuredAppService _assuredApp;
        private readonly IVehicleAppService _vehicleApp;

        public InsuranceController(IInsuranceAppService insuranceApp, IAssuredAppService assuredApp, IVehicleAppService vehicleApp)
        {
            _insuranceApp = insuranceApp;
            _assuredApp = assuredApp;
            _vehicleApp = vehicleApp;
        }

        [HttpGet]
        [Route("Insurance/CalculateInsurance/{id}")]
        public ActionResult CalculateInsurance(double vehicleValue)
        {
            var insurance = _insuranceApp.CalculateInsurance(vehicleValue);
            return Json(insurance, JsonRequestBehavior.AllowGet);
        }

        // GET: Insurances
        public ActionResult Index()
        {
            var insuranceViewModel = Mapper.Map<IEnumerable<Insurance>, IEnumerable<InsuranceViewModel>>(_insuranceApp.GetAll());
            return View(insuranceViewModel);
        }

        // GET: Insurances
        public ActionResult SearchInsurance(FormCollection form)
        {
            string id = form["InsuranceId"];
            List<Insurance> searchedInsurance = new List<Insurance>();
            try
            {
                Insurance insurance = _insuranceApp.GetById(Convert.ToInt32(id));

                if (insurance != null)
                    searchedInsurance.Add(insurance);

            }
            catch { }

            var insuranceViewModel = Mapper.Map<IEnumerable<Insurance>, IEnumerable<InsuranceViewModel>>(searchedInsurance);
            return View(insuranceViewModel);
        }

        // GET: Insurances/Details/5
        public ActionResult Details(int id)
        {
            var insurance = _insuranceApp.GetById(id);
            var insuranceViewModel = Mapper.Map<Insurance, InsuranceViewModel>(insurance);

            return View(insuranceViewModel);
        }

        // GET: Insurances/Create
        public ActionResult Create()
        {
            ViewBag.AssuredId = new SelectList(_assuredApp.GetAll(), "AssuredId", "Name");
            ViewBag.VehicleId = new SelectList(_vehicleApp.GetAll(), "VehicleId", "Brand");
            return View();
        }

        // POST: Insurances/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InsuranceViewModel insurance)
        {
            if (ModelState.IsValid)
            {
                var insuranceDomain = Mapper.Map<InsuranceViewModel, Insurance>(insurance);
                _insuranceApp.Add(insuranceDomain);

                return RedirectToAction("Index");
            }
            ViewBag.AssuredId = new SelectList(_assuredApp.GetAll(), "AssuredId", "Name", insurance.AssuredId);
            ViewBag.VehicleId = new SelectList(_vehicleApp.GetAll(), "VehicleId", "Brand", insurance.VehicleId);
            return View(insurance);
        }

        // GET: Insurances/Edit/5
        public ActionResult Edit(int id)
        {
            var insurance = _insuranceApp.GetById(id);
            var insuranceViewModel = Mapper.Map<Insurance, InsuranceViewModel>(insurance);
            ViewBag.AssuredId = new SelectList(_assuredApp.GetAll(), "AssuredId", "Name", insuranceViewModel.AssuredId);


            return View(insuranceViewModel);
        }

        // POST: Insurances/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InsuranceViewModel insurance)
        {
            if (ModelState.IsValid)
            {
                var insuranceDomain = Mapper.Map<InsuranceViewModel, Insurance>(insurance);
                _insuranceApp.Update(insuranceDomain);

                return RedirectToAction("Index");
            }
            ViewBag.AssuredId = new SelectList(_assuredApp.GetAll(), "AssuredId", "Name", insurance.AssuredId);
            ViewBag.VehicleId = new SelectList(_vehicleApp.GetAll(), "VehicleId", "Brand", insurance.VehicleId);
            return View(insurance);
        }

        // GET: Insurances/Delete/5
        public ActionResult Delete(int id)
        {
            var insurance = _insuranceApp.GetById(id);
            var insuranceViewModel = Mapper.Map<Insurance, InsuranceViewModel>(insurance);

            return View(insuranceViewModel);
        }

        // POST: Insurances/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var insurance = _insuranceApp.GetById(id);
            _insuranceApp.Remove(insurance);
            return RedirectToAction("Index");
        }
    }
}