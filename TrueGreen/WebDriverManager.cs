using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruGreen
{
    public class WebDriverManager
    {
        private IWebDriver driver;
        private static WebDriverManager instance = null;
        private WebDriverManager()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public static WebDriverManager Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new WebDriverManager();
                }
                return instance;
            }
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        // Public method to quit the WebDriver instance
        public void QuitDriver()
        {
            driver.Quit();
            driver = null; // Optional: Set driver to null
            instance = null; // Optional: Reset instance to null
        }

    }
}
