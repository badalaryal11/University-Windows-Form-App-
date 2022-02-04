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
    public partial class FrmStaffSetup : Form
    {
        public FrmStaffSetup()
        {
            InitializeComponent();
        }
        private void BtnSStaff_Click(object sender, EventArgs e)
        {
            var result = @"Staff Information Saved Sucessfully..!!";
            MessageBox.Show(result, "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnEStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
