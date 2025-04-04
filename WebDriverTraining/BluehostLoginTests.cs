using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
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
        public void VerifyValidationMessageIsDisplayed_When_WrongEmailAndPasswordAreEnteredForHostingLogin()
        {
            AcceptCookies(_driver, _wait);
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
            Assert.That(wrongCredentialsMessage.Text, Is.EqualTo("Incorrect user ID and/or password. Please try again."));
        }

        [Test]
        public void VerifyValidationMessageIsDisplayedForWebMailLogin_When_InvalidEmailIsUsed()
        {
            AcceptCookies(_driver, _wait);
            IWebElement webmailLogin = _driver.FindElement(By.XPath("//div[@role='tab'][@tabindex=-1]"));
            webmailLogin.Click();
            IWebElement emailField = _driver.FindElement(By.Id("emailId"));
            emailField.Clear();
            emailField.SendKeys("invalidEmail");
            emailField.SendKeys(Keys.Tab);
            IWebElement logInbutton = _driver.FindElement(By.XPath("//button[contains(@class, 'login-next')]"));
            ClassicAssert.IsFalse(logInbutton.Enabled);

        }

        [Test]
        public void VerifyValidationMessageIsDisplayedWebMailLogin_When_EmailIsEmpty()
        {
            AcceptCookies(_driver, _wait);
            IWebElement webmailLogin = _driver.FindElement(By.XPath("//div[@role='tab'][@tabindex=-1]"));
            webmailLogin.Click();
            IWebElement emailField = _driver.FindElement(By.Id("emailId"));
            emailField.Clear();
            emailField.SendKeys(Keys.Tab);
            IWebElement errorMsg = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@role='alert'][contains(@class, 'error')]")));
            Assert.That(errorMsg.Text, Is.EqualTo("Email is not valid"));
        }

        [Test]
        public void VerifyNextButtonIsDisabledForHostingLogin_When_UserIdIsEmpty()
        {
            AcceptCookies(_driver, _wait);
            IWebElement userId = _driver.FindElement(By.Id("userId"));
            userId.Clear();
            userId.SendKeys(Keys.Tab);
            IWebElement nextButton = _driver.FindElement(By.XPath("//button[contains(@class, 'login-next')]"));
            ClassicAssert.IsFalse(nextButton.Enabled);
        }
        private void AcceptCookies(IWebDriver driver, WebDriverWait wait)
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@id='onetrust-accept-btn-handler']")));
            IWebElement gotItButton = driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']"));
            Actions action = new Actions(_driver);
            action.MoveToElement(gotItButton).Perform();
            gotItButton.Click();
        }
        public void CreateEvent_When_UserIsLoggedIn()
        {
            IWebElement webmailLogin = _driver.FindElement(By.XPath("//div[@role='tab'][@tabindex=-1]"));
            webmailLogin.Click();
            IWebElement emailField = _driver.FindElement(By.Id("emailId"));
            emailField.Clear();
            IWebElement errorMsg = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@role='alert'][contains(@class, 'error')]")));
            Assert.That(errorMsg.Text, Is.EqualTo(" Email is not valid "));

        }
    }
}