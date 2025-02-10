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
    public partial class MenuTickets : Form
    {
        public MenuTickets()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

            //logout, return to sign in

            this.Hide();
            Signin sign = new Signin();
            sign.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //send to edit tickets menu

            this.Hide();
            EditTickets sign = new EditTickets();
            sign.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //go to create tickets menu

            this.Hide();
            CreateTickets sign = new CreateTickets();
            sign.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //go back to main menu

            this.Hide();
            LaunchPage  sign = new LaunchPage();
            sign.Show();
        }

        private void MenuTickets_Load(object sender, EventArgs e)
        {
            //on page load
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //go to search tickets menu

            this.Hide();
            SearchTickets sign = new SearchTickets();
            sign.Show();

        }
    }
}
