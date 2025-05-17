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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a part.");
                return;
            }
            var selectedPart = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            double partPrice = 0;
           
           
            using (var db = new AppDbContext())
            {
                double totalPrice =0;
                var partDetails = db.Parts.FirstOrDefault(p => p.Id == selectedPart.Key);
                if (selectedPart.Key != -1) // If not "без част", fetch actual price
                {
                    //var partDetails = db.Parts.FirstOrDefault(p => p.Id == selectedPart.Key);
                    totalPrice = int.Parse(textBox3.Text) + partDetails.Price;
                    partPrice = partDetails.Price;
                }
                else
                {
                    if (partDetails == null)
                    {
                        //partPrice = partDetails.Price;
                        totalPrice = int.Parse(textBox3.Text);
                    }
                    
                }
                var service = new Services
                {
                    Service = textBox1.Text,
                    Part = selectedPart.Value,
                    WholePrice = totalPrice,
                    ServicesPrice = int.Parse(textBox3.Text),
                    PartPrice = partPrice
                };

                db.Services.Add(service);
                db.SaveChanges();
                LoadServices(); // Refresh DataGridView
            }
        }
        private void LoadServices()
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.Services.ToList();
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            LoadParts();
        }
        private void LoadParts()
        {
            using (var db = new AppDbContext())
            {
                var parts = db.Parts
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.Part))
                    .ToList();
                parts.Insert(0, new KeyValuePair<int, string>(-1, "без част"));
                comboBox1.DataSource = new BindingSource(parts, null);
                comboBox1.DisplayMember = "Value"; // Show Part Name
                comboBox1.ValueMember = "Key";     // Store the ID internally
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
