using Microsoft.AspNetCore.Mvc;
using VivesActivities.Ui.Mvc.Core;
using VivesActivities.Ui.Mvc.Models;

namespace VivesActivities.Ui.Mvc.Controllers
{
    public class VivesActivitiesController : Controller
    {
        private readonly Database _database;
        public VivesActivitiesController(Database database)
        {
            _database = database;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var activities = _database.Activities;
            return View(activities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VivesActivity activity)
        {
            _database.Activities.Add(activity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var activity = _database.Activities
                .FirstOrDefault(a => a.Id == id);

            if (activity is null)
            {
                return RedirectToAction("Index");
            }

            return View(activity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VivesActivity activity)
        {
            var dbActivity = _database.Activities
                .FirstOrDefault(a => a.Id == activity.Id);

            if (dbActivity is null)
            {
                return RedirectToAction("Index");
            }

            dbActivity.Name = activity.Name;
            dbActivity.Description = activity.Description;
            dbActivity.Type = activity.Type;
            dbActivity.Location = activity.Location;

            return RedirectToAction("Index");
        }
    }
}
