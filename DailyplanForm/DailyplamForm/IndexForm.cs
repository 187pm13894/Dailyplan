using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyplamForm
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            this.Load += IndexForm_Load;
            this.btnAdd.Click += btnAdd_Click;
            this.grdPlan.DoubleClick += grdPlan_DoubleClick;

        }

        void grdPlan_DoubleClick(object sender, EventArgs e)
        {
            
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm();
            AddForm.ShowDialog();
            
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
