using PennaZoo.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace PennaZoo.Controllers
{
    public class AnimalsController : Controller
    {
        private ZooDatabaseEntities db = new ZooDatabaseEntities();

        // GET: Animals
        public ActionResult Index()
        {
            var animals = db.Animals
                .Include(a => a.Species);
            return View(animals.ToList());
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
