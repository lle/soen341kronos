using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Kronos
{
    public partial class Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            #region ON_START
            Label1.Visible = false;
            Label2.Visible = false;
            #endregion
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region REGISTER LOGIC
            //registers user, dont enter your real password you use, you can see the value in the table it doesn't put it as asterisks
       
 SqlConnection myConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["soen341dBConnectionString1"].ConnectionString);
           //start a connection

            string sql = "INSERT INTO registration (Username, Password, email) VALUES "
                        + " (@Username,@Password,@email)";
            //inserting in table

            try
            {
                
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, myConnection);
                LinkedList<SqlParameter> parameters = new LinkedList<SqlParameter>();


                parameters.AddLast(new SqlParameter("@Username", SqlDbType.VarChar, 50));
                parameters.AddLast(new SqlParameter("@Password", SqlDbType.VarChar, 50));
                parameters.AddLast(new SqlParameter("@email", SqlDbType.VarChar, 50));
                parameters.ElementAt(0).Value=TextBox1.Text;
                parameters.ElementAt(1).Value=TextBox2.Text;
                parameters.ElementAt(2).Value=TextBox3.Text;

                foreach (SqlParameter sqlpara in parameters)
                    cmd.Parameters.Add(sqlpara);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error: ";
                msg += ex.Message;
                Label1.Visible = true;
                Label1.Text = msg;
            }
            finally
            {
                Label1.Visible = true;
                Label1.Text = "User has Registered :)";
                myConnection.Close();
               // Response.Redirect("LoggedIn.aspx");
            }


            #endregion
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            #region LOGIN LOGIC
            Label2.Visible = true;
            int result;
            SqlConnection myConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["soen341dBConnectionString1"].ConnectionString);
            //start a connection
            try
            {
                 myConnection.Open();
                string strSelect = "SELECT COUNT(*) FROM registration WHERE UserName = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = myConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSelect;
                SqlParameter username = new SqlParameter("@Username", SqlDbType.VarChar, 50);
                username.Value = TextBox4.Text.Trim().ToString();
                  cmd.Parameters.Add(username);
                SqlParameter password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                password.Value = TextBox5.Text.Trim().ToString();
                cmd.Parameters.Add(password);
                result = (Int32)cmd.ExecuteScalar();
               
               if (result >= 1)
                   Label2.Text = "login successful";
               else
                   Label2.Text = "login not working";
            }

           
            
            finally
            {
            myConnection.Close();

            }

            #endregion
        }
    }
}