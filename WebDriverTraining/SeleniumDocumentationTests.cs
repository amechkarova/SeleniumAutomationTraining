using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

namespace WebDriverTraining
{
    [TestFixture]
    public class SeleniumDocumentationTests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver,TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
        [Test]
        public void CorrectPagesAreLoaded()
        {
            _driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/getting_started");
            IWebElement gridAnchor = _driver.FindElement(By.Id("m-documentationgrid"));
            //gridAnchor.Click();
            //when the test is executed on a smalled screen and there is a scroll on the page
            //the grid link is not visible, therefore one of the solutions is to
            //move to the element and than click it
            Actions actions = new Actions(_driver);
            actions.MoveToElement(gridAnchor).Perform();
            gridAnchor.Click();

            IWebElement componentAnchor = _driver.FindElement(By.Id("m-documentationgridcomponents"));
            componentAnchor.Click();

            ClassicAssert.AreEqual("https://www.selenium.dev/documentation/grid/components/", _driver.Url);

            IWebElement h1Title = _driver.FindElement(By.TagName("h1"));
            ClassicAssert.AreEqual("Selenium Grid Components", h1Title.Text);
        }
    }
}