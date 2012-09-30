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

            login_label.Visible = false;
            #endregion
            
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
          
            #region LOGIN
            if (username_textbox.Text == "" || password_textbox.Text == "")
            {
                login_label.Visible = true;
                login_label.Text = "No Data entered";
            }
            else
            {
                soen341dBEntities soen341dB_context = new soen341dBEntities();
                registration newuser = new registration();
                string username = username_textbox.Text;
                string password = password_textbox.Text;
                try
                {
                    var retrieved_user = (from person in soen341dB_context.registrations
                                          where person.Password == password
                                          where person.Username == username
                                          select person).FirstOrDefault();


                    if (retrieved_user == null) { login_label.Text = "Account Information Incorrect"; login_label.Visible = true; }
                    else
                    {
                        login_label.Text = "Login Validated";
                        Response.Redirect("LoggedIn.aspx?Username=" + Encoder_BASE64(username));
                    }
                }
                catch (Exception error)
                {
                    throw new Exception(error.ToString());
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