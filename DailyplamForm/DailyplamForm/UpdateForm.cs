﻿using System;
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
    public partial class UpdateForm : Form
    {
        public UpdateForm(int ID)
        {
            InitializeComponent();
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}