using Mehanik.Data;
using Mehanik.Models;
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
    public partial class PartForm : Form
    {
        public PartForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = new AppDbContext())
            {
                var part = new Parts
                {
                    Part = textBox1.Text,
                    Price = double.Parse(textBox2.Text),
                    Stock = int.Parse(textBox3.Text)
                };

                db.Parts.Add(part);
                db.SaveChanges();
                LoadParts(); // Refresh DataGridView
            }
        }
        private void LoadParts()
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.Parts.ToList();
            }
        }
    }
}
