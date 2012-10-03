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
        //protected IQueryable get_processed_data { get { return processed_data(); } }
        public WebScraper(string input_url)
        {

            web = new HtmlWeb();
            doc = web.Load(input_url);
          //  processed_data();
        }


 /*       private IQueryable  processed_data()
        {
            
        try
        {

            tables = doc.DocumentNode.SelectNodes("//table");
            rows = tables[0].SelectNodes(".//tr");
            
            for (int i = 0; i < rows.Count; ++i)
            {

                // Iterate all columns in this row
                HtmlNodeCollection cols = rows[i].SelectNodes(".//td");
                for (int j = 0; j < cols.Count; ++j)
                {
                    string value =cols[j].InnerHtml;
                }
            }

        }
        catch (Exception error)
        {

            Console.WriteLine(error.ToString());

        }


        return values;

        }

        */

    }
}