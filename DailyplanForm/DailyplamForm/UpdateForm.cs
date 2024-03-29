﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyplanForm
{
    public partial class UpdateForm : Form
    {
        private int PlanId;
        private PlanManagement Business;
        public UpdateForm(int ID)
        {
            InitializeComponent();
            this.PlanId = ID;
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Business = new PlanManagement();
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
                var plan = this.Business.GetPlan(this.PlanId);
                this.txtPlan.Text = plan.Plan;
                this.rtbNote.Text = plan.Note;
                this.txtTime.Text = plan.Time;
                this.dtpDate.Value = plan.Date;
                this.rdbFinish.Checked = plan.Progress;
                this.rdbUnfinish.Checked = plan.Progress;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var date = this.dtpDate.Value;
            var plan = this.txtPlan.Text;
            var time = this.txtTime.Text;
            var note = this.rtbNote.Text;
            var finish = this.rdbFinish.Checked;
            var female = this.rdbUnfinish.Checked;
            bool progress;
            if (this.rdbFinish.Checked == true)
                progress = true;
            else
                progress = false;
            this.Business.EditPlan(this.PlanId, plan, note, time, progress, date);
            MessageBox.Show("thay doi thanh cong");
            this.Close();
        }

    }
}
