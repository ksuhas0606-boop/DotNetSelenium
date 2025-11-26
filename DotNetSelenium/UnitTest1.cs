using DotNetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotNetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateSignUpUserText()
        {
            IWebDriver driver = new ChromeDriver();
            int a;
            try
            {
                // Navigate to login page
                driver.Navigate().GoToUrl("https://automationexercise.com/login");

                // Maximize window
                driver.Manage().Window.Maximize();

                System.Threading.Thread.Sleep(2000);

                IWebElement signupuser = driver.FindElement(By.XPath("//h2[normalize-space()='New User Signup!']"));

                string actualtext = signupuser.Text;

                if (actualtext.Equals("New ser signup!", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Validation Passed: 'New User Signup!' text is present.");
                }
                else
                {
                    Console.WriteLine($"Validation Failed: Expected 'New User Signup!', But Found {actualtext}");
                }


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Validation Failed: 'New User Signup!' text is Not present.");
            }
            driver.Close();
        }

        [Test]
        public void NewUserRegister()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                // Navigate to login page
                driver.Navigate().GoToUrl("https://automationexercise.com/login");

                // Maximize window
                driver.Manage().Window.Maximize();

                System.Threading.Thread.Sleep(2000);

                LoginPage.SignUpName(driver,By.XPath("//input[@placeholder='Name']"), "Suhask");

                LoginPage.SignUpEmail(driver, By.XPath("//input[@placeholder='Name']"), "SuhasK");
               

                /*IWebElement entername = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
                IWebElement enterEmail = driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));

                entername.SendKeys("SuhasK");
                enterEmail.SendKeys("ksuhas0606@gmail.com");

                IWebElement button = driver.FindElement(By.XPath("//button[normalize-space()='Signup']"));
                button.Click();

                IWebElement headertext = driver.FindElement(By.XPath("//b[normalize-space()='Enter Account Information']"));
                string actualtext = headertext.Text;

                actualtext.Equals("Enter Account Information", StringComparison.OrdinalIgnoreCase);*/
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Internal Error");
            }
            driver.Close(); 
        }
        [Test]
        public void LoginUserwithincorrectemailandpassword()
        {

        }
    }
}