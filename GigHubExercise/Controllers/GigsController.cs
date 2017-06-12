using GigHubExercise.Models;
using GigHubExercise.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GigHubExercise.Controllers
{
    public class GigsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }


        /// <summary>
        /// Create a new Gig
        /// </summary>
        /// <returns>GigFormViewModel</returns>
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}