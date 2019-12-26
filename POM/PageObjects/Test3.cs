using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.PageObjects
{
    class Test3
    {
        private IWebDriver driver;
        public int actualresult, expectedresult;

        public Test3(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void GeneratedStartPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage("https://www.lipsum.com/");
        }
        [FindsBy(How = How.Id, Using = "amount")]
        private IWebElement Amount;
        [FindsBy(How = How.Id, Using = "words")]
        private IWebElement Words;
        [FindsBy(How = How.Id, Using = "generate")]
        private IWebElement Generate;
        [FindsBy(How = How.Id, Using = "lipsum")]
        private IWebElement Paragraph;
        public void ClickGenerateWords()
        {
            HomePage home = new HomePage(driver);
            for (int i = 0; i < 5; i++)
            {
                string numbers = "20 -1 0 15 50";
                string[] numbersArray = numbers.Split(new char[] { ' ' });
                string result = "20 5 5 15 50";
                string[] resultArray = result.Split(new char[] { ' ' });
                Amount.Clear();
                Amount.SendKeys(numbersArray[i]);
                Words.Click();
                Generate.Click();
                string paragraphText = Paragraph.Text;
                paragraphText = paragraphText.Trim(new char[] { ',', '.' });
                string[] paragraphArray = paragraphText.Split(new char[] { ' ' });
                actualresult = paragraphArray.Length;
                expectedresult = int.Parse(resultArray[i]);
                GeneratedStartPage();
            }
        }
    }
}
