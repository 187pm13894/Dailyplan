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
    public partial class IndexForm : Form
    {
        private PlanManagement Business;
        public IndexForm()
        {
            InitializeComponent();
            this.Load += IndexForm_Load;
            this.btnAdd.Click += btnAdd_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdPlan.DoubleClick += grdPlan_DoubleClick;
            this.Business = new PlanManagement();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdPlan.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("ban co muon xoa thong tin nay?", "xac nhan",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var plan = (dplan)this.grdPlan.SelectedRows[0].DataBoundItem;
                    this.Business.DeletePlan(plan.Id);
                    MessageBox.Show("xoa thanh cong");
                    this.LoadAllPlans();
                }
            }
        }

        void grdPlan_DoubleClick(object sender, EventArgs e)
        {
            var plan = (dplan)this.grdPlan.SelectedRows[0].DataBoundItem;
            var updateForm = new UpdateForm(plan.Id);
            updateForm.ShowDialog();
            this.LoadAllPlans();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm();
            AddForm.ShowDialog();
            this.LoadAllPlans();
            
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAllPlans();
        }

        private void LoadAllPlans()
        {
            var plans = this.Business.GetPlans();
            this.grdPlan.DataSource = plans;
        }

        
    }
}
