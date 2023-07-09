using Domain;
using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace SOA_MVC.Controllers
{
    public class AssetsController : Controller
    {

        private readonly IAsset _assetService;

        public AssetsController(IAsset asset)
        {
            _assetService = asset;
        }
        public IActionResult Index()
        {
            var lista = _assetService.GetAssets();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Activo activo)
        {
            var result = _assetService.CreateAssets(activo);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Failed to create employes");
                return View(result);
            }
        }
    }
}
