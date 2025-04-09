using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Тесты областей эквивалентности
namespace TestLib.Tests
{
    public class EquivalenceTests
    {
        [Theory]
        [MemberData(nameof(TestDataProvider.IsNull), MemberType = typeof(TestDataProvider))]
        public void IsNull(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.IsEmpty), MemberType = typeof(TestDataProvider))]
        public void IsEmpty(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOneElement), MemberType = typeof(TestDataProvider))]
        public void HasOneElement(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.MoreThanOneElement), MemberType = typeof(TestDataProvider))]
        public void MoreThanOneElement(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.OnlyZero), MemberType = typeof(TestDataProvider))]
        public void OnlyZero(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.OnlyOne), MemberType = typeof(TestDataProvider))]
        public void OnlyOne(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.OnlyNegativeOne), MemberType = typeof(TestDataProvider))]
        public void OnlyNegativeOne(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.OnlyMaxValue), MemberType = typeof(TestDataProvider))]
        public void OnlyMaxValue(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.OnlyMinValue), MemberType = typeof(TestDataProvider))]
        public void OnlyMinValue(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasMaxValue), MemberType = typeof(TestDataProvider))]
        public void HasMaxValue(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasNotMaxValue), MemberType = typeof(TestDataProvider))]
        public void HasNotMaxValue(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasMinValue), MemberType = typeof(TestDataProvider))]
        public void HasMinValue(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasNotMinValue), MemberType = typeof(TestDataProvider))]
        public void HasNotMinValue(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.Has1023Elements), MemberType = typeof(TestDataProvider))]
        public void Has1023Elements(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.Has1024Elements), MemberType = typeof(TestDataProvider))]
        public void Has1024Elements(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.Has1025Elements), MemberType = typeof(TestDataProvider))]
        public void Has1025Elements(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyZeros), MemberType = typeof(TestDataProvider))]
        public void HasOnlyZeros(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyPositiveValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyPositiveValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyNegativeValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyNegativeValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyPositiveEvenEqualValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyPositiveEvenEqualValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyNegativeEvenEqualValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyNegativeEvenEqualValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyPositiveOddEqualValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyPositiveOddEqualValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyNegativeOddEqualValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyNegativeOddEqualValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyPositiveEvenValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyPositiveEvenValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyPositiveOddValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyPositiveOddValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyNegativeEvenValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyNegativeEvenValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.HasOnlyNegativeOddValues), MemberType = typeof(TestDataProvider))]
        public void HasOnlyNegativeOddValues(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }
    }
}
