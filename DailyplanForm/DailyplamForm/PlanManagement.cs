using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyplanForm
{
    class PlanManagement
    {
        public dplan[] GetPlans()
        {
           var db = new PlanEntities();
           return db.dplans.ToArray();
        }

        public void AddPlan(string plan, string note, string time, bool progress, DateTime date)
        {
            var newPlan = new dplan();
            newPlan.Note = note;
            newPlan.Plan = plan;
            newPlan.Time = time;
            newPlan.Progress = progress;
            newPlan.Date = date;

            var db = new PlanEntities();
            db.dplans.Add(newPlan);
            db.SaveChanges();   
        }

        public void EditPlan(int id, string note, string plan, string time, bool progress, DateTime date)
        {
            var db = new PlanEntities();
            var oldPlan = db.dplans.Find(id);

            oldPlan.Date = date;
            oldPlan.Note = note;
            oldPlan.Plan = plan;
            oldPlan.Time = time;
            oldPlan.Progress = progress;

            db.Entry(oldPlan).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeletePlan(int id)
        {
            var db = new PlanEntities();
            var plan = db.dplans.Find(id);
            db.dplans.Remove(plan);
            db.SaveChanges();
        }

        public dplan GetPlan(int id)
        {
            var db = new PlanEntities();
            return db.dplans.Find(id);
        }
    }
}
