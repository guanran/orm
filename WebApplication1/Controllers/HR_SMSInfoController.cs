using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class HR_SMSInfoController : Controller
    {
        private Entities db = new Entities();

        // GET: HR_SMSInfo
        public ActionResult Index()
        {
            return View(db.HR_SMSInfo.ToList());
        }

        // GET: HR_SMSInfo/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_SMSInfo hR_SMSInfo = db.HR_SMSInfo.Find(id);
            if (hR_SMSInfo == null)
            {
                return HttpNotFound();
            }
            return View(hR_SMSInfo);
        }

        // GET: HR_SMSInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HR_SMSInfo/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserCode,Phone,Contents,CacheKey,CreateDate")] HR_SMSInfo hR_SMSInfo)
        {
            if (ModelState.IsValid)
            {
                hR_SMSInfo.ID = Guid.NewGuid();
                db.HR_SMSInfo.Add(hR_SMSInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hR_SMSInfo);
        }

        // GET: HR_SMSInfo/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_SMSInfo hR_SMSInfo = db.HR_SMSInfo.Find(id);
            if (hR_SMSInfo == null)
            {
                return HttpNotFound();
            }
            return View(hR_SMSInfo);
        }

        // POST: HR_SMSInfo/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserCode,Phone,Contents,CacheKey,CreateDate")] HR_SMSInfo hR_SMSInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hR_SMSInfo).State =System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hR_SMSInfo);
        }

        // GET: HR_SMSInfo/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_SMSInfo hR_SMSInfo = db.HR_SMSInfo.Find(id);
            if (hR_SMSInfo == null)
            {
                return HttpNotFound();
            }
            return View(hR_SMSInfo);
        }

        // POST: HR_SMSInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            HR_SMSInfo hR_SMSInfo = db.HR_SMSInfo.Find(id);
            db.HR_SMSInfo.Remove(hR_SMSInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
