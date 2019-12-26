using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.PageObjects
{
    class Test1
    {
        private IWebDriver driver;
        private string word;
        public Test1(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GeneratedStartPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage("https://www.lipsum.com/");
        }
        [FindsBy(How = How.XPath, Using = "//a[30]")]
        private IWebElement Russian;
        public void SwitchToRussian()
        {
            Russian.Click();
        }
        [FindsBy(How = How.XPath, Using = "//p")]
        private IWebElement Word;
        public void FindWord()
        {
            word = Word.Text;
        }
        public bool Contains()
        {
            HomePage home = new HomePage(driver);
            return home.Contains("рыба", word);
        }
    }
}
