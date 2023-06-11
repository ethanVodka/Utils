using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Common
{
    public class UPassword
    {
        internal static string Password { get; set; } = string.Empty;

        public static string GetPassword()
        {
            Views.PassWordForm passWordForm = new Views.PassWordForm();
            passWordForm.ShowDialog();

            if (Password != string.Empty)
            {
                return Password;
            }
            else
            {
                return "error";
            }
        }
    }
}
