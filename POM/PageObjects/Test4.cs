using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.PageObjects
{
    class Test4
    {
        private IWebDriver driver;
        public int actualresult, expectedresult;
        List<IWebElement> Paragraph;

        public Test4(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GeneratedStartPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage("https://www.lipsum.com/");
        }

        [FindsBy(How = How.Id, Using = "lists")]
        private IWebElement Lists;
        [FindsBy(How = How.Id, Using = "amount")]
        private IWebElement Amount;
        [FindsBy(How = How.Id, Using = "generate")]
        private IWebElement Generate;

        public void ClickGenerateLists()
        {
            HomePage home = new HomePage(driver);
            for (int i = 0; i < 4; i++)
            {
                string numbers = "2 -1 0 5";
                string result = "2 5 5 5";
                string[] numbersArray = numbers.Split(new char[] { ' ' });
                string[] resultArray = result.Split(new char[] { ' ' });
                expectedresult = int.Parse(resultArray[i]);
                Lists.Click();
                Amount.Clear();
                Amount.SendKeys(numbersArray[i]);
                Generate.Click();
                Paragraph = driver.FindElements(By.XPath("//ul")).ToList();
                actualresult = Paragraph.Count;
                GeneratedStartPage();
            }
        }
    }
}
