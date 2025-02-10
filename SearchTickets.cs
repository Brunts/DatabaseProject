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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseProject
{
    public partial class SearchTickets : Form
    {

        //declare our database and datatable objects

        DBAccess objDBAcess = new DBAccess();

        DataTable dtCases = new DataTable();

        
        public SearchTickets()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Name:
        /// 
        ///     void button1_Click
        ///     
        /// Description:
        /// 
        ///     Button says search and on user click it will
        ///     execute a query and display the results in a 
        ///     data grid view element. It checks that a subject
        ///     dropdown element is selected or theres a case
        ///     owner/number input. The user can choose by which method
        ///     they would like to search and will get all the results
        ///     of that subject, from that case owner, or a specific case
        ///     associated with a unique case number.
        ///     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            //on button click search for all cases of these chosen properties

            string caseInput = txtInput.Text;
           
            
            dtCases.Clear();

            //Show all cases of software, hardware, or other subject in datagridview

            if (txtSubjectDrop.Text == "SOFTWARE")
            {

                string query = "Select * from Cases WHERE Subject = 'Software'";
                objDBAcess.readDatathroughAdapter(query, dtCases);

            }
            else if (txtSubjectDrop.Text == "HARDWARE") 
            {

                string query = "Select * from Cases WHERE Subject = 'Hardware'";
                objDBAcess.readDatathroughAdapter(query, dtCases);

            }
            else if (txtSubjectDrop.Text == "OTHER")
            {

                string query = "Select * from Cases WHERE Subject = 'Other'";
                objDBAcess.readDatathroughAdapter(query, dtCases);

            }

            //for owner and case number search on butn press check user input for direct match against rows in respective columns and display match in dt

            if (caseInput.Equals("") && txtSearchBox.Text == "OWNER")
            {

                MessageBox.Show("Please enter case owner...");

            }
            else if (caseInput.Equals("") && txtSearchBox.Text == "CASE NUMBER")
            {

                MessageBox.Show("Please enter case number...");

            }
            else if (caseInput != "" && txtSearchBox.Text == "OWNER")
            {

                string query = "Select * from Cases Where Owner= '" + caseInput + "'";

                objDBAcess.readDatathroughAdapter(query, dtCases);

            }
            else if (caseInput != "" && txtSearchBox.Text == "CASE NUMBER") 
            {

                //Check if user input for case number search is an integer, if not prompt for re-entry else display case

                int i;
                bool success = int.TryParse(caseInput, out i);

                if (success == false)
                {

                    MessageBox.Show("Enter a valid case number");

                }
                else
                {

                    int caseInputInt = int.Parse(txtInput.Text);

                    string query = "Select * from Cases Where CaseNumber= '" + caseInputInt + "'";

                    objDBAcess.readDatathroughAdapter(query, dtCases);
                    txtInput.Text.ToString();
                }

            }
           

            casesGrid.DataSource = dtCases;

            objDBAcess.closeConn();

        }

        private void SearchTickets_Load(object sender, EventArgs e)
        {

            //hide elements on page load

            txtSubjectDrop.Hide();
            txtInput.Hide();

        }

        private void casesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //on data grid view cell selected
        }


        /// <summary>
        /// 
        /// Name:
        ///     
        ///     void txtSearchBox_SelectedIndexChanged
        ///     
        /// Description:
        /// 
        ///     controls for hiding and displaying which fields
        ///     are available. When case number or case owner is being
        ///     input then the subject dropdown disappears and vice versa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //change which elements are showing based on whats in the dropdown

            if (txtSearchBox.Text == "SUBJECT")
            {

                txtSubjectDrop.Show();
                txtInput.Clear();
                txtInput.Hide();
            }

            else if(txtSearchBox.Text == "CASE NUMBER" || txtSearchBox.Text == "OWNER")
            {

                txtInput.Show();
                txtSubjectDrop.SelectedIndex = -1;
                txtSubjectDrop.Hide();

            }
        }

        private void txtSubjectDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on subject drop down change
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //on label change
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //return to tickets menu

            this.Hide();
            MenuTickets sign = new MenuTickets();
            sign.Show();

        }
    }
}
