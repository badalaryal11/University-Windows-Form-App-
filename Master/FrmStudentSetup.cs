using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAL.Module;
using WindowsFormsApp2.DAL.Module.Interface;

namespace WindowsFormsApp2.Master
{
    public partial class FrmStudentSetup : Form
    {
        VmStudent GetStudent = new VmStudent();
        public FrmStudentSetup()
        {
            InitializeComponent();
        }

        private void FrmStudentSetup_Load(object sender, EventArgs e)
        {

        }

        private void BtnSStudent_Click(object sender, EventArgs e)
        { 
            var result = @"STUDENT INFORMATION SAVED SUCESSFULLY..!!";
            MessageBox.Show(result, "STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void BtnEStudent_Click(object sender, EventArgs e)
            {
          
                if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
        }

        
    }

