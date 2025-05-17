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
    public partial class MechanicForm : Form
    {
        public MechanicForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = new AppDbContext())
            {
                var mechanic = new mechanics
                {
                    MechanicName = textBox1.Text,
                    HourPaid = double.Parse(textBox2.Text),

                };

                db.Mechanics.Add(mechanic);
                db.SaveChanges();
                LoadMechanic(); // Refresh DataGridView
            }
        }
        private void LoadMechanic()
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.Mechanics.ToList();
            }
        }
    }
}

