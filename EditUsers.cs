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
    public partial class EditUsers : Form
    {

        //declaring database and data table

        DBAccess objDBAcess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public EditUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //on datagridview cell click
        }

        /// <summary>
        /// Name:
        /// 
        ///      void CommandBuilderForm_Load
        ///      
        /// Description:
        /// 
        ///     when the page loads it will populate the
        ///     grid view with the elements pulled from the
        ///     query. The query gets all users. The user can
        ///     edit the elements in the data grid view but this
        ///     method will lock the ID field from being changed.
        ///     
        /// </summary>


        private void CommandBuilderForm_Load(object sender, EventArgs e)
        {

            //read data from table and input it into datagridview element

            string query = "Select * from Users";

            objDBAcess.readDatathroughAdapter(query, dtUsers);

            dataGridView1.DataSource = dtUsers;

            //set ID column to read only

            dataGridView1.Columns["ID"].ReadOnly = true;

            objDBAcess.closeConn();

        }


        /// <summary>
        /// Name:
        /// 
        ///     void performOperationbtn_Click
        ///     
        /// Description:
        /// 
        ///     This function calls the executeDataAdapter function
        ///     which will apply our changes through the query and
        ///     will return us an output int of the number of changes
        ///     made.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void performOperationbtn_Click(object sender, EventArgs e)
        {

            //count and commit changes to edited user fields

            string query = "select * from Users";

            int changes = objDBAcess.executeDataAdapter(dtUsers, query);

            MessageBox.Show("count = " + changes);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //return to home menu

            this.Hide();
            LaunchPage home = new LaunchPage();
            home.Show();

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

            //return to sign in page

            this.Hide();
            Signin sign = new Signin();
            sign.Show();

        }
    }
}
