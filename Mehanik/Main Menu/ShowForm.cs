using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanik.Main_Menu
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ExistingMechanicsForm existingMechanicsForm= new ExistingMechanicsForm();
            existingMechanicsForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExistingClients existingClients = new ExistingClients();
            existingClients.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExistingServisesForm existingServiseForm = new ExistingServisesForm();
            existingServiseForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExistingPartsForm existingPartsForm = new ExistingPartsForm();
            existingPartsForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExistingHistoryForm existingHistoryForm = new ExistingHistoryForm();
            existingHistoryForm.Show();
        }
    }
}
