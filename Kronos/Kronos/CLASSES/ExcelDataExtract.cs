using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinqToExcel;
using System.Web.UI;
using System.IO;
namespace Kronos.CLASSES
{
    public class StudentsTranscript
    {
        public string Course { get; set; }
        public string Status { get; set; }
    }

    public class ExcelDataExtract : System.Web.UI.Page
    {
       private IQueryable returned_transcript;

        public ExcelDataExtract(string username)
        {
         var transcript_sheet=new ExcelQueryFactory();
         transcript_sheet.FileName=Server.MapPath("/transcripts/" + username);
         transcript_sheet.AddMapping<StudentsTranscript>(x => x.Course, "Course");
         transcript_sheet.AddMapping<StudentsTranscript>(x => x.Status, "Grade");
        var StudentsTranscript = from x in transcript_sheet.Worksheet<StudentsTranscript>() select x;
          returned_transcript=StudentsTranscript;


            //test to see if it works

          StreamWriter documentWrite = new StreamWriter("C:\\transcriptresults.txt");
          documentWrite.WriteLine(StudentsTranscript);

        }
        //an excel file needs to have two records for the student record; the first column is the course; second column is either the grade or pass fail status
        public IQueryable processed_transcript()
        {
            return returned_transcript;
        }

    }
}