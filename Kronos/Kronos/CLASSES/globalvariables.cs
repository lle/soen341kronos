using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Kronos.CLASSES
{
    public static class globalvariables
    {
        public static string user_logged;
        public enum semester { fall, winter, summer, fallwinter };
        public enum day { monday, tuesday, wednsday, thursday, friday };
        public enum course_tag { CIVI, SOEN, ELEC, COEN, COMP, BLDG, INDU };
        

        public static string EncodePassword(string originalPassword)
        {
            MD5 crypto_Service;
            crypto_Service = new MD5CryptoServiceProvider();
            return BitConverter.ToString(crypto_Service.ComputeHash(ASCIIEncoding.Default.GetBytes(originalPassword)));
        }
    }
}