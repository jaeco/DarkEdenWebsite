using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DarkEdenWebsite.Models;

namespace DarkEdenWebsite.Controllers
{
    public class HomeController : Controller
    {
        private Update update = new Update();
        private List<Update> ups = new List<Update> { new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                  new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,5,3) , Title = "New Changes", Description = "We have changed a few of the layouts on the page. But nothing too crazy has changed. Carry on!", TypeOfUpdate = UpdateType.News},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                  new Update { Date = new DateTime(2015,6,1), Title = "Vamp Marathon", Description = "We are hosting a Vamp Marathon where all vampires in game can earn items based on actions.", TypeOfUpdate = UpdateType.Events},
                                                 };


        // GET: Home
        public ActionResult Index()
        {
            foreach (var i in ups)
            {
                update.TheListOfUpdates.Add(i);
            }

            return View(update);
        }

        public ActionResult Market()
        {
            return View();
        }

        public ActionResult NewsEvents()
        {
            foreach (var i in ups)
            {
                update.TheListOfUpdates.Add(i);
            }
            return View(update);
        }

        public ActionResult Info()
        {
            return View();
        }


    }
}