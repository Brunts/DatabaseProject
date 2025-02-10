using DatabaseProject.DatabaseProject;
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
    public partial class Signin : Form
    {

        //set our users properties to use in other classes

        public static string id, name, email, password, country;



        DBAccess objDbAccess = new DBAccess();

        private void Signin_Load(object sender, EventArgs e)
        {
            //on page load
        }

        DataTable dtUsers =new DataTable();
        public Signin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// name: 
        /// 
        ///     void btnSignIn_Click
        ///
        /// description:
        ///     
        ///     Button displays sign in and on user click
        ///     it checks that the user entered a valid email
        ///     and password. It queries the database to find a matching
        ///     email and password and if successful will first
        ///     store all user information into variables we
        ///     can referance. Then it will take user to the main
        ///     menu.
        ///     
        /// </summary>


        private void btnSignIn_Click(object sender, EventArgs e)
        {

            //on sign in click, check users DB against email and password for match

            string userEmail = txtEmailLogin.Text;
            string userPassword = txtPasswordLogin.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter email...");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter password...");
            }
            else 
            {

                //query to get entries where user email and password matched

                string query = "Select * from Users Where Email= '" + userEmail + "' AND Password = '" + userPassword + "'";

                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {

                    //set global variables to user properties

                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();

                    MessageBox.Show("Congrats you are logged in Successfully.");
                    objDbAccess.closeConn();

                    //go to main menu

                    this.Hide();
                    LaunchPage home = new LaunchPage();
                    home.Show();


                }
                else 
                {
                    MessageBox.Show("An error occurred try again. Provide correct credentials");
                }
            }
        }

        /// <summary>
        /// Name:
        /// 
        ///     void lblCreateAccount_Click
        ///     
        /// Description:
        /// 
        ///     clicking the label sends user to sign up page
        /// 
        /// </summary>


        private void lblCreateAccount_Click(object sender, EventArgs e)
        {

            //on clicking create account label go to sign up page

            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();

        }
    }
}
