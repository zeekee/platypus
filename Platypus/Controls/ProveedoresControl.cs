using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class ProveedoresControl : UserControl
    {
        ProveedoresController proveedoresController = new ProveedoresController();

        public ProveedoresControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = proveedoresController.Fill();
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedoresController.Fill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        }
    }
}
