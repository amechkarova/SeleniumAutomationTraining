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
    public class GoogleTests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://www.google.com";
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
        [Test]
        public void VerifyValidationMessageIsDisplayed_When_WrongEmailAndPasswordAreEntered()
        {

            //IWebElement logInButton = _driver.FindElement(By.XPath("//a[contains(@href, 'Login')]"));
            //logInButton.Click();
            //IWebElement emailField = _driver.FindElement(By.XPath("//input[@type='email']"));
            //emailField.Clear();
            //emailField.SendKeys("testnemm@gmail.com");
            //IWebElement passwordField = _driver.FindElement(By.XPath("//input[@type='password']"));
            //passwordField.Clear();
            //passwordField.SendKeys("nemtest1234");
            IWebElement googleApps = _driver.FindElement(By.XPath("//a[@tabindex=0]"));
            IWebElement eightAMslot = _driver.FindElement(By.XPath("//div[@class='GENA3c']//div/span[contains(text(), '8 am')]"));

            //IWebElement wrongCredentialsMessage = _driver.FindElement(By.XPath("//span[contains(@class, 'reg-snackbar-message')]/span"));
            //ClassicAssert.AreEqual("Incorrect user ID and/or password. Please try again.", wrongCredentialsMessage.Text);
        }

        public void CreateEvent_When_UserIsLoggedIn()
        {
            IWebElement webmailLogin = _driver.FindElement(By.XPath("//div[@role='tab'][@tabindex=-1]"));
            webmailLogin.Click();
            IWebElement emailField = _driver.FindElement(By.Id("emailId"));
            emailField.Clear();
            IWebElement errorMsg = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@role='alert'][contains(@class, 'error')]")));
            ClassicAssert.AreEqual(" Email is not valid ", errorMsg.Text);

        }
    }
}