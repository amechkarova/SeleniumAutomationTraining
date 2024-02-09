using AutomateThePlanetTraining.Library;

namespace MyFirstMsTestProject
{
    [TestClass]
    public class MyFirstTestClass
    {
        private static GoldenEditionBook _goldenEditionBook;
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _goldenEditionBook = new GoldenEditionBook("Design Patterns", "Anton", "Angelov", 10);
        }
        [TestMethod]
        public void Check30PercentageRequirement()
        {
            Assert.AreEqual(13, _goldenEditionBook.Price, "The price was not as expected.");
        }
        [TestMethod]
        public void AuthorPropertySetSuccessfully()
        {
            Assert.AreEqual("Anto", _goldenEditionBook.FirstName);
        }
        [TestMethod]
        public void TitlePropertySetSuccessfully()
        {
            Assert.AreEqual("Design Patterns", _goldenEditionBook.Title);
        }
    }
}