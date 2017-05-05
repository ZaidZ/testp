using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestApp
{
    class Helper
    {
        public static bool IsPasswordOkay(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                return false;

            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
                return false;

            return true;
        }


        internal static string CalculateBamFromEur(string euros)
        {
            return (Convert.ToInt32(euros) * 1.95583) + "";
        }

        internal static bool IsCorrect(string mail, string password)
        {
            return mail == "test@abc.com" && password == "test1234";
        }

        internal static string CalculatePDV(string amount)
        {
            return (Convert.ToInt32(amount) * 0.17) + "";
        }

        internal static string CalculateRate(string amount, string rates)
        {
            return (Convert.ToInt32(amount) / Convert.ToInt32(rates)) + "";
        }

        internal static string CalculateAverage(string numbers)
        {
            int sum = 0;
            int count = 1;
            foreach (string num in numbers.Split(' '))
            {
                sum += Convert.ToInt32(num);
                count++;
            }

            return sum / count + "";
        }

        public static bool IsMailOkay(string mail)
        {
            Regex regxp = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regxp.Match(mail).Success;
        }
    }
}
