﻿using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using WheelOfTime.WebApp.Models.BookMods;

namespace WheelOfTime.WebApp.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var svc1 = CreateChapterService();
            var chaps = svc1.GetChaps();
            ViewBag.Chapters = new SelectList(chaps, "Chapters", "ChapTitle");

            var service = CreateBookService();
            var model = service.GetBooks();
            return View(model);
        }

        // Get: Book/Create
        public ActionResult Create()
        {
            return View();
        }
        // Post: Book/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookCreate model)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            };

            var service = CreateBookService();

            if (service.CreateBook(model))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var svc1 = CreateChapterService();
            var chaps = svc1.GetChaps();
            ViewBag.Chapters = new SelectList(chaps, "Chapters", "ChapTitle");

            var svc = CreateBookService();
            var model = svc.GetBookById(id);

            return View(model);
        }
        public BookService CreateBookService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BookService(userId);
            return service;
        }
        //Get: Book/Edit
        public ActionResult Edit(int id)
        {
            var service = CreateBookService();
            var detail = service.GetBookById(id);
            var model = new BookEdit
            {
                BookId = detail.BookId,
                Title = detail.Title,
                PageCount = detail.PageCount,
                Chapters = detail.Chapters
            };
            return View(model);
        }
        //Post: Book/Edit
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BookEdit book)
        {
            if (!ModelState.IsValid)
                return View(book);

            //if (book.BookId != id)
            //{
            //    ModelState.AddModelError("", "Id Mismatch");
            //    return View(book);
            //}

            var service = CreateBookService();
            if (service.UpdateBook(book))
            {
                //TempData["SaveResult"] = "Book Successfully Updated.";
                return RedirectToAction("Index");
            }

            return View(book);
        }
        public ActionResult Delete(int id)
        {
            var svc = CreateBookService();
            var model = svc.GetBookById(id);

            return View(model);
        }
        //Post: Product/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateBookService();

            service.DeleteBook(id);

            //TempData["SaveResult"] = "Book Successfully Deleted";

            return RedirectToAction("Index");
        }
        public ChapterService CreateChapterService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ChapterService(userId);
            return service;
        }
    }
}
