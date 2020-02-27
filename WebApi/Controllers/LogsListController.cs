using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
 
    public class LogsListController : Controller
    {
        Team4RMContext Team4RMEntities = new Team4RMContext();



        // GET: LogsList

        public ActionResult Index()

        {

            return View(Team4RMEntities.Log.ToList());

        }



        // GET: LogsList/Details/5

        public ActionResult Details(int id)

        {

            return View();

        }



        // GET: LogsList/Create

        public ActionResult Create()

        {

            return View();

        }



        // POST: LogsList/Create

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



        // GET: LogsList/Edit/5

        public ActionResult Edit(int id)

        {

            return View();

        }



        // POST: LogsList/Edit/5

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



        // GET: LogsList/Delete/5

        public ActionResult Delete(int id)

        {

            return View();

        }



        // POST: LogsList/Delete/5

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
