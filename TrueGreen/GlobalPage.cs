using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruGreen
{
    public class GlobalPage
    {
        internal static IWebDriver Driver;
        private static GlobalPage _global;
        public static string _browser;
        private static string _baseUrl;
        private static string _email;
        private static string _userName;
        private static string _password;
        private static int _seleniumLongTimeOut;
        private static int _seleniumPageLoadTimeOut;
        private static string _firstName;
        private static string _lastname;
        private static string _jobTitle;

        public GlobalPage()
        {

        }
        public static GlobalPage GetGlobal()
        {
            if (_global == null)
            {
                return _global = new GlobalPage();
            }

            return _global;
        }

        public string Browser
        {
            get
            {
                //_browser = ConfigurationManager.AppSettings["Browser"].Trim();
                _browser = "chrome";
                if (!string.IsNullOrWhiteSpace(_browser))
                    return _browser;
                else
                    Console.WriteLine("\t\tMissing browser info.");
                return _browser;
            }
            set
            {
                _browser = "chrome";
                Console.WriteLine(@"\t\tMissing browser info. Default to {$_browser}");
            }
        }

        public string BaseURL
        {
            get
            {
                _baseUrl = "https://prokarma.myfreshworks.com/";
                if (!string.IsNullOrWhiteSpace(_baseUrl))
                    return _baseUrl;
                else
                    throw new ArgumentNullException("\t\tMissing base Url info.");
            }
            set
            {
                _baseUrl = value;
            }
        }

        public string LoginUserName
        {
            get
            {
                //_userName = ConfigurationManager.AppSettings["EmpID"].Trim();
                _userName = "venkata.cherakam9@outlook.com";
                if (!string.IsNullOrWhiteSpace(_userName))
                    return _userName;
                else
                    throw new ArgumentNullException("\t\tMissing EmpID info.");
            }
            set
            {
                _userName = value;
            }
        }

        public string LoginPassword
        {
            get
            {
                //_password = ConfigurationManager.AppSettings["Password"].Trim();
                _password = "Welcome@009";
                if (!string.IsNullOrWhiteSpace(_password))
                    return _password;
                else
                    throw new ArgumentNullException("\t\tMissing Password info.");
            }
            set
            {
                _password = value;
            }
        }

        public static int SeleniumLongTimeOut
        {
            get
            {
                //_seleniumLongTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumLongTimeOut"]);
                _seleniumLongTimeOut = 15;
                if (_seleniumLongTimeOut != 0)
                    return _seleniumLongTimeOut;
                else
                    Console.WriteLine("\t\tMissing browser info.");
                return _seleniumLongTimeOut;
            }
            set
            {
                _seleniumLongTimeOut = 10;
                Console.WriteLine(@"\t\tMissing browser info. Default to {_seleniumLongTimeOut}");
            }
        }

        public static int SeleniumPageLoadTimeOut
        {
            get
            {
                //_seleniumPageLoadTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumPageLoadTimeOut"]);
                _seleniumPageLoadTimeOut = 120;
                if (_seleniumPageLoadTimeOut != 0)
                    return _seleniumPageLoadTimeOut;
                else
                    Console.WriteLine("\t\tMissing seleniumPageLoadTimeOut info.");
                return _seleniumPageLoadTimeOut;
            }
            set
            {
                _seleniumPageLoadTimeOut = 60;
                Console.WriteLine(@"\t\tMissing seleniumPageLoadTimeOut info. Default to {_seleniumPageLoadTimeOut}");
            }
        }

        public string email
        {
            get
            {
                _email = "venkata.cherakam@outlook.com";
                if (!string.IsNullOrWhiteSpace(_email))
                    return _email;
                else
                    throw new ArgumentNullException("\t\tMissing conatct email info.");
            }
            set
            {
                _email = value;
            }
        }

        public string firstName
        {
            get
            {
                _firstName = "Venkata";
                if (!string.IsNullOrWhiteSpace(_firstName))
                    return _firstName;
                else
                    throw new ArgumentNullException("\t\tMissing first name info.");
            }
            set
            {
                _firstName = value;
            }
        }

        public string lastName
        {
            get
            {
                _lastname = "Cherakam";
                if (!string.IsNullOrWhiteSpace(_lastname))
                    return _lastname;
                else
                    throw new ArgumentNullException("\t\tMissing Last Name info.");
            }
            set
            {
                _lastname = value;
            }
        }

        public string jobTitle
        {
            get
            {
                _jobTitle = "SDET";
                if (!string.IsNullOrWhiteSpace(_jobTitle))
                    return _jobTitle;
                else
                    throw new ArgumentNullException("\t\tMissing Job ttle info.");
            }
            set
            {
                _jobTitle = value;
            }
        }
    }
}