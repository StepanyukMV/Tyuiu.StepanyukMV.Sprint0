using Tyuiu.StepanyukMV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.StepanyukMV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Михаил";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Михаил", res);
        }
    }
}