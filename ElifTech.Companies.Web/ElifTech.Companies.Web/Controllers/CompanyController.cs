using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ElifTech.Companies.Web.Context;
using ElifTech.Companies.Web.DAL;

namespace ElifTech.Companies.Web.Controllers
{
    [RoutePrefix("companies")]
    public class CompanyController : Controller
    {
        private CompaniesContext db = new CompaniesContext();

        // GET: Company
        //[HttpGet, Route("get/company")]
        public ActionResult Index()
        {
            return View(db.Companies.ToList());
        }

        // GET: Company/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Companie companie = db.Companies.Find(id);
            if (companie == null)
            {
                return HttpNotFound();
            }
            return View(companie);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,parent_id,name,earnings")] Companie companie)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(companie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companie);
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Companie companie = db.Companies.Find(id);
            if (companie == null)
            {
                return HttpNotFound();
            }
            return View(companie);
        }

        // POST: Company/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,parent_id,name,earnings")] Companie companie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companie);
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Companie companie = db.Companies.Find(id);
            if (companie == null)
            {
                return HttpNotFound();
            }
            return View(companie);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Companie companie = db.Companies.Find(id);
            db.Companies.Remove(companie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
