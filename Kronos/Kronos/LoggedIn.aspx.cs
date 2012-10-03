using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kronos.CLASSES;
using System.IO;
using LinqToExcel;
namespace Kronos
{
    public partial class LoggedIn : System.Web.UI.Page
    {
        public string Username_logged_in;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            //make sure nobody changes url to enter in
            if (Request.QueryString["Username"] == null || Request.QueryString["Username"]=="") { Response.Redirect("Default.aspx"); }
            //decrypt url and store it in a string
            if (Request.QueryString["Username"] != null) { Username_logged_in = Decode_BASE64(Request.QueryString["Username"]); }

            globalvariables.user_logged = Username_logged_in;

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            //upload transcript you save it from my concordia as an excel document, is what I am thinking 
            if (FileUploadControl.HasFile)
            {
                try
                {
                    if (FileUploadControl.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")//this means it has to be excel file type
                    {
                        if (FileUploadControl.PostedFile.ContentLength < 102400)//less the 100kbs
                        {
                            FileUploadControl.SaveAs(Server.MapPath("/transcripts/") + Username_logged_in +".xlxs"); //save it in transcripts folder
                            StatusLabel.Text = "Upload status: File uploaded!";
                        }
                        else
                            StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                    }
                    else
                        StatusLabel.Text = "Upload status: Only Excel 2007 files format are accepted!";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: Exception Occured  " + ex.Message;
                }
            }
            try
            {
                ExcelDataExtract TheSpreadsheet = new ExcelDataExtract(Username_logged_in);
            }
            catch (Exception error)
            {
                throw new Exception(error.ToString());
            }
        }

        public static string Decode_BASE64(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            return System.Text.Encoding.Unicode.GetString(encodedDataAsBytes);
        }





    }
}