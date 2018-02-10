using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Capstone490.Models;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;
using Capstone490.ViewModels;
using Capstone490.Helpers;

namespace Capstone490.Controllers
{
    public class Interests1Controller : Controller
    {
        private Capstone490Context db = new Capstone490Context();

        public IList<ExcelViewModel> GetInterestsList()
        {

            var employeeList = (from s in db.Surveys
                                join i in db.Interests on s.Tag equals i.Tag
                                select new ExcelViewModel
                                {
                                    Tag = i.Tag,
                                    Q1 = i.Q1,
                                    Q2 = i.Q2,
                                    Q3 = i.Q3,
                                    Q4 = i.Q4,
                                    Q5 = i.Q5,
                                    Q6 = i.Q6,
                                    Q7 = i.Q7,
                                    Q8 = i.Q8,
                                    Q9 = i.Q9,
                                    Q10 = i.Q10,
                                    Q11 = i.Q11,
                                    Q12 = i.Q12,
                                    Q13 = i.Q13,
                                    Q14 = i.Q14,
                                    Q15 = i.Q15,
                                    Q16 = i.Q16,
                                    Q17 = i.Q17,
                                    Q18 = i.Q18,
                                    Q19 = i.Q19,
                                    Q20 = i.Q20,
                                    Q21 = i.Q21,
                                    Q22 = i.Q22,
                                    Q23 = i.Q23,
                                    Q24 = i.Q24,
                                    Q25 = i.Q25,
                                    Q26 = i.Q26,
                                    Q27 = i.Q27,
                                    Q28 = i.Q28,
                                    Q29 = i.Q29,
                                    Q30 = i.Q30,
                                    Q31 = i.Q31,
                                    Q32 = i.Q32,
                                    Q33 = i.Q33,
                                    Q34 = i.Q34,
                                    Q35 = i.Q35,
                                    Q36 = i.Q36,
                                    Q37 = i.Q37,
                                    Q38 = i.Q38,
                                    Q39 = i.Q39,
                                    Q40 = i.Q40,
                                    Q41 = i.Q41,
                                    Q42 = i.Q42,
                                    Q43 = i.Q43,
                                    Q44 = i.Q44,
                                    Q45 = i.Q45,
                                    Q46 = i.Q46,
                                    Q47 = i.Q47,
                                    Q48 = i.Q48,
                                    Q49 = i.Q49,
                                    Q50 = i.Q50,
                                    Q51 = i.Q51,
                                    Q52 = i.Q52,
                                    Q53 = i.Q53,
                                    Q54 = i.Q54,
                                    Q55 = i.Q55,
                                    Q56 = i.Q56,
                                    Q57 = i.Q57,
                                    Q58 = i.Q58,
                                    Q59 = i.Q59,
                                    Q60 = i.Q60
                                }).ToList();

            employeeList = (from e in employeeList
                            select new ExcelViewModel
                            {
                                Openness = OCEAN.GetOpenness(e.Tag),
                                Conscientiousness = OCEAN.GetConscientiousness(e.Tag),
                                Agreeableness = OCEAN.GetAgreeableness(e.Tag),
                                Extraversion = OCEAN.GetExtraversion(e.Tag),
                                Neuroticism = OCEAN.GetNeuroticism(e.Tag),
                                Tag = e.Tag,
                                Q1 = e.Q1,
                                Q2 = e.Q2,
                                Q3 = e.Q3,
                                Q4 = e.Q4,
                                Q5 = e.Q5,
                                Q6 = e.Q6,
                                Q7 = e.Q7,
                                Q8 = e.Q8,
                                Q9 = e.Q9,
                                Q10 = e.Q10,
                                Q11 = e.Q11,
                                Q12 = e.Q12,
                                Q13 = e.Q13,
                                Q14 = e.Q14,
                                Q15 = e.Q15,
                                Q16 = e.Q16,
                                Q17 = e.Q17,
                                Q18 = e.Q18,
                                Q19 = e.Q19,
                                Q20 = e.Q20,
                                Q21 = e.Q21,
                                Q22 = e.Q22,
                                Q23 = e.Q23,
                                Q24 = e.Q24,
                                Q25 = e.Q25,
                                Q26 = e.Q26,
                                Q27 = e.Q27,
                                Q28 = e.Q28,
                                Q29 = e.Q29,
                                Q30 = e.Q30,
                                Q31 = e.Q31,
                                Q32 = e.Q32,
                                Q33 = e.Q33,
                                Q34 = e.Q34,
                                Q35 = e.Q35,
                                Q36 = e.Q36,
                                Q37 = e.Q37,
                                Q38 = e.Q38,
                                Q39 = e.Q39,
                                Q40 = e.Q40,
                                Q41 = e.Q41,
                                Q42 = e.Q42,
                                Q43 = e.Q43,
                                Q44 = e.Q44,
                                Q45 = e.Q45,
                                Q46 = e.Q46,
                                Q47 = e.Q47,
                                Q48 = e.Q48,
                                Q49 = e.Q49,
                                Q50 = e.Q50,
                                Q51 = e.Q51,
                                Q52 = e.Q52,
                                Q53 = e.Q53,
                                Q54 = e.Q54,
                                Q55 = e.Q55,
                                Q56 = e.Q56,
                                Q57 = e.Q57,
                                Q58 = e.Q58,
                                Q59 = e.Q59,
                                Q60 = e.Q60
                            }).ToList();

            return employeeList;
        }
        // GET: Employee 
        public ActionResult ExportToExcel()
        {
            var gv = new GridView();
            gv.DataSource = this.GetInterestsList();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=InterestsData.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
            gv.RenderControl(objHtmlTextWriter);
            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();
            return View();
        }



        // GET: Interests1
        public ActionResult Index()
        {
            return View(db.Interests.ToList());
        }

        // GET: Interests1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interests interests = db.Interests.Find(id);
            if (interests == null)
            {
                return HttpNotFound();
            }
            return View(interests);
        }

        // GET: Interests1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interests1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InterestsID,Tag,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,Q31,Q32,Q33,Q34,Q35,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44,Q45,Q46,Q47,Q48,Q49,Q50,Q51,Q52,Q53,Q54,Q55,Q56,Q57,Q58,Q59,Q60")] Interests interests)
        {
            if (ModelState.IsValid)
            {
                db.Interests.Add(interests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interests);
        }

        // GET: Interests1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interests interests = db.Interests.Find(id);
            if (interests == null)
            {
                return HttpNotFound();
            }
            return View(interests);
        }

        // POST: Interests1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InterestsID,Tag,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,Q31,Q32,Q33,Q34,Q35,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44,Q45,Q46,Q47,Q48,Q49,Q50,Q51,Q52,Q53,Q54,Q55,Q56,Q57,Q58,Q59,Q60")] Interests interests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interests);
        }

        // GET: Interests1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interests interests = db.Interests.Find(id);
            if (interests == null)
            {
                return HttpNotFound();
            }
            return View(interests);
        }

        // POST: Interests1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Interests interests = db.Interests.Find(id);
            db.Interests.Remove(interests);
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
