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
           var db = new PlansEntities();
           return db.dplans.ToArray();
        }

        public void AddPlan(string Plan, string Note, int Time, bool Progress, DateTime Date)
        {
            var newPlan = new dplan();
            newPlan.note = Note;
            newPlan.plan = Plan;
            newPlan.time = Time;
            newPlan.progress = Progress;
            newPlan.date = Date;

            var db = new PlansEntities();
            db.dplans.Add(newPlan);
            db.SaveChanges();   
        }

        public void EditPlan(int id, string Note, string Plan, int Time, bool Progress, DateTime Date)
        {
            var db = new PlansEntities();
            var oldPlan = db.dplans.Find(id);

            oldPlan.date = Date;
            oldPlan.note = Note;
            oldPlan.plan = Plan;
            oldPlan.time = Time;
            oldPlan.progress = Progress;

            db.Entry(oldPlan).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeletePlan(int id)
        {
            var db = new PlansEntities();
            var plan = db.dplans.Find(id);
            db.dplans.Remove(plan);
            db.SaveChanges();
        }

        public dplan GetPlan(int id)
        {
            var db = new PlansEntities();
            return db.dplans.Find(id);
        }
    }
}
