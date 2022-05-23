using System;
using System.Windows.Forms;

namespace Projecte2021
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SolidarityAtHome newMDIChild = new SolidarityAtHome
            {
                // Set the Parent Form of the Child window.
                MdiParent = this
            };
            // Display the new form.
            newMDIChild.Show();
        }

        private void informe1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CR_Report1 newMDIChild = new CR_Report1
            {
                // Set the Parent Form of the Child window.
                MdiParent = this
            };
            // Display the new form.
            newMDIChild.Show();
        }

        private void informe1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR_Report2 newMDIChild = new CR_Report2
            {
                // Set the Parent Form of the Child window.
                MdiParent = this
            };
            // Display the new form.
            newMDIChild.Show();
        }

        private void informe3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR_Report3 newMDIChild = new CR_Report3
            {
                // Set the Parent Form of the Child window.
                MdiParent = this
            };
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
