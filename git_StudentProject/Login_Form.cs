using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_StudentProject
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

            
        }

        private void cancel_bt_Click(object sender, EventArgs e){
        // Login_Form log = new Login_Form();
        this.Hide();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
