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
    public partial class DeleteMehanikForm : Form
    {
        public DeleteMehanikForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void LoadMehanik()
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



        private void DeleteMehanikForm_Load_1(object sender, EventArgs e)
        {
            LoadMehanik();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var selectedMehanik = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            using (var db = new AppDbContext())
            {
                // Find the part by ID
                var mehanikToDelete = db.Mechanics.FirstOrDefault(p => p.Id == selectedMehanik.Key);



                // Remove the part
                db.Mechanics.Remove(mehanikToDelete);
                db.SaveChanges();

                MessageBox.Show("Механикът беше изтрит.");

                // Refresh the dropdown and clear input
                LoadMehanik();

            }
        }
    }
}
