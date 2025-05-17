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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteClientForm deleteClientForm = new DeleteClientForm();
            deleteClientForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteMehanikForm deleteMehanikForm = new DeleteMehanikForm();
            deleteMehanikForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteServiceForm deleteServiceForm = new DeleteServiceForm();
            deleteServiceForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletePartForm deletePartForm = new DeletePartForm();
            deletePartForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteHistoryForm deleteHistoryForm = new DeleteHistoryForm();
            deleteHistoryForm.ShowDialog();
        }
    }
}
