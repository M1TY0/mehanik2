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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedMechanik = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var selectedService = (KeyValuePair<int, string>)comboBox2.SelectedItem;
            var selectedClient = (KeyValuePair<int, string>)comboBox3.SelectedItem;

            using (var db = new AppDbContext())
            {
                var serviceDetails = db.Services.FirstOrDefault(p => p.Id == selectedService.Key);
                var mechanikDetails = db.Mechanics.FirstOrDefault(p => p.Id == selectedMechanik.Key);
                var clientDetails = db.Clients.FirstOrDefault(p => p.Id == selectedClient.Key);
                double totalPrice = serviceDetails.WholePrice + mechanikDetails.HourPaid * (int.Parse(textBox1.Text));
                var history = new History
                {
                    Hours = double.Parse(textBox1.Text),
                    Mechanic = mechanikDetails.MechanicName,
                    Service = serviceDetails.Service,
                    Client = clientDetails.Names,
                    Price = totalPrice,
                    ServicePrice = serviceDetails.ServicesPrice,
                    PartPrice = serviceDetails.PartPrice,
                    MechanicPrice = mechanikDetails.HourPaid * (int.Parse(textBox1.Text))
                };

                db.History.Add(history);
                db.SaveChanges();
                LoadHistory(); // Refresh DataGridView
            }
        }
        private void LoadHistory()
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.DataSource = db.History.ToList();
            }
        }
        private void LoadMechanik()
        {
            using (var db = new AppDbContext())
            {
                var mechanik = db.Mechanics
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.MechanicName))
                    .ToList();

                comboBox1.DataSource = new BindingSource(mechanik, null);
                comboBox1.DisplayMember = "Value"; // Show Part Name
                comboBox1.ValueMember = "Key";     // Store the ID internally
            }
        }
        private void LoadServices()
        {
            using (var db = new AppDbContext())
            {
                var services = db.Services
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.Service))
                    .ToList();

                comboBox2.DataSource = new BindingSource(services, null);
                comboBox2.DisplayMember = "Value"; // Show Part Name
                comboBox2.ValueMember = "Key";     // Store the ID internally
            }
        }
        private void LoadClients()
        {
            using (var db = new AppDbContext())
            {
                var clients = db.Clients
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.Names))
                    .ToList();

                comboBox3.DataSource = new BindingSource(clients, null);
                comboBox3.DisplayMember = "Value"; // Show Part Name
                comboBox3.ValueMember = "Key";     // Store the ID internally
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            LoadMechanik();
            LoadServices();
            LoadClients();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}