using System;
using System.Windows.Forms;
using WindowsFormsApp2.Master;

namespace WindowsFormsApp2.Setup
{
    public partial class DashBoard : Form
    {

        public DashBoard()
        {
            InitializeComponent();
        }

        private void MnuStudentSetup_Click(object sender, EventArgs e)
        {
            var result = new FrmStudentSetup();
            result.ShowDialog();
            
        }
        private void MnuTeacherSetup_Click(object sender,EventArgs e)
        {
            var result = new FrmTeacherSetup();
            result.ShowDialog();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = @"RUNNING IN UNIVERSITY VERSION..!!";
        }

        private void MnuStaffSetup_Click(object sender, EventArgs e)
        {
            var result = new FrmStaffSetup();
            result.ShowDialog();
        }
    }
}
