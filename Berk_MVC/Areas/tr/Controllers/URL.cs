using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Berk_MVC.Areas.tr.Controllers
{
    public class URL
    {
        public static string urlolustur(string Text)
        {
            try

            {
                string strReturn = Text.Trim();
                strReturn = strReturn.Replace("A", "a");
                strReturn = strReturn.Replace("B", "b");
                strReturn = strReturn.Replace("C", "c");
                strReturn = strReturn.Replace("D", "d");
                strReturn = strReturn.Replace("E", "e");
                strReturn = strReturn.Replace("F", "f");
                strReturn = strReturn.Replace("G", "g");
                strReturn = strReturn.Replace("H", "h");
                strReturn = strReturn.Replace("I", "i");
                strReturn = strReturn.Replace("J", "j");
                strReturn = strReturn.Replace("K", "k");
                strReturn = strReturn.Replace("L", "l");
                strReturn = strReturn.Replace("M", "m");
                strReturn = strReturn.Replace("N", "n");
                strReturn = strReturn.Replace("O", "o");
                strReturn = strReturn.Replace("P", "p");
                strReturn = strReturn.Replace("R", "r");
                strReturn = strReturn.Replace("S", "s");
                strReturn = strReturn.Replace("T", "t");
                strReturn = strReturn.Replace("U", "u");
                strReturn = strReturn.Replace("V", "v");
                strReturn = strReturn.Replace("Y", "y");
                strReturn = strReturn.Replace("Z", "z");
                strReturn = strReturn.Replace("ğ", "g");
                strReturn = strReturn.Replace("Ğ", "G");
                strReturn = strReturn.Replace("ü", "u");
                strReturn = strReturn.Replace("Ü", "U");
                strReturn = strReturn.Replace("ş", "s");
                strReturn = strReturn.Replace("Ş", "S");
                strReturn = strReturn.Replace("ı", "i");
                strReturn = strReturn.Replace("İ", "I");
                strReturn = strReturn.Replace("ö", "o");
                strReturn = strReturn.Replace("Ö", "O");
                strReturn = strReturn.Replace("ç", "c");
                strReturn = strReturn.Replace("Ç", "C");
                strReturn = strReturn.Replace("-", "+");
                strReturn = strReturn.Replace(" ", "+");
                strReturn = strReturn.Trim();
                strReturn = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9+]").Replace(strReturn, "");
                strReturn = strReturn.Trim();
                strReturn = strReturn.Replace("+", "-");
                return strReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}