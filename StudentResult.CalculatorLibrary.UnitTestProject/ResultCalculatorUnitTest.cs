using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StudentResult.CalculatorLibrary;
using Moq;


// Right BICEP




namespace StudentResult.CalculatorLibrary.UnitTestProject
{
    [TestClass]
    public class ResultCalculatorUnitTest
    {
        ResultCalculator target = null;
        [TestInitialize]
        public void Init()
        {
            target = new ResultCalculator();
        }
        [TestCleanup]
        public void Clear()
        {
            target = null;
        }


        [TestMethod]
        public void FindTotalMarksTest_WithValidMarks_ShouldGetTotalMarks()
        {
            // AAA
            // A - Arrange
            int m1 = 10;
            int m2 = 10;
            int m3 = 10;
            int expected = 30;
            //ResultCalculator target = new ResultCalculator();

            // A - Act
            int actual = target.FindTotalMarks(m1, m2, m3);
            // A - Assert
            //if(expected == actual)

            // do not write
            // conditional/looping/try..catch
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMarksException))]
        public void FindTotalMarksTest_WithNoMarks_ShouldThrowExp()
        {
            //ResultCalculator target = new ResultCalculator();
            target.FindTotalMarks(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMarksException))]
        public void FindTotalMarksTest_WithNegativeMarks_ShouldThrowExp()
        {
            //ResultCalculator target = new ResultCalculator();
            target.FindTotalMarks(10,-10,10);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMarksException))]
        public void FindTotalMarksTest_WithMoreThan100Marks_ShouldThrowExp()
        {
            //ResultCalculator target = new ResultCalculator();
            target.FindTotalMarks(10,10,110);
        }


        [TestMethod]
        public void FindResultTest_WithAvg60AndAbove_ShouldReturnFirstClass()
        {
            Mock<INotification> mock = new Mock<INotification>();
            mock.Setup(m => m.Notify("First Class"));

            ResultCalculator target = new ResultCalculator(mock.Object);
            string actual = target.FindResult(66);
            Assert.AreEqual("First Class", actual);
        }

        [TestMethod]
        public void FindResultTest_WithAvg60AndAbove_ShouldReturnFirstClassAndAlsoCallNotify()
        {
            Mock<INotification> mock = new Mock<INotification>();
            mock.Setup(m => m.Notify("First Class"));

            ResultCalculator target = new ResultCalculator(mock.Object);
            string actual = target.FindResult(66);
            mock.Verify(m => m.Notify("First Class"),Times.AtLeastOnce());
        }
    }

    //class MockMailNotification : INotification
    //{
    //    public void Notify(string msg)
    //    {

    //    }
    //}

    // Mocking frameworks
    // Moq
    // Castle
    // ninject
    // structured map
}
