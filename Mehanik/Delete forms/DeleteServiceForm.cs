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
    public partial class DeleteServiceForm : Form
    {
        public DeleteServiceForm()
        {
            InitializeComponent();
        }

        private void DeleteServiceForm_Load(object sender, EventArgs e)
        {
            LoadParts();
        }
        private void LoadParts()
        {
            using (var db = new AppDbContext())
            {
                var parts = db.Services
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.Service))
                    .ToList();

                comboBox1.DataSource = new BindingSource(parts, null);
                comboBox1.DisplayMember = "Value"; // Show Part Name
                comboBox1.ValueMember = "Key";     // Store the ID internally
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedPart = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            using (var db = new AppDbContext())
            {
                // Find the part by ID
                var partToDelete = db.Services.FirstOrDefault(p => p.Id == selectedPart.Key);



                // Remove the part
                db.Services.Remove(partToDelete);
                db.SaveChanges();

                MessageBox.Show("Услугата беше изтрита.");

                // Refresh the dropdown and clear input
                LoadParts();

            }
        }
    }
}
