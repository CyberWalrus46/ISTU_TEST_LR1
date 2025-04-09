using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLib.Tests
{
    public class UnitTest1
    {
        public class ArrayProcessorTests
        {
            //[Fact]
            //public void TransformArray_ValidInput_ReturnsExpectedResult()
            //{
            //    List<int> input = new List<int> { -3, -2, -1, 0, 1, 2, 3 };
            //    var expectedArray = new List<int> { 9, -2, 1, 0, 1, 2, 3 };
            //    long expectedProduct = 0; // Product of 0
            //    List<string> expectedErrors = new List<string>();

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}

            //[Fact]
            //public void TransformArray_NullInput_ReturnsError()
            //{
            //    List<int> input = null;
            //    var expectedArray = Array.Empty<int>();
            //    long expectedProduct = 0;
            //    List<string> expectedErrors = new List<string> { "Input array is null." };

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}

            //[Fact]
            //public void TransformArray_ValidInput_ReturnsExpectedResult_OnlyNegativeValue()
            //{
            //    List<int> input = new List<int> { -3, -2, -1 };
            //    var expectedArray = new List<int> { -27, -2, -35 };
            //    long expectedProduct = -6; // Product of -3, -2, -1
            //    List<string> expectedErrors = new List<string>();

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}

            //[Fact]
            //public void TransformArray_ValidInput_ReturnsExpectedResult_OnlyPositiveValue()
            //{
            //    List<int> input = new List<int> { 3, 2, 1 };
            //    var expectedArray = new List<int> { 3, 2, 1 };
            //    long expectedProduct = 6; // Product of 3, 2, 1
            //    List<string> expectedErrors = new List<string>();

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}

            //[Fact]
            //public void TransformArray_ValidInput_ReturnsExpectedResult_OneNegativeValue()
            //{
            //    List<int> input = new List<int> { -3};
            //    var expectedArray = new List<int> { 0 };
            //    long expectedProduct = -3; // Product of -3
            //    List<string> expectedErrors = new List<string>();

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}

            //[Fact]
            //public void TransformArray_ValidInput_ReturnsExpectedResult_OnePositiveValue()
            //{
            //    List<int> input = new List<int> { 3 };
            //    var expectedArray = new List<int> { 3 };
            //    long expectedProduct = 3; // Product of 3
            //    List<string> expectedErrors = new List<string>();

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}

            //[Fact]
            //public void TransformArray_ValidInput_ReturnsExpectedResult_SomeValue()
            //{
            //    List<int> input = new List<int> { -3, -99999999, -999999999, 9999999, 999999 };
            //    var expectedArray = new List<int> { 9, 1674919425, 808348673, 9999999, 999999 };
            //    long expectedProduct = 0; // Product of 3
            //    List<string> expectedErrors = new List<string> ();
            //    expectedErrors.Add("The product overflowed when multiplied with -999999999 at index 2. The product is set to 0");

            //    var result = ArrayProcessor.TransformArray(input);

            //    Assert.Equal(expectedArray, result.Item1);
            //    Assert.Equal(expectedProduct, result.Item2);
            //    Assert.Equal(expectedErrors, result.Item3);
            //}
        }
    }
}