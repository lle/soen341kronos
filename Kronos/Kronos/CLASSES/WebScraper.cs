using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using HtmlAgilityPack;

namespace Kronos.CLASSES
{
    public class WebScraper
    {
        private HtmlWeb web;
        private HtmlDocument doc;
        private HtmlNodeCollection tables;
        private HtmlNodeCollection rows;
        private HtmlNodeCollection cols;
        private string course_code;
        private string semester_code;
        private string coursenumber_code;

        public WebScraper(string coursetag, string coursenumber, string semesternumber)
        {
            course_code = coursetag;
            coursenumber_code = coursenumber;
            semester_code = semesternumber;
        }

        public void process_course()
        {
            string url = "http://fcms.concordia.ca/fcms/asc002_stud_all.aspx?yrsess=2012"
                + semester_code + "&course=" + course_code + "&courno=" + coursenumber_code + "%20&campus=&type=U";
            web = new HtmlWeb();
            doc = web.Load(url);
           

            try
            {
                //check this logic out, get the table ID and then process data from the rows and columns of the table.
                var GetTableID = doc.GetElementbyId("ctl00_PageBody_tblBodyShow1").Descendants("tr").Select(x => x.Elements("td").Select(y => y.InnerText).ToArray());
                System.Diagnostics.Debug.WriteLine(GetTableID);

            }
            catch (Exception error)
            {
                throw new Exception(error.ToString());
            }

       




        }

    }
}