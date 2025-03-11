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
            [Fact]
            public void TransformArray_ValidInput_ReturnsExpectedResult()
            {
                int[] input = { -3, -2, -1, 0, 1, 2, 3 };
                var expectedArray = new int[] { 9, -2, 1, 0, 1, 2, 3 };
                long expectedProduct = 0; // Product of 0
                List<string> expectedErrors = new List<string>();

                var result = ArrayProcessor.TransformArray(input);

                Assert.Equal(expectedArray, result.Item1);
                Assert.Equal(expectedProduct, result.Item2);
                Assert.Equal(expectedErrors, result.Item3);
            }

            [Fact]
            public void TransformArray_NullInput_ReturnsError()
            {
                int[] input = null;
                var expectedArray = Array.Empty<int>();
                long expectedProduct = 0;
                List<string> expectedErrors = new List<string> { "Input array is null." };

                var result = ArrayProcessor.TransformArray(input);

                Assert.Equal(expectedArray, result.Item1);
                Assert.Equal(expectedProduct, result.Item2);
                Assert.Equal(expectedErrors, result.Item3);
            }

            [Fact]
            public void TransformArray_ValidInput_ReturnsExpectedResult_OnlyNegativeValue()
            {
                int[] input = { -3, -2, -1 };
                var expectedArray = new int[] { -27, -2, -35 };
                long expectedProduct = -6; // Product of -3, -2, -1
                List<string> expectedErrors = new List<string>();

                var result = ArrayProcessor.TransformArray(input);

                Assert.Equal(expectedArray, result.Item1);
                Assert.Equal(expectedProduct, result.Item2);
                Assert.Equal(expectedErrors, result.Item3);
            }

            [Fact]
            public void TransformArray_ValidInput_ReturnsExpectedResult_OnlyPositiveValue()
            {
                int[] input = { 3, 2, 1 };
                var expectedArray = new int[] { 3, 2, 1 };
                long expectedProduct = 6; // Product of 3, 2, 1
                List<string> expectedErrors = new List<string>();

                var result = ArrayProcessor.TransformArray(input);

                Assert.Equal(expectedArray, result.Item1);
                Assert.Equal(expectedProduct, result.Item2);
                Assert.Equal(expectedErrors, result.Item3);
            }

            [Fact]
            public void TransformArray_ValidInput_ReturnsExpectedResult_OneNegativeValue()
            {
                int[] input = { -3};
                var expectedArray = new int[] { 0 };
                long expectedProduct = -3; // Product of -3
                List<string> expectedErrors = new List<string>();

                var result = ArrayProcessor.TransformArray(input);

                Assert.Equal(expectedArray, result.Item1);
                Assert.Equal(expectedProduct, result.Item2);
                Assert.Equal(expectedErrors, result.Item3);
            }

            [Fact]
            public void TransformArray_ValidInput_ReturnsExpectedResult_OnePositiveValue()
            {
                int[] input = { 3 };
                var expectedArray = new int[] { 3 };
                long expectedProduct = 3; // Product of 3
                List<string> expectedErrors = new List<string>();

                var result = ArrayProcessor.TransformArray(input);

                Assert.Equal(expectedArray, result.Item1);
                Assert.Equal(expectedProduct, result.Item2);
                Assert.Equal(expectedErrors, result.Item3);
            }
        }
    }
}