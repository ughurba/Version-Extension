using System;

namespace New_Version
{
    public class User
    {

        // User class (IAccount-u implement edir)
        //- Id
        //- Fullname
        //- Email
        //- Password
   
        private static int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullName , string email,string password)
        {
            FullName = fullName;
            Email = email;  
            Password = password;    
            if(password.PasswordChecker(password) == true)
            {
                Id++;
                ShowInfo();
            }
            else
            {
                Console.WriteLine("Account set olunmadi");
                Console.WriteLine();
                Console.WriteLine("Wifrede minimum 8 character olmalidir ve Wifrede en az 1 boyuk herif ,kicik herif ve reqem olmalidir");
            }
        }



        public void ShowInfo()
        {
            Console.WriteLine($"\nUser Id:{Id}\nFullName:{FullName}\nEmail:{Email}\nPassword:{Password}\n");
        }
    }
}
