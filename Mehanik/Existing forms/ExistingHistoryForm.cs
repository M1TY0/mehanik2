﻿using Mehanik.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanik
{
    public partial class ExistingHistoryForm : Form
    {
        public ExistingHistoryForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.History.ToList();
            }
        }

        private void ExistingHistoryForm_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.History.ToList();
            }
        }
    }
}
