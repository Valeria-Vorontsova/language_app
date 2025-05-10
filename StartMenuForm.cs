using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace language_app
{
    public partial class StartMenuForm: Form
    {
        public StartMenuForm()
        {
            InitializeComponent();
        }
        private void btnGoToManage_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.ShowManageTab();
            mainForm.Show();
            this.Hide();
        }
        private void btnGoToLearn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.ShowLearnTab();
            mainForm.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
