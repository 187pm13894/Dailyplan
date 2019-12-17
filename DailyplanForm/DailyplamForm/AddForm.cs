using System;
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
    public partial class AddForm : Form
    {
        private PlanManagement Business;
        public AddForm()
        {
            InitializeComponent();
            this.Business = new PlanManagement();
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var plan = this.txtPlan.Text;
            var time = this.txtTime.Text;
            var note = this.rtbNote.Text;
            var date = this.dtpDate.Value;
            var progress = false;
            this.Business.AddPlan(note, plan, time, progress, date);
            MessageBox.Show("them thanh cong");
            this.Close();
        }

    }
}
