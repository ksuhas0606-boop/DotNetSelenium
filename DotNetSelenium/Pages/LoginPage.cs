using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Pages
{
    internal class LoginPage
    {
        public static void signUpName(IWebDriver driver,By locator, String uname)
        {
            driver.FindElement(locator).SendKeys(uname);
        }
        public static void signUpEmail(IWebDriver driver, By locator, String pass)
        {
            driver.FindElement(locator).SendKeys(pass);
        }
    }
}
