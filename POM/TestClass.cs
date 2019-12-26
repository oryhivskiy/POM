using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{

    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchTextFromPage()
        {
            Test1 test1 = new Test1(driver);
            test1.GeneratedStartPage();
            test1.SwitchToRussian();
            test1.FindWord();
            Assert.IsTrue(test1.Contains(), "Word 'рыба' missing");           
        }

        [Test]
        public void SearchLorem()
        {
            Test2 test2 = new Test2(driver);
            for (int i = 0; i < 10; i++)
            {
                test2.GeneratedStartPage();
                test2.ClickGenerate();
                test2.FindWords();
            }
            Assert.GreaterOrEqual(test2.finalsum / 10, 3, "Averange number of Paragraphs less than 3");
        }

        [Test]
        public void GenerateWords()
        {
            Test3 test3 = new Test3(driver);
            test3.GeneratedStartPage();
            test3.ClickGenerateWords();
            Assert.AreEqual(test3.expectedresult, test3.actualresult, "Error");
        }

        [Test]
        public void GenerateLists()
        {
            Test4 test4 = new Test4(driver);
            test4.GeneratedStartPage();
            test4.ClickGenerateLists();
            Assert.AreEqual(test4.expectedresult, test4.actualresult, "Error");
        }


        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
    

        
