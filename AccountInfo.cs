using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DatabaseProject.DatabaseProject;

namespace DatabaseProject
{
    public partial class AccountInfo : Form
    {

        DBAccess objDBAccess = new DBAccess();

        public AccountInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //on label click
        }


        /// <summary>
        /// name:
        ///     
        ///     void HomePage_Load
        ///     
        /// Description:
        /// 
        ///     on page load we set the fields of the textboxes equal
        ///     to the account details we set when the user signed in.
        ///     and display users name on top
        ///     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePage_Load(object sender, EventArgs e)
        {

            //Set input fields to current user info

            lblHome.Text = "Welcome:  "+Signin.name;

            txtNameHome.Text = Signin.name;
            txtEmailHome.Text = Signin.email;
            txtPasswordHome.Text = Signin.password;
            txtCountryHome.Text = Signin.country;

        }



        /// <summary>
        /// Name:
        ///     
        ///      void btnSignUp_Click
        /// 
        /// Description:
        ///     
        ///     On button click update the user using the
        ///     information they entered in the textboxes.
        ///     First it sets the new account information
        ///     then checks for valid entries and pushes the updates
        ///     to the data table and then uploads the data table
        ///     to the database. It runs an update query to change 
        ///     the already existing entry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignUp_Click(object sender, EventArgs e)
        {

            //Setters for updating 

            string newUserName = txtNameHome.Text;
            string newUserEmail = txtEmailHome.Text;
            string newUserPassword = txtPasswordHome.Text;
            string newUserCountry = txtCountryHome.Text;

            
            //Check if fields are filled

            if (newUserName.Equals(""))
            {

                MessageBox.Show("Please write your name.");

            }
            else if (newUserEmail.Equals(""))
            {

                MessageBox.Show("Please write your Email.");

            }
            else if (newUserPassword.Equals(""))
            {

                MessageBox.Show("Please write your Password.");

            }
            else if (newUserCountry.Equals(""))
            {

                MessageBox.Show("Please select your Country.");

            }
            else
            {

                //query for updating user account info in Users data table from database

                string query = "Update Users SET Name = '" + @newUserName + "', Email = '" + @newUserEmail + "', Password = '" + @newUserPassword + "', Country = '" + @newUserCountry + "' where ID = '" + Signin.id + "'";
                
                SqlCommand updateCommand = new SqlCommand(query);

                //fill query with our values

                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newUserCountry);

                //execute query in sql databse

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {

                    MessageBox.Show("account info updated successfully");

                    //send to sign in page

                    this.Hide();
                    Signin sign = new Signin();
                    sign.Show();

                }
                else
                {

                    MessageBox.Show("error occurred try again");

                }

            }


        }


        /// <summary>
        /// Name:
        /// 
        ///     void btnDeleteAccount_Click
        /// 
        /// Description:
        /// 
        ///     On button click it will remove the users account if they wish.
        ///     Prompt user to be sure about deletion. if yes then execute 
        ///     a delete query and remove entry from table then push table back to the database.
        ///     After deletion the user will be returned to the sign in page.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

            //prompt user to confirm account deletion

            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes) 
            {

                //query for removing a row from the table

                string query = "DELETE from Users Where ID = '" + Signin.id + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {

                    MessageBox.Show("account info deleted successfully");

                    //back to sign in page

                    this.Hide();
                    Signin sign = new Signin();
                    sign.Show();

                }
                else
                {

                    MessageBox.Show("error occurred try again");

                }
            }
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

            //back to sign in page

            this.Hide();
            Signin sign = new Signin();
            sign.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //back to home page

            this.Hide();
            LaunchPage home = new LaunchPage();
            home.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //on label click
        }

        private void txtCountryHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on country dropdown index change
        }
    }
}
