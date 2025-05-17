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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MechanicForm mechanicForm = new MechanicForm();
            mechanicForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartForm partForm = new PartForm();
            partForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }
    }
}
