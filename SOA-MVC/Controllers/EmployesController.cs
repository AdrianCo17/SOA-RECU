using Domain;
using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace SOA_MVC.Controllers
{
    public class EmployesController : Controller
    { 

        private readonly IEmploye _employeService;

        public EmployesController(IEmploye employe)
        {
            _employeService = employe;
        }
        public IActionResult Index()
        {
            var lista = _employeService.GetEmployes();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Empleado empleado)
        {
            var result = _employeService.CreateEmployes(empleado);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(empleado);
            }
        }
        [HttpGet]
        public IActionResult Edit(Empleado empleado)
        {
            var result = _employeService.UpdateEmployes(empleado);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(empleado);
            }
        }

        [HttpPost]
        public IActionResult Delete(Empleado empleado)
        {
            var result = _employeService.DeleteEmployes(empleado);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");

            }
        }
    }
}
