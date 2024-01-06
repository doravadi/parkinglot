using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                if (UNameTb.Text == "Admin" && PasswordTb.Text == "Admin") 
                {
                    Cars Obj = new Cars();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName Or PassWord");
                    UNameTb.Text = "";
                    PasswordTb.Text = "";
                }
            }
        }
    }
}
