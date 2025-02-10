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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DatabaseProject
{
    public partial class EditTickets : Form
    {

        //declaring our properties of a case entry

        public static string caseNumber, owner, subject, description;

        //create database objects for each query

        DBAccess objDBAccess1 = new DBAccess();
        DBAccess objDBAccess2 = new DBAccess();
        DBAccess objDBAccess3 = new DBAccess();


        DataTable dtCases = new DataTable();

        public EditTickets()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

            //back to sign in page

            this.Hide();
            Signin sign = new Signin();
            sign.Show();

        }

        private void caseOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on case owner drop down change
        }

        /// <summary>
        /// Name:
        /// 
        ///     void btnSaveChanges_Click
        ///     
        /// Description:
        /// 
        ///     on button click the method will get our new changes.
        ///     it will check for valid entries then attempt to execute
        ///     an update query which will overwrite the current entries
        ///     for these properties for the selected case.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            //setting our case entry properties from form entry fields

            string newOwner = caseOwner.Text;
            string newSub = caseSub.Text;
            string newDesc = txtDesc.Text;

            //check that fields are filled and selected

            if (newOwner.Equals(""))
            {

                MessageBox.Show("Select an owner");

            }
            else if (newSub.Equals(""))
            {

                MessageBox.Show("Select a Subject");


            }
            else if (newDesc.Equals(""))
            {

                MessageBox.Show("Set a description");

            }
            else
            {


                //perform update on case that was entered into case number field on this button press. using an UPDATE query

                string query = "Update Cases SET Owner = '" + @newOwner + "', Subject = '" + @newSub + "', Description = '" + @newDesc + "' where CaseNumber = '" + caseNumber + "'";


                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@caseOwner", @newOwner);
                updateCommand.Parameters.AddWithValue("@caseSubject", @newSub);
                updateCommand.Parameters.AddWithValue("@caseDescription", @newDesc);

                //commit changes

                int row = objDBAccess3.executeQuery(updateCommand);

                if (row == 1)
                {

                    MessageBox.Show("Case updated successfully");

                    //return to ticket menu

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

        /// <summary>
        /// Name:
        /// 
        ///     void btnDelete_Click
        /// 
        /// Description:
        /// 
        ///     Button to delete selected entry. It prompts the
        ///     user to be sure about the deletion. It then executes the delete
        ///     query and push the changes to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

            //remove data entry from cases data table
            //prompt user if theyre sure

            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Case", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {

                int caseInputInt = int.Parse(caseNumber);

                //convert case number to int so we can run DELETE query on it

                string query = "DELETE from Cases Where CaseNumber = '" + caseInputInt + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDBAccess1.executeQuery(deleteCommand);

                if (row == 1)
                {

                    MessageBox.Show("account info deleted successfully");

                    //return to ticket menu

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


        /// <summary>
        /// Name:
        /// 
        ///     void Tickets_Load
        /// 
        /// Description
        /// 
        ///     on page load, handle the display of the
        ///     text and input elements. Ensures that the user
        ///     inputs a case number first then it will give them the
        ///     option to edit. We also will fill the elements of the drop
        ///     down choices by getting queries of all owners and
        ///     subjects.
        ///     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tickets_Load(object sender, EventArgs e)
        {

            //on page load

            MessageBox.Show("Enter a case number please");

            //hide all non used fields before case number is entered

            lblOwner.Hide();
            caseOwner.Hide();

            lblSub.Hide();
            caseSub.Hide();

            lblDesc.Hide();
            txtDesc.Hide();

            btnSaveChanges.Hide();
            btnDelete.Hide();


            //this query will output the names of each user

            string query2 = "Select Distinct Owner from Cases";


            objDBAccess2.readDatathroughAdapter(query2, dtCases);

            //setting the case owner drop down to the names of all users

            for (int i = 0; i < dtCases.Rows.Count; i++)
            {
                caseOwner.Items.Add(dtCases.Rows[i]["Owner"].ToString());
            }

            objDBAccess2.closeConn();

            //this query will output names of each subject

            string query3 = "Select Distinct Subject from Cases";


            objDBAccess2.readDatathroughAdapter(query3, dtCases);

            //setting the subject drop down to contain all subject in data table

            for (int i = 0; i < dtCases.Rows.Count; i++)
            {
                caseSub.Items.Add(dtCases.Rows[i]["Subject"].ToString());
            }

            objDBAccess2.closeConn();

            //clear our data table so it doesnt conflict when we enter case number

            dtCases.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //on button click go to ticketing menu

            this.Hide();
            MenuTickets sign = new MenuTickets();
            sign.Show();

        }


        /// <summary>
        /// Name:
        /// 
        ///     void caseNumInput_TextChanged
        ///     
        /// Description:
        /// 
        ///     Checks that the user entered a valid entry for
        ///     case number input so we can pull up the proper case.
        ///     when thats done it will pull all the data with the associated
        ///     case. Also once the user inputs something into the case number
        ///     textbox then the program will display the other fields for editing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void caseNumInput_TextChanged(object sender, EventArgs e)
        {

            string caseNum = caseNumInput.Text;

            btnDelete.Show();
            //check if case input is a valid integer

            int i;
            bool success = int.TryParse(caseNum, out i);

            if (success == false)
            {

                MessageBox.Show("Enter a valid case number");

            }
            else
            {

                //on case number text field change load all case information

                if (caseNum == "")
                {

                    MessageBox.Show("please enter case number");

                }
                else
                {

                    //convert case number to int so we can use it for a query

                    int caseInputInt = int.Parse(caseNum);

                    //find entry where case number = user input

                    string query = "Select * from Cases Where CaseNumber = '" + caseInputInt + "'";

                    objDBAccess1.readDatathroughAdapter(query, dtCases);

                    if (dtCases.Rows.Count == 1)
                    {

                        //set properties of this case to our variables

                        caseNumber = dtCases.Rows[0]["CaseNumber"].ToString();
                        owner = dtCases.Rows[0]["Owner"].ToString();
                        subject = dtCases.Rows[0]["Subject"].ToString();
                        description = dtCases.Rows[0]["Description"].ToString();

                        //set labels, textbox, and drop downs and convert case number back to string

                        caseSub.SelectedItem = subject;
                        caseOwner.SelectedItem = owner;
                        txtDesc.Text = description;
                        caseNumInput.Text.ToString();

                        objDBAccess1.closeConn();

                        //clear data table so we can search again

                        dtCases.Clear();

                    }
                }

                //once user edits case number field then show all input fields

                lblOwner.Show();
                caseOwner.Show();

                lblSub.Show();
                caseSub.Show();

                lblDesc.Show();
                txtDesc.Show();

                btnSaveChanges.Show();


            }
        }
    }
}

