using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.MVC.ViewModels;

namespace VehicleVehicleCalculator.MVC.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicleAppService _vehicleApp;
        public VehiclesController(IVehicleAppService vehicleApp)
        {
            _vehicleApp = vehicleApp;
        }

        public ActionResult Index()
        {
            var vehicleViewModel = Mapper.Map<IEnumerable<Vehicle>, IEnumerable<VehicleViewModel>>(_vehicleApp.GetAll());
            return View(vehicleViewModel);
        } // GET: Vehicles/Details/5
        public ActionResult Details(int id)
        {
            var vehicle = _vehicleApp.GetById(id);
            var vehicleViewModel = Mapper.Map<Vehicle, VehicleViewModel>(vehicle);

            return View(vehicleViewModel);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehicleViewModel vehicle)
        {
            if (ModelState.IsValid)
            {
                var vehicleDomain = Mapper.Map<VehicleViewModel, Vehicle>(vehicle);
                _vehicleApp.Add(vehicleDomain);

                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int id)
        {
            var vehicle = _vehicleApp.GetById(id);
            var vehicleViewModel = Mapper.Map<Vehicle, VehicleViewModel>(vehicle);

            return View(vehicleViewModel);
        }

        // POST: Vehicles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VehicleViewModel vehicle)
        {
            if (ModelState.IsValid)
            {
                var vehicleDomain = Mapper.Map<VehicleViewModel, Vehicle>(vehicle);
                _vehicleApp.Update(vehicleDomain);

                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(int id)
        {
            var vehicle = _vehicleApp.GetById(id);
            var vehicleViewModel = Mapper.Map<Vehicle, VehicleViewModel>(vehicle);

            return View(vehicleViewModel);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var vehicle = _vehicleApp.GetById(id);
            _vehicleApp.Remove(vehicle);
            return RedirectToAction("Index");
        }
    }
}