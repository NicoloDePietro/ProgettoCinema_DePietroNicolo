using Microsoft.AspNetCore.Mvc;
using ProgettoCinema.DataAccess;
using ProgettoCinema.DataAccess.Data;
using ProgettoCinema.DataAccess.Repository.IRepository;
using ProgettoCinema.Models;

namespace ProgettoCinema.Controllers
{
    public class UtenteController : Controller
    {
        private readonly IUserRepository _db;
        public UtenteController(IUserRepository db)
        {
            _db = db;
        }

        //GET
        public IActionResult Index()
        {
            IEnumerable<Utente> objCategoryList = _db.GetAll();
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
                _db.Add(obj);
                _db.Save();
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
            var categoryFromDbFirst = _db.GetFirstOrDefault(u => u.IdUtente == id);
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
                _db.Update(obj);
                _db.Save();
                TempData["success"] = "Utente updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken] 
        //public IActionResult Edit(Categoria obj) 
        //{ 
        //    if (obj.Nome == obj.DisplayOrder.ToString()) 
        //    { 
        //        ModelState.AddModelError(nameof(obj.Nome), $"The name of property {nameof(obj.DisplayOrder)} cannot exactly match the name of property {nameof(obj.Nome)}"); 
        //    } 
        //    if (ModelState.IsValid) 
        //    { 
        //        _unitOfWork.Categoria.Update(obj); 
        //        _unitOfWork.Save(); 
        //        TempData["success"] = "Category edited successfully"; 
        //        return RedirectToAction(nameof(Index)); 
        //    } 
        //    return View(obj); 
        //}


        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDbFirst = _db.GetFirstOrDefault(u => u.IdUtente == id);
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
            var categoryFromDbFirst = _db.GetFirstOrDefault(u => u.IdUtente == id);
            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }
            _db.Remove(categoryFromDbFirst);
            _db.Save();
            TempData["success"] = "Utente deleted successfully";
            return RedirectToAction(nameof(Index));
        }

    }
}
