namespace CLHomeWorkDay1.Tests
{
    using System.Linq;
    using ExpectedObjects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void GroupByCostSumTest()
        {   // 3筆一，取Cost總和 結果值為 6,15,24,21
            // arrange
            var target = new Calculator();
            var data = ProductFactory.GetProducts();
            var expected = new int[] { 6 , 15 , 24 , 21 };

            // act
            var actual = target.GroupSum(3 , data , (f) => f.Cost);

            // assert
            expected.ToExpectedObject().ShouldEqual(actual.ToArray());
        }

        [TestMethod()]
        public void GroupByRevenueSumTest()
        {   // 4筆一，取Revenue總和 結果值為 50,66,60
            // arrange
            var target = new Calculator();
            var data = ProductFactory.GetProducts();
            var expected = new int[] { 50 , 66 , 60 };

            // act
            var actual = target.GroupSum(4 , data , (f) => f.Revenue);

            // assert
            expected.ToExpectedObject().ShouldEqual(actual.ToArray());
        }
    }
}