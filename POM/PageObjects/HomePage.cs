using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace POM.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;
        private IWebElement element;
        private string text;
        private string [] elements = new string[5];
        public int finalsum;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToPage(string URL)
        {
            driver.Navigate().GoToUrl($"{URL}");
        }
       
        public void FindElementByXpath5()
        {
            for (int j = 0; j < 5; j++)
            {
                element = driver.FindElement(By.XPath($"//p[{j+1}]"));
                elements[j] = element.Text;
            }
            
        }
        public void Contains2(string Lorem, string lorem)
        {
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                if (elements[i].Contains(Lorem) || elements[i].Contains(lorem))
                {
                    sum += 1;
                }
                finalsum += sum;
            }
        }
        public bool Contains(string word, string text)
        {
            return text.Contains($"{word}");
        }
    }
}