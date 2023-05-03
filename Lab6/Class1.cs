using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab6
{
    [TestFixture]

    public class Class1
    {
        IWebDriver driver = new ChromeDriver();
        [TestCase]
        public void Maintitle()
        {
            driver.Url = "http://www.sibstrin.ru/";

             Assert.AreEqual("Новосибирский государственный архитектурно - строительный университет - Сибстрин", driver.Title);
            driver.Close();
        }
        [TestCase]
        public bool Isvisible()
        {
            driver.Url = "http://www.sibstrin.ru/";

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[2]/div[1]/a/img"));
            bool status = element.Displayed;
            driver.Close();
            return status;
        }
        [TestCase]
        public void SsilkaClick()
        {
            driver.Url = "http://www.sibstrin.ru/";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[2]/div[2]/p/a[1]"));
            element.Click();
            driver.Close();
        }
        [TestCase]
        public void TextInput()
        {
            driver.Url = "https://univer.sibstrin.ru/user/sign-in/login?_referrer=%2Fsite%2Findex";

            IWebElement element = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/div[2]/form/div[1]/input"));
            element.SendKeys("Гайворонских Андрей Алексеевич");
            driver.Close();

        }
        [TestCase]
        public void ButtonClick()
        {
            driver.Url = "http://www.sibstrin.ru/";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/nav/ul/li[2]/a"));
            element.Click();
            driver.Close();
        }
        [TearDown]
        public void TestEnd()
        {
            driver.Quit();
        }
    }
}
