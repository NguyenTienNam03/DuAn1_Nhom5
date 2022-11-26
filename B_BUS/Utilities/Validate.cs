using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace B_BUS.Utilities
{
    public class Validate
    {
        public bool CheckSDT(string sdt)
        {
            

            return false;
        }
        public bool CheckSoNguyenduong(string so)
        {
            if(Regex.IsMatch(so , @"^\d+$"))
            {
                return true;
            }return false;
        }
        public bool CheckEmail(string email)
        {
            email = email ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(email, strRegex))
                return (true);
            else
                return (false);
        }
        public bool checkRong(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
