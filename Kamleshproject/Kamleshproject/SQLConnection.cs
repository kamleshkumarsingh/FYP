using System;
using System.Configuration;

namespace Kamleshproject
{
    public static class SQLConnection
    {
        public static string getConnection()
        {
            return ConfigurationManager.ConnectionStrings["cnmain"].ToString();

        }
    }


    public static class Session
    {
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static string PhoneNo { get; set; }
        public static string Faculty { get; set; }
        public static DateTime LoginDateTime { get; set; }
    }
}
