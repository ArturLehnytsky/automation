using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {


        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();



        static void Main(string[] args)
        {
      
        }


        [SetUp]
        public void Initialize()
        {
            //Navigate to Execute automation demo test
            driver.Navigate().GoToUrl("https://roboshop.com.ua/create-account/");
            Console.WriteLine("Opened URL");
        }
        
        [Test]    
        public void ExecuteTest()
        {

            //Name
            SeleniumSetMethods.EnterText(driver, "firstname", "Kolyan", "name");

            //Last Name
            SeleniumSetMethods.EnterText(driver, "lastname", "Kolyanich", "name");

          /*  //Click
            SeleniumSetMethods.Click(driver, "oct-button", "class");
           */ 
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }


    /*    [TearDown]
        public void CleanUp()
        {
            driver.Close();

            Console.WriteLine("Closed the Browser");         
        }
        */
    }
}
