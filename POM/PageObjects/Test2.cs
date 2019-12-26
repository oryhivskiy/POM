using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.PageObjects
{
    class Test2
    {
        private IWebDriver driver;
        public int finalsum;
        public Test2(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void GeneratedStartPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage("https://www.lipsum.com/");
        }
        [FindsBy(How = How.Id, Using = "generate")]
        private IWebElement Generate;
        public void ClickGenerate()
        {
            Generate.Click();
        }
        public void FindWords()
        {
            HomePage home = new HomePage(driver);
            home.FindElementByXpath5();
            home.Contains2("Lorem", "lorem");
            finalsum += home.finalsum;
        }
        
    }
}
