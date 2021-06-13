using System;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class VentasControl : UserControl
    {
        public VentasControl()
        {
            InitializeComponent();
            scannerPanel.Hide();
            searchPanel.Show();
            multiplePanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchPanel.Hide();
            multiplePanel.Hide();
            scannerPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scannerPanel.Hide();
            searchPanel.Show();
            multiplePanel.Show();
        }
    }
}
