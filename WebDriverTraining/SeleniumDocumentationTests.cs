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
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
        [Test]
        public void CorrectPagesIsLoaded_When_ComponentsIsClickedInLeftNavigationBar()
        {
            NavigateToUrl("https://www.selenium.dev/documentation/webdriver/getting_started");
            IWebElement gridAnchor = _driver.FindElement(By.Id("m-documentationgrid"));

            //gridAnchor.Click();
            //when the test is executed on a small screen and there is a scroll on the page
            //the grid link is not visible, therefore one of the solutions is to
            //move to the element and then click it
            MoveToElementAndClick(gridAnchor);

            IWebElement componentAnchor = _driver.FindElement(By.Id("m-documentationgridcomponents"));
            componentAnchor.Click();
            CorrectPageIsLoadedUrl("https://www.selenium.dev/documentation/grid/components/", _driver);

            IWebElement h1Title = _driver.FindElement(By.TagName("h1"));
            CorrectPageIsLoaded("Selenium Grid Components", h1Title.Text);
            
        }

        [Test]
        public void CorrectPageIsLoaded_When_GitHubLinkIsCliked()
        {
            NavigateToUrl("https://www.selenium.dev/documentation/grid/components/");
            IWebElement githubRepoLink = _driver.FindElement(By.XPath("//footer//a[contains(@href, 'github')]"));
            MoveToElementAndClick(githubRepoLink);
            CorrectPageIsLoadedUrl("https://github.com/seleniumhq/selenium", _driver);
            IWebElement h1Title = _driver.FindElement(By.XPath("//a[contains(@href, 'selenium.dev')]//parent::h1"));
            CorrectPageIsLoaded("Selenium", h1Title.Text);

        }

        private void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        private void MoveToElementAndClick(IWebElement element)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element).Perform();
            element.Click();
        }

        private void CorrectPageIsLoaded(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected));
        }

        private void CorrectPageIsLoadedUrl(string expected, IWebDriver driver)
        {
            List<string> browserTabs = new List<string>(driver.WindowHandles);
            if(browserTabs.Count != 1)
            {
                driver.SwitchTo().Window(browserTabs[1]);
            }
            Assert.That(driver.Url, Is.EqualTo(expected));
        }
    }
}