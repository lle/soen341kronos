using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kronos.CLASSES;
using System.Threading;
using System.IO;
using LinqToExcel;
namespace Kronos
{
    public partial class LoggedIn : System.Web.UI.Page
    {
        public string Username_logged_in;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Username"] != null) { Username_logged_in = Request.QueryString["Username"]; }
            
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            //upload transcript you save it from my concordia as an excel document
            if (FileUploadControl.HasFile)
            {
                try
                {
                    if (FileUploadControl.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        if (FileUploadControl.PostedFile.ContentLength < 102400)
                        {
                           // string filename = Path.GetFileName(FileUploadControl.FileName);
                            FileUploadControl.SaveAs(Server.MapPath("/transcripts/") + Username_logged_in +".xlsx");
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
                    StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }





    }
}