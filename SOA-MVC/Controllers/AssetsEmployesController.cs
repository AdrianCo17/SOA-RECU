using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace SOA_MVC.Controllers
{
    public class AssetsEmployesController : Controller
    {
        private readonly IAssetEmploye _assetEmployeService;
        private readonly IAsset _assetService;
        private readonly IEmploye _employeService;


        public AssetsEmployesController(IAssetEmploye assetEmploye, IAsset asset, IEmploye employe)
        {
            _assetEmployeService = assetEmploye;
            _assetService = asset;
            _employeService = employe;
        }
        public IActionResult Index()
        {
            var lista = _assetEmployeService.GetAssetsEmployes();
            return View(lista);
        }

        public IActionResult Create()
        {
            var empleados = _employeService.GetEmployes();
            var activos = _assetService.GetAssets();

            ViewBag.Empleados = empleados;
            ViewBag.Activos = activos;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Activo_Empleado activoEmpleado)
        {
            var result = _assetEmployeService.CreateAssetsEmployes(activoEmpleado);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(activoEmpleado);
            }
        }

        public IActionResult Edit(int id)
        {

            Activo_Empleado activoEmpleado = _assetEmployeService.GetAssetEmploye(id);
            return View(activoEmpleado);
        }
        [HttpPost]
        public IActionResult Edit(Activo_Empleado activoEmpleado)
        {
            var result = _assetEmployeService.UpdateAssetsEmployes(activoEmpleado);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(activoEmpleado);
            }
        }

        [HttpPost]
        public IActionResult Delete(Activo_Empleado activoEmpleado)
        {
            var result = _assetEmployeService.DeleteAssetsEmployes(activoEmpleado);

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
