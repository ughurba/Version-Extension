using System;
using System.Text.RegularExpressions;

namespace New_Version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(SetInfo("Write FullName"),
                                 SetInfo("Write email"),
                                 SetInfo("Write password"));

            User user1 = new User(SetInfo("Write FullName"),
                                SetInfo("Write email"),
                                SetInfo("Write password"));

            User user2 = new User(SetInfo("Write FullName"),
                                SetInfo("Write email"),
                                SetInfo("Write password"));

        }
        public static string SetInfo(string str)
        {


            string input;
            Console.WriteLine();
            Console.WriteLine(str);
            input = Console.ReadLine();
            return input;

        }
    }
}
