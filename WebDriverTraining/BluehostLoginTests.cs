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
    public class BluehostLoginTests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://login.bluehost.com/hosting/webemail";
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

            IWebElement userID = _driver.FindElement(By.Id("userId"));
            IWebElement nextButton = _driver.FindElement(By.XPath("//button[contains(@class, 'login-next')]"));
            userID.Clear();
            userID.SendKeys("wronguser");
            nextButton.Click();
            IWebElement password = _driver.FindElement(By.Id("password"));
            password.Clear();
            password.SendKeys("wrongpassword");
            IWebElement nextButton2 = _driver.FindElement(By.XPath("//button[contains(@class, 'login-next')]"));
            nextButton2.Click();
            IWebElement wrongCredentialsMessage = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(@class, 'reg-snackbar-message')]/span")));
            //IWebElement wrongCredentialsMessage = _driver.FindElement(By.XPath("//span[contains(@class, 'reg-snackbar-message')]/span"));
            ClassicAssert.AreEqual("Incorrect user ID and/or password. Please try again.", wrongCredentialsMessage.Text);
        }

        [Test]
        public void Login_When_EmailAndPasswordAreEmpty()
        {
            IWebElement webmailLogin = _driver.FindElement(By.XPath("//div[@role='tab'][@tabindex=-1]"));
            webmailLogin.Click();
            IWebElement emailField = _driver.FindElement(By.Id("emailId"));
            emailField.Clear();
            IWebElement errorMsg = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@role='alert'][contains(@class, 'error')]")));
            ClassicAssert.AreEqual(" Email is not valid ", errorMsg.Text);

        }

        [Test]
        public void VerifyLogin_When_ValidUserIsUsed()
        {
            IWebElement webmailLogin = _driver.FindElement(By.XPath("//div[@role='tab'][@tabindex=-1]"));
            webmailLogin.Click();
            IWebElement emailField = _driver.FindElement(By.Id("emailId"));
            emailField.Clear();
            IWebElement errorMsg = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@role='alert'][contains(@class, 'error')]")));
            ClassicAssert.AreEqual(" Email is not valid ", errorMsg.Text);

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