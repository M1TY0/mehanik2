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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mehanik
{
    public partial class DeletePartForm : Form
    {
        public DeletePartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedPart = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            using (var db = new AppDbContext())
            {
                // Find the part by ID
                var partToDelete = db.Parts.FirstOrDefault(p => p.Id == selectedPart.Key);



                // Remove the part
                db.Parts.Remove(partToDelete);
                db.SaveChanges();

                MessageBox.Show("Part deleted successfully.");

                // Refresh the dropdown and clear input
                LoadParts();

            }
        }
        private void LoadParts()
        {
            using (var db = new AppDbContext())
            {
                var parts = db.Parts
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.Part))
                    .ToList();

                comboBox1.DataSource = new BindingSource(parts, null);
                comboBox1.DisplayMember = "Value"; // Show Part Name
                comboBox1.ValueMember = "Key";     // Store the ID internally
            }
        }

        private void DeletePartForm_Load(object sender, EventArgs e)
        {
            LoadParts();
        }
    }
}
