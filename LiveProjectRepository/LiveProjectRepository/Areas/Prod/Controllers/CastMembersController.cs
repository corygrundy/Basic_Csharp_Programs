using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheatreCMS3.Areas.Prod.Models;
using TheatreCMS3.Models;

namespace LiveProjectRepository.Areas.Prod.Controllers
{
    public class CastMembersController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // This part of the project was mostly built by running an separate process to scaffold extra utility into the production pages allowing Cast members to have a database and to allow a viewer to view the details, and an admin to create, delete, edit and view the various cast members of a production.
        // GET: Prod/CastMembers
        public ActionResult Index()
        {
            return View(db.CastMembers.ToList());
        }

        // GET: Prod/CastMembers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CastMember castMember = db.CastMembers.Find(id); /*This was added by me to ensure errors would keep users on the wepage and not cause a fatal crash.*/
            if (castMember == null)
            {
                return HttpNotFound();
            }
            return View(castMember);

        // POST: Prod/CastMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID, Name, YearJoined, MainRole, Bio, Photo, CurrentMember, Character, CastYearLeft, DebutYear")] CastMember castMember, HttpPostedFileBase postedFile)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }
            castMember.Photo = bytes;

            if (ModelState.IsValid)
            {
                db.CastMembers.Add(castMember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(castMember);
        }

        // POST: Prod/CastMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, Name, YearJoined, MainRole, Bio, Photo, CurrentMember, Character, CastYearLeft, DebutYear")] CastMember castMember, HttpPostedFileBase postedFile)
        {
            if (postedFile == null)
            {
                var castM = db.CastMembers.AsNoTracking().First(cast => castMember.ID == cast.ID);
                castMember.Photo = castM.Photo;
            }
            else
            {
                byte[] bytes;
                using (BinaryReader br = new BinaryReader(postedFile.InputStream))
                {
                    bytes = br.ReadBytes(postedFile.ContentLength);
                }
                castMember.Photo = bytes;
            }

            if (ModelState.IsValid)
            {
                db.Entry(castMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(castMember);
        }
    }
}