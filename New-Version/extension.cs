using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Version
{
    static class extension
    {


        public static bool PasswordChecker(this string password ,string pass)
        {

            bool num = false;
            bool num2 = false;
            bool num3 = false;
            if (pass.Length >= 8) // uzunluqun yoxlayir 
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i])) //boyuk herifi yoxlayir
                    {
                        num = true;
                    }
                    else if (char.IsLower(pass[i])) // kicik herifi yoxlayir 
                    {
                        num2 = true;
                    }
                    else if (char.IsNumber(pass[i])) // reqem yoxlayir
                    {
                        num3 = true;
                    }
                }
            }


            if (num == true && num2 == true && num3 == true)
            {

                return true;
            }

            return false;
        }

    }
}
