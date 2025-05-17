using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Mehanik.Data;
using Microsoft.EntityFrameworkCore;
using Mehanik.Models;
namespace Mehanik
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var client = new Clients
                {
                    Names = textBox1.Text,
                    PhoneNum = textBox2.Text,
                    CarModel = textBox3.Text,
                    CarNum = textBox4.Text
                };

                db.Clients.Add(client);
                db.SaveChanges();
                LoadClient(); // Refresh DataGridView
            }
        }
        private void LoadClient()
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.Clients.ToList();
            }
        }

    }
}
