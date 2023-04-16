using FirstMVC.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            MvcfirstdbContext db = new MvcfirstdbContext();
            var Student = db.Students.ToList();

            return View(Student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {    

            if(ModelState.IsValid==true)
            {
                MvcfirstdbContext db = new MvcfirstdbContext();
                db.Students.Add(student);
                db.SaveChanges();
            }
            return View(student);
        }
        public IActionResult Delete(int Id)
        {
            MvcfirstdbContext db = new MvcfirstdbContext();
            var student = db.Students.Find(Id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Update(int Id)
        {

            MvcfirstdbContext db = new MvcfirstdbContext();
            var student = db.Students.Find(Id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            MvcfirstdbContext db = new MvcfirstdbContext();
            db.Students.Update(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
