using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Repo_1234.Pages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
            //Login page object initilization and definitation
            Login_Page loginpageobj = new Login_Page();
            loginpageobj.LoginSteps(driver);

            //Home page object initilization and definitation
            Home_page homepageObj = new Home_page();
            homepageObj.GoToTMPage(driver);

            //TM page object initilization and definitations
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.CreateTM(driver);




        }
    }
}