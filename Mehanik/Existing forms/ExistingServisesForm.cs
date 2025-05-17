using Mehanik.Data;
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
    public partial class ExistingServisesForm : Form
    {
        public ExistingServisesForm()
        {
            InitializeComponent();
        }

        private void ExistingServisesForm_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.Services.ToList();
            }
        }
    }
}
