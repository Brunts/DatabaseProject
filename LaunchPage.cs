using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class LaunchPage : Form
    {
        public LaunchPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button to edit account details
            this.Hide();
            AccountInfo x = new AccountInfo();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Button to edit user DB

            this.Hide();
            EditUsers y = new EditUsers();
            y.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

           // Button to view cases

            this.Hide();
            MenuTickets sign = new MenuTickets();
            sign.Show();

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            //logout button

            this.Hide();
            Signin sign = new Signin();
            sign.Show();

        }
    }
}
