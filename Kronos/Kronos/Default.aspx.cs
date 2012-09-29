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
            
            Label1.Visible = false;
            Label2.Visible = false;
            #endregion
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region REGISTER

            if (TextBox2.Text != TextBox6.Text)
                Label1.Text = "Passwords do not match";
          
            soen341dBEntities soen341dB_context = new soen341dBEntities();
            registration newuser = new registration();

            var username_in_dB = from a_username in soen341dB_context.registrations
                                 where a_username.Username == TextBox1.Text
                                 select a_username;

            var email_in_dB = from an_email in soen341dB_context.registrations
                                 where an_email.email == TextBox3.Text
                                 select an_email;

            if (email_in_dB != null) { Label1.Text = "Email already registered"; Label1.Visible = true; }
            else if (username_in_dB != null) { Label1.Text = "Username already Exists"; Label1.Visible = true; }


            if (email_in_dB == null && username_in_dB ==null)
            {
                try
                {
                    newuser.Username = TextBox1.Text;
                    newuser.Password = TextBox2.Text;
                    newuser.email = TextBox3.Text;
                    soen341dB_context.registrations.Add(newuser);
                    soen341dB_context.SaveChanges();
                }
                catch
                {
                    Label1.Visible = true;
                    Label1.Text = "Database Error occured";
                }

            }

            #endregion
            
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
            #region LOGIN

            soen341dBEntities soen341dB_context = new soen341dBEntities();
            registration newuser = new registration();
            string username = TextBox4.Text;
            string password = TextBox5.Text;

            var retrieved_user = from person in soen341dB_context.registrations
                                 where person.Password == password
                                 where person.Username == username
                                 select person;

            if (retrieved_user == null) { Label2.Text = "Account Information Incorrect"; }
            else
            {

                Response.Redirect("LoggedIn.aspx");
            }
            #endregion

        }
    }
}