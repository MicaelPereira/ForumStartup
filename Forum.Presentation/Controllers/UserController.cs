using presentation = Forum.Presentation.Models;
using domain = Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Application.Interface;

namespace Forum.Presentation.Controllers
{
    public class UserController : Controller
    {
        IAppUser appUser;
        public UserController(IAppUser appUser)
        {
            this.appUser = appUser;
        }
        // GET: User
        public ActionResult Index()
        {
            var users = presentation.User.ParseListDomainToPresentation(appUser.GetAll());
            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                domain.User user = new domain.User();
                user.CreatedDate = DateTime.Now;
                user.Name = collection.Get("Name");
                user.Password = collection.Get("Password").ToLower();
                user.Email= collection.Get("Email").ToLower();
                
                appUser.Add(user);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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

        // GET: User/Create
        public ActionResult Login()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            try
            {
                domain.User user = new domain.User();
                user.Password = collection.Get("Password");
                user.Email = collection.Get("Email");

                user = appUser.LoginUser(user.Email, user.Password);
                Session["UserID"] = user.Id;
                //HttpContext.Cache.Insert("UserID", user.Id);
                return RedirectToAction("Index", "Post");
            }
            catch(Exception err)
            {
                return View();
            }
        }
    }
}
