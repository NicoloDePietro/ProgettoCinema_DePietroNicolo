using Microsoft.AspNetCore.Mvc;
using ProgettoCinema.DataAccess;
using ProgettoCinema.DataAccess.Data;
using ProgettoCinema.DataAccess.Repository.IRepository;
using ProgettoCinema.Models;

namespace ProgettoCinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UtenteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UtenteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //GET
        public IActionResult Index()
        {
            IEnumerable<Utente> objCategoryList = _unitOfWork.Utente.GetAll();
            return View(objCategoryList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Utente obj)
        {
            if (obj.Nome == obj.Cognome.ToString())
            {
                ModelState.AddModelError("CustomError01", $"The name of property {nameof(obj.Cognome)} cannot exactly match the name of property {nameof(obj.Nome)}");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Utente.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Utente created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }


        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDbFirst = _unitOfWork.Utente.GetFirstOrDefault(u => u.IdUtente == id);
            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }
            return View(categoryFromDbFirst);
        }
        //POST 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Utente obj)
        {
            if (obj.Nome == obj.Cognome.ToString())
            {
                ModelState.AddModelError(nameof(obj.Nome), $"The name of property {nameof(obj.Cognome)}cannot exactly match the name of property {nameof(obj.Nome)}");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Utente.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Utente updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }


        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDbFirst = _unitOfWork.Utente.GetFirstOrDefault(u => u.IdUtente == id);
            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }
            return View(categoryFromDbFirst);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id, [Bind("IdUtente")] Utente category)
        {
            if (id != category.IdUtente)
            {
                return NotFound();
            }
            var categoryFromDbFirst = _unitOfWork.Utente.GetFirstOrDefault(u => u.IdUtente == id);
            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }
            _unitOfWork.Utente.Remove(categoryFromDbFirst);
            _unitOfWork.Save();
            TempData["success"] = "Utente deleted successfully";
            return RedirectToAction(nameof(Index));
        }

    }
}
