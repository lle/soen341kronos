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
using System.Net;
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
            //check passwords match
            if (password_textbox1.Text != password_text2box.Text)
            {
                register_label.Visible = true;
                register_label.Text = "Passwords do not match";
            }
                //check its not empty the password
            else if(password_text2box.Text=="" || password_textbox1.Text=="")
            {
                register_label.Visible = true;
                register_label.Text = "Don't leave passwords blank stupid";
            }
            else
            {
                soen341dBEntities soen341dB_context = new soen341dBEntities();
                registration newuser = new registration();
                //checking if either the user or email is already registered
                var username_in_dB = (from a_username in soen341dB_context.registrations
                                      where a_username.Username == username_textbox.Text
                                      select a_username).FirstOrDefault();

                var email_in_dB = (from an_email in soen341dB_context.registrations
                                  where an_email.email == email_textbox.Text
                                  select an_email).FirstOrDefault();

                if (email_in_dB != null) { register_label.Text = "Email already registered"; register_label.Visible = true; }
                if (username_in_dB != null) { register_label.Text = "Username already Exists"; register_label.Visible = true; }

                //if it doesnt retrieve records make a new record
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
                        register_label.Visible=true;
                        register_label.Text = "Database Exception Occured: " + error.ToString();
                    }
                    finally
                    {
                        register_label.Visible = true;
                        register_label.Text = "Thank You for registering, You should have recieved an email from us!";
               
                            MailMessage mail = new MailMessage();
                            mail.To.Add(email_textbox.Text);
                            mail.From = new MailAddress("admin@341.atsebak.com");
                            mail.Subject = "mYScheduler Registration Confirmation";
                            mail.Body = "Thank You for registering to the Concordia University mYScheduler. Your username is: " + username_textbox.Text +" Please report bugs and suggestions to admin@341.atsebak.com";
                            mail.IsBodyHtml = true;
                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "mail.atsebak.com";
                            smtp.Port = 587;
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = new NetworkCredential("admin@341.atsebak.com", "softwareprocess");
                            smtp.EnableSsl = false;
                            smtp.Send(mail);

                    }

                }
            }

            #endregion

        }
    }
}