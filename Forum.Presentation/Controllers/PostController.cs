﻿using domain = Forum.Domain.Entities;
using presentation = Forum.Presentation.Models;
using Forum.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Presentation.Controllers
{
    public class PostController : Controller
    {
        IAppPost appPost;
        IAppAnswerPost appAnswerPost;
        IAppUser appUser;
        public PostController(IAppPost appPost, IAppAnswerPost appAnswerPost, IAppUser appUser)
        {
            this.appPost = appPost;
            this.appAnswerPost = appAnswerPost;
            this.appUser = appUser;
        }

        // GET: Post
        public ActionResult Index()
        {
            var posts = presentation.Post.ParseListDomainToPresentation(appPost.GetMainPost(), Session["UserID"]);
            return View(posts);
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            var user = Session["UserID"];
            if (user == null)
                return RedirectToAction("Login", "User");
            
            return View(new presentation.Post(appPost.GetWithAnswers(id), user, true));
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Details(int id, FormCollection collection)
        {
            try
            {
                //TODO: Use transaction
                domain.Post objCreate = new domain.Post();
                objCreate.CreatedDate = DateTime.Now;
                objCreate.Title = "Answer";
                objCreate.Body = collection.Get("answer");
                objCreate.User = this.appUser.GetById(int.Parse(collection.Get("User.Id")));
                objCreate.TypeOfPost = domain.TypeOfPost.Answer;
                appPost.Add(objCreate);

                domain.Post obj = new domain.Post();
                obj = appPost.GetById(id);
                obj.UpdatedDate = DateTime.Now;

                appAnswerPost.Add(new domain.AnswerPost { CreatedDate = DateTime.Now, Answer = objCreate, MainPost = obj });

                obj.AnswersPost.Add(new domain.AnswerPost { CreatedDate = DateTime.Now, Answer = objCreate, MainPost = obj });

                return View(new presentation.Post(obj));
                
                
            }
            catch (Exception err)
            {
                return View("index");
            }
        }
        // GET: Post/Create
        public ActionResult Create()
        {
            var user = Session["UserID"];
            if (user == null)
                return RedirectToAction("Login", "User");
            
            return View(new presentation.Post(user));
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                domain.Post obj = new domain.Post();
                obj.CreatedDate = DateTime.Now;
                obj.Title = collection.Get("Title");
                obj.Body = collection.Get("Body");
                obj.User = new domain.User { Id = int.Parse(collection.Get("User.Id")) };
                obj.TypeOfPost = domain.TypeOfPost.Main;
                
                appPost.Add(obj);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View(new presentation.Post(appPost.GetById(id), Session["UserID"], true));
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                domain.Post obj = new domain.Post();
                obj = appPost.GetById(id);
                obj.UpdatedDate = DateTime.Now;
                obj.Title = collection.Get("Title");
                obj.Body = collection.Get("Body");                
                appPost.Update(obj);

                return RedirectToAction("Index");
            }
            catch(Exception err)
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            domain.Post obj = new domain.Post();
            obj = appPost.GetById(id);
            appPost.Remove(obj);
            return RedirectToAction("Index");
        }
    }
}
