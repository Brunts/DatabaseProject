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
using DatabaseProject.DatabaseProject;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace DatabaseProject
{
    public partial class SignUp : Form
    {

        DBAccess objDBAccess = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }

        //checking if an email entry is valid using regex. return true if valid entry
        /// <summary>
        ///  
        /// Name:
        ///     bool IsValid
        ///     
        /// Synopsis:
        ///      private static bool IsValid(string email)
        ///      
        ///     email -> the email the user is inputting for creation.
        ///     
        /// Description:
        ///     This function will test whether or not email is a valid input.
        ///     The REGEX string will define the acceptable format of input
        ///     and will return true if the entry is valid or false if not. 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>whether or not the user entered a valid email</returns>
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|edu)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Name:
        ///     btnSignUp_Click
        ///     
        /// Description:
        /// 
        ///     The button says sign up on it and when
        ///     the user presses the button a few things happen.
        ///     First we get all our inputs and assign them. Then 
        ///     check for valid entries and if all is good then
        ///     it creates a new entry in the data table using the
        ///     information the user input. It checks for errors then
        ///     sends the user to the sign in page upon success.
        /// 
        /// </summary>

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            //On button click commit name, email , and password to users database

            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userCountry = txtCountry.Text;

            //check all fields are filled and an email is entered
           

            if (userName.Equals(""))
            {
                MessageBox.Show("please enter your username.");
            }
            else if (userEmail.Equals("") || IsValid(userEmail) == false)
            {
                MessageBox.Show("please enter your email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("please enter your password.");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("please enter your country.");
            }
            else 
            {

                //insert new entry into users data table from user properties we set

                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country)values(@userName,@userEmail,@userPassword,@userCountry)");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {

                    //return to main menu after successful login

                    MessageBox.Show("account created successfully. please login now");

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
        ///     void btnBack_Click
        /// 
        /// Description:
        /// 
        ///     button for going back to sign in page
        /// </summary>

        private void btnBack_Click(object sender, EventArgs e)
        {

            //Logout on click

            this.Hide();
            Signin signIn = new Signin();
            signIn.Show();

        }

        private void txtCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on country drop down change
        }
    }

}
