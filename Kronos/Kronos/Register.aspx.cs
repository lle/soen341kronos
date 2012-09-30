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
using System.Net.Mail;
using System.Web.Mail;
namespace Kronos
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            register_label.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            #region REGISTER

            if (password_textbox1.Text != password_text2box.Text)
            {
                register_label.Visible = true;
                register_label.Text = "Passwords do not match";
            }
            else
            {
                soen341dBEntities soen341dB_context = new soen341dBEntities();
                registration newuser = new registration();

                var username_in_dB = from a_username in soen341dB_context.registrations
                                     where a_username.Username == username_textbox.Text
                                     select a_username;

                var email_in_dB = from an_email in soen341dB_context.registrations
                                  where an_email.email == email_textbox.Text
                                  select an_email;

                if (email_in_dB != null) { register_label.Text = "Email already registered"; register_label.Visible = true; }
                else if (username_in_dB != null) { register_label.Text = "Username already Exists"; register_label.Visible = true; }

                //this if statement is not being called for some reason
                if (email_in_dB == null && username_in_dB == null)
                {
                    try
                    {
                        newuser.Username = username_textbox.Text;
                        newuser.Password = password_textbox1.Text;
                        newuser.email = email_textbox.Text;
                        soen341dB_context.registrations.Add(newuser);
                        soen341dB_context.SaveChanges();
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.ToString());
                    }
                    finally
                    {
                        //send an email to the user that they registered
                    }

                }
            }

            #endregion

        }
    }
}