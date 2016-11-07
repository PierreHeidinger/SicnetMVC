using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bussinesFrame;
using entityFrame;
using System.Web.Security;

namespace SicnetMVC.Controllers
{

    

    public class HomeController : Controller
    {
        #region "Declaraciones"

        logeo_Bussines logeo = new logeo_Bussines();
        public personal_Entity objPersonal = new personal_Entity();

        #endregion



        //Login


        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Login(personal_Entity personal)
        {
            
            if (ModelState.IsValid)
            {

                try { 
                if (logeo.identificacion(personal.usuario, personal.contrasena).Count > 0)
                {
                    FormsAuthentication.SetAuthCookie(personal.usuario, false);
                    return RedirectToAction("Index", "Home");

                }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("error", ex.Message);
                }

            }

            return View(personal);

        }




        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
