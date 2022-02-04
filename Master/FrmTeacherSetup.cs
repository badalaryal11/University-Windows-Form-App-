using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Master
{
    public partial class FrmTeacherSetup : Form
    {
        public FrmTeacherSetup()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void btnSTeacher_Click(object sender, EventArgs e)
        {
            var result = @"TEACHER INFORMATION SAVE SUCESSFULLY..!!";
            MessageBox.Show(result, "Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnETeacher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
