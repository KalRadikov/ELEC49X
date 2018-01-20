using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Capstone490.Models;

namespace Capstone490.Controllers
{
    public class SurveysController : Controller
    {
        private Capstone490Context db = new Capstone490Context();

        // GET: Surveys
        public ActionResult Index()
        {
            return View(db.Surveys.ToList());
        }

        // GET: Surveys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // GET: Surveys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Surveys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SurveyID,Tag,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,Q31,Q32,Q33,Q34,Q35,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                db.Surveys.Add(survey);
                db.SaveChanges();
                return RedirectToAction("OCEAN_Result", new { id = survey.SurveyID });
            }

            return View(survey);
        }

        public ActionResult OCEAN_Result(int id)
        {

            List<object> iList = new List<object>();
            List<int> result = new List<int>();

            var query = db.Surveys.Where(m => m.SurveyID == id).ToList();
            string tag = db.Surveys.Where(m => m.SurveyID == id).Select(c => c.Tag).SingleOrDefault();

            if(tag == null)
            {
                return RedirectToAction("Index");
            }

            iList.Add(query.Select(m => m.Q1).Single());
            iList.Add(query.Select(m => m.Q2).Single());
            iList.Add(query.Select(m => m.Q3).Single());
            iList.Add(query.Select(m => m.Q4).Single());
            iList.Add(query.Select(m => m.Q5).Single());
            iList.Add(query.Select(m => m.Q6).Single());
            iList.Add(query.Select(m => m.Q7).Single());
            iList.Add(query.Select(m => m.Q8).Single());
            iList.Add(query.Select(m => m.Q9).Single());
            iList.Add(query.Select(m => m.Q10).Single());
            iList.Add(query.Select(m => m.Q11).Single());
            iList.Add(query.Select(m => m.Q12).Single());
            iList.Add(query.Select(m => m.Q13).Single());
            iList.Add(query.Select(m => m.Q14).Single());
            iList.Add(query.Select(m => m.Q15).Single());
            iList.Add(query.Select(m => m.Q16).Single());
            iList.Add(query.Select(m => m.Q17).Single());
            iList.Add(query.Select(m => m.Q18).Single());
            iList.Add(query.Select(m => m.Q19).Single());
            iList.Add(query.Select(m => m.Q20).Single());
            iList.Add(query.Select(m => m.Q21).Single());
            iList.Add(query.Select(m => m.Q22).Single());
            iList.Add(query.Select(m => m.Q23).Single());
            iList.Add(query.Select(m => m.Q24).Single());
            iList.Add(query.Select(m => m.Q25).Single());
            iList.Add(query.Select(m => m.Q26).Single());
            iList.Add(query.Select(m => m.Q27).Single());
            iList.Add(query.Select(m => m.Q28).Single());
            iList.Add(query.Select(m => m.Q29).Single());
            iList.Add(query.Select(m => m.Q30).Single());
            iList.Add(query.Select(m => m.Q31).Single());
            iList.Add(query.Select(m => m.Q32).Single());
            iList.Add(query.Select(m => m.Q33).Single());
            iList.Add(query.Select(m => m.Q34).Single());
            iList.Add(query.Select(m => m.Q35).Single());
            iList.Add(query.Select(m => m.Q36).Single());
            iList.Add(query.Select(m => m.Q37).Single());
            iList.Add(query.Select(m => m.Q38).Single());
            iList.Add(query.Select(m => m.Q39).Single());
            iList.Add(query.Select(m => m.Q40).Single());
            iList.Add(query.Select(m => m.Q41).Single());
            iList.Add(query.Select(m => m.Q42).Single());
            iList.Add(query.Select(m => m.Q43).Single());
            iList.Add(query.Select(m => m.Q44).Single());

            List<int> qList = iList.Cast<int>().ToList();

            //Extraversion
            qList[5] = 6 - qList[5];
            qList[20] = 6 - qList[20];
            qList[30] = 6 - qList[30];

            //Agreeableness
            qList[1] = 6 - qList[1];
            qList[11] = 6 - qList[11];
            qList[26] = 6 - qList[26];
            qList[36] = 6 - qList[36];

            //Conscientiousness
            qList[7] = 6 - qList[7];
            qList[17] = 6 - qList[17];
            qList[22] = 6 - qList[22];
            qList[42] = 6 - qList[42];

            //Neuroticism
            qList[8] = 6 - qList[8];
            qList[23] = 6 - qList[23];
            qList[33] = 6 - qList[33];

            //Openness
            qList[34] = 6 - qList[34];
            qList[40] = 6 - qList[40];

            int extraversion = qList[0] + qList[5] + qList[10] + qList[15] + qList[20] + qList[25] + qList[30] + qList[35];
            int agreeableness = qList[1] + qList[6] + qList[11] + qList[16] + qList[21] + qList[26] + qList[31] + qList[36] + qList[41];
            int conscientiousness = qList[2] + qList[7] + qList[12] + qList[17] + qList[22] + qList[27] + qList[32] + qList[37] + qList[42];
            int neuroticism = qList[3] + qList[8] + qList[13] + qList[18] + qList[23] + qList[28] + qList[33] + qList[38];
            int openness = qList[4] + qList[9] + qList[14] + qList[19] + qList[24] + qList[29] + qList[34] + qList[39] + qList[40] + qList[43];

            double Extraversion = extraversion / 8.0;
            double Agreeableness = agreeableness / 9.0;
            double Conscientiousness = conscientiousness / 9.0;
            double Neuroticism = neuroticism / 8.0;
            double Openness = openness / 10.0;

            ViewBag.Extraversion = Extraversion;
            ViewBag.Agreeableness = Agreeableness;
            ViewBag.Conscientiousness = Conscientiousness;
            ViewBag.Neuroticism = Neuroticism;
            ViewBag.Openness = Openness;
            ViewBag.Tag = tag;

            return View();
        }
        // GET: Surveys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SurveyID,Tag,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,Q31,Q32,Q33,Q34,Q35,Q36,Q37,Q38,Q39,Q40,Q41,Q42,Q43,Q44")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(survey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey);
        }

        // GET: Surveys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Survey survey = db.Surveys.Find(id);
            db.Surveys.Remove(survey);
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
