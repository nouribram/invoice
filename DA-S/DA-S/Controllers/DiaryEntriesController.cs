using DA_S.Data;
using DA_S.Models;
using Microsoft.AspNetCore.Mvc;

namespace DA_S.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();

       
            return View(objDiaryEntryList);
        }

        public IActionResult Create() {
          return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry Obj)
        {
            if(Obj != null && Obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short here");
            }
            if (ModelState.IsValid) 
            {
                _db.DiaryEntries.Add(Obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
             
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int ? id) 
        {
            if(id == null || id = 0)
            {
                return NotFound();
            }

            DiaryEntry ? diaryEntry = _db.diaryEntries.Find(id);
           
            if(diaryEntry == null) 
            { 
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry Obj)
        {
            if (Obj != null && Obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short here");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(Obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id = 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.diaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }
    }
}
