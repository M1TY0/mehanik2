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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mehanik
{
    public partial class DeleteHistoryForm : Form
    {
        public DeleteHistoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var selectedHistory= (KeyValuePair<int, string>)comboBox1.SelectedItem;
            using (var db = new AppDbContext())
            {
                // Find the part by ID
                var historyToDelete = db.History.FirstOrDefault(p => p.Id == selectedHistory.Key);



                // Remove the part
                db.History.Remove(historyToDelete);
                db.SaveChanges();

                MessageBox.Show("Работата беше изтрита.");

                // Refresh the dropdown and clear input
                LoadHistory();

            }
        }
        private void LoadHistory()
        {
            using (var db = new AppDbContext())
            {
                var history = db.History
                    .Select(p => new KeyValuePair<int, int>(p.Id, p.Id))
                    .ToList();

                comboBox1.DataSource = new BindingSource(history, null);
                comboBox1.DisplayMember = "Value"; // Show Part Name
                comboBox1.ValueMember = "Key";     // Store the ID internally
            }
        }
        private void DeleteHistoryForm_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
