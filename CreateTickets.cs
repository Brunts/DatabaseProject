using DatabaseProject.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DatabaseProject
{
    public partial class CreateTickets : Form
    {

        //creating object from our database manipulation class

        DBAccess objDBAccess = new DBAccess();

        public CreateTickets()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

            //Return to sign in page

            this.Hide();
            Signin sign = new Signin();
            sign.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //return to tickets menu

            this.Hide();
            MenuTickets sign = new MenuTickets();
            sign.Show();

        }

        /// <summary>
        /// Name:
        /// 
        ///      void button2_Click
        /// 
        /// Description:
        /// 
        ///    this is the create ticket button and it says create on it.
        ///    first we set all the attributes of the case we are making by
        ///    pulling from input data in forms elements. once we check
        ///    for valid entries then we can push these variables to the
        ///    table as a data entry.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            //set case attributes

            string caseSubject = txtSubject.Text;
            string caseDescription = txtDesc.Text;
            string caseOwner = Signin.name;


            //check for entries
            // Check for valid entries
            switch (caseSubject)
            {
                case "Software":
                case "Hardware":
                case "Other":
                    // Valid case, continue processing (if needed)
                    break;
                default:
                    MessageBox.Show("Please select a valid subject.");
                    break;
            }
            if (caseDescription.Equals(""))
            {

                MessageBox.Show("please enter your description.");

            }
            else
            {

                //insert elements into new row in the data table using insert query

                SqlCommand insertCommand = new SqlCommand("insert into Cases(Owner,Subject,Description)values(@caseOwner,@caseSubject,@caseDescription)");

                insertCommand.Parameters.AddWithValue("@caseOwner", caseOwner);
                insertCommand.Parameters.AddWithValue("@caseSubject", caseSubject);
                insertCommand.Parameters.AddWithValue("@caseDescription", caseDescription);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {

                    MessageBox.Show("Case created successfully.");

                    //Clear both fields on ticket creation

                    txtDesc.Clear();
                    txtSubject.SelectedIndex = -1;

                    //return to ticket menu after ticket creation

                    this.Hide();
                    MenuTickets sign = new MenuTickets();
                    sign.Show();
                }
                else
                {

                    MessageBox.Show("error occurred try again");

                }

            }


        }
        private void txtCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on subject dropdown change
        }
    }
}
