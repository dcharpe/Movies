using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmThunder.Models;

namespace FilmThunder.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult displaydatabase()
        {
            MovieDBHandler dbhandle = new MovieDBHandler();
            ModelState.Clear();
            return View(dbhandle.GetAllMovie());
        }

       public ActionResult DisplayAll()
        {
            MovieDBHandler dbhandle = new MovieDBHandler();
            ModelState.Clear();
            return View(dbhandle.DisplayAllMovies());
        }
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
