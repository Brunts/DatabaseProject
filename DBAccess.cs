
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
   
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    
    namespace DatabaseProject
    {
        class DBAccess
        {

            //construct methods from SQL client library objects
            //methods for opening conncection to database, running SQL commands, reading and writing to database

            private static SqlConnection connection = new SqlConnection();
            private static SqlCommand command = new SqlCommand();
            private static SqlDataAdapter adapter = new SqlDataAdapter();


            //where to look for database and database name

            private static string strConnString = "Data Source=(local);Initial Catalog=SocialNetwork;Integrated Security=True";


            /// <summary>
            ///  Name: 
            /// 
            ///     void createConn()
            /// 
            ///
            /// Description:
            /// 
            ///     this function opens the connection
            ///     for the data stream in between the 
            ///     database and the program.
            /// </summary>
            public void createConn()
            {
                
                //open connection to database for reading and writing data to tables

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = strConnString;
                        connection.Open();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            /// <summary>
            /// 
            /// Name: 
            /// 
            ///     void closeConn()
            /// 
            ///
            /// Description:
            /// 
            ///     this function closes the connection
            ///     for the data stream in between the 
            ///     database and the program.
            ///     
            /// </summary>
            public void closeConn()
            {

                //close connection when finished

                connection.Close();
            }

            /// <summary>
            /// 
            /// 
            /// Name: 
            /// 
            ///     int executeDataAdapter
            /// 
            /// Synopsis: 
            /// 
            ///      public int executeDataAdapter(DataTable tblName, string strSelectSql)
            ///      
            ///         tblName -> the table we are changing
            ///         strSelectSQL ->get our SQL command type
            ///         
            /// Description:
            /// 
            ///     This function will create the bridge between our database and C#. 
            ///     It can be used to initalize the data set and update the SQL server database.
            ///     It opens a connection to the database and defines our available commands.
            ///     Then the command is performed on the table and we are returned the amount
            ///     of changes made to the table and the changes are pushed to the database.
            ///     
            /// </summary>
            /// <param name="tblName"></param>
            /// <param name="strSelectSql"></param>
            /// <returns>updated table</returns>
            /// 
            public int executeDataAdapter(DataTable tblName, string strSelectSql)
            {

                //create and execute commands for editing data tables and returns updated table

                try
                {
                    if (connection.State == 0)
                    {
                        createConn();
                    }

                    //get query for adapter and set command

                    adapter.SelectCommand.CommandText = strSelectSql;
                    adapter.SelectCommand.CommandType = CommandType.Text;
                    SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

                    //set our commands when committing changes with data adapter

                    string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                    string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                    string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();


                    return adapter.Update(tblName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            /// <summary>
            /// 
            /// 
            /// Name: 
            /// 
            ///     void readDatathroughAdapter
            /// 
            /// Synopsis: 
            /// 
            ///      public void readDatathroughAdapter(string query, DataTable tblName)
            ///      
            ///         tblName -> the table we are changing
            ///         query ->get the SQL query we are making
            ///         
            /// Description:
            /// 
            ///     This function will give us a table made up
            ///     of the results of the SQL query we are making.
            ///     It will establish connection, set the query,
            ///     and assign the results to our input table.
            ///     
            /// </summary>
            /// <param name="query"></param>
            /// <param name="tblName"></param>
            public void readDatathroughAdapter(string query, DataTable tblName)
            {


                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        createConn();
                    }

                    //get and set query

                    command.Connection = connection;
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;

                    adapter = new SqlDataAdapter(command);

                    //make query and return table with data

                    adapter.Fill(tblName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }



            /// <summary>
            /// 
            /// Name: 
            /// 
            ///     int executeQuery
            /// 
            /// Synopsis: 
            /// 
            ///     public int executeQuery(SqlCommand dbCommand)
            ///      
            ///        dbCommand-> the SQL command we are making
            ///         
            /// Description:
            /// 
            ///    This function will establish the
            ///    connection to the database, read
            ///    the type of SQL command it has to make,
            ///    then executes the command and will
            ///    return the number of rows affected.
            ///     
            /// 
            /// </summary>
            /// <param name="dbCommand"></param>
            /// <returns>count of affected rows</returns>
            public int executeQuery(SqlCommand dbCommand)
            {
                try
                {
                    if (connection.State == 0)
                    {
                        createConn();
                    }

                    dbCommand.Connection = connection;
                    dbCommand.CommandType = CommandType.Text;


                    return dbCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }

}
