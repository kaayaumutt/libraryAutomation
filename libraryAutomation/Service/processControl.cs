using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace libraryAutomation
{
    public class processControl
    {
        public bool isValidText(string value)
        {
            if(
                value == string.Empty &&
                value.Length < 2 &&
                value == "Ad" &&
                value == "Soyad" &&
                value == "Şifre" &&
                value == "Departman" &&
                value == "Kitap Adı" &&
                value == "Kitap Türü" &&
                value == "Kitap Yazarı" &&
                value == "Öğrenci Adı" &&
                value == "Öğrenci Seçin" &&
                value == "Kitap Seçin" &&
                value == "Öğrenci Soyadı") 
            {
                return false; 
            }
            foreach (char chr in value)
            {
                if (Char.IsNumber(chr)) 
                { 
                    return false; 
                }
            }
            return true;
        }
        public bool isValidNumber(string value)
        {
            if(
                value == string.Empty &&
                value == "Öğrenci Numarası" &&
                value == "Sayfa Sayısı") 
            { 
                return false; 
            }
            foreach (char chr in value)
            {
                if (!Char.IsNumber(chr)) 
                {
                    return false;
                }
            }
            return true;
        }
        public bool isValidEmail(string email)
        {
            if(
                email == string.Empty &&
                email == "E-Mail" &&
                email == "Öğrenci E-Maili") 
            { 
                return false; 
            }

            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        public bool controlEqual(string value1,string value2)
        {
            if (value1==value2)
            {
                return false;
            }
            return true;
        }
    }
}
