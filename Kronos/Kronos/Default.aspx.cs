using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;
using System.Configuration;
using Kronos.CLASSES;

namespace Kronos
{
    public partial class Default : System.Web.UI.Page
    {
  

        protected void Page_Load(object sender, EventArgs e)
        {


            #region ON_START
            //Don't show text on the main page
            login_label.Visible = false;
            #endregion
            
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
          
            #region LOGIN
            //conditions for entered data
            if (username_textbox.Text == "" && password_textbox.Text == "")
            {
                login_label.Visible = true;
                login_label.Text = "No Data entered";
            }
            else if (username_textbox.Text == "") { login_label.Visible = true; login_label.Text = "No Username Entered"; }
            else if (password_textbox.Text == "") { login_label.Visible = true; login_label.Text = "No Password Entered"; }

            else
            {
                //start a Model Entity Object
                soen341dBEntities soen341dB_context = new soen341dBEntities();
                //dB table constructor
                registration newuser = new registration();
                string username = username_textbox.Text;
                string password = password_textbox.Text;
                try
                {
                    //get the retrived_user
                    var retrieved_user = (from person in soen341dB_context.registrations
                                          where person.Password == password
                                          where person.Username == username
                                          select person).FirstOrDefault();

                    //check to see if a record of it exists
                    if (retrieved_user == null) { login_label.Text = "Account Information Incorrect"; login_label.Visible = true; }
                    else
                    {
                        
                        login_label.Visible = true;
                        login_label.Text = "Login Validated";
                        //encrypt url so people cannot change it to get other people's data; 
                        //Query the username to another page by using question mark variable name =
                        Response.Redirect("LoggedIn.aspx?Username=" + Encoder_BASE64(username));
                    }
                }
                catch (Exception error)
                {
                    login_label.Visible=true;
                    login_label.Text = "Database Exception Occured :" + error.ToString();
                }

            }
            #endregion

        }
        public static string Encoder_BASE64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.Encoding.Unicode.GetBytes(toEncode);
           return System.Convert.ToBase64String(toEncodeAsBytes);

        }
    }
}