
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Тесты по информационному графу
namespace TestLib.Tests
{
    public class InfoGraphTests
    {
        [Theory]
        [MemberData(nameof(TestDataProvider.InfoGraph_TV1Data), MemberType = typeof(TestDataProvider))]
        public void InfoGraph_TV1(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.InfoGraph_TV2Data), MemberType = typeof(TestDataProvider))]
        public void InfoGraph_TV2(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.InfoGraph_TV7Data), MemberType = typeof(TestDataProvider))]
        public void InfoGraph_TV7(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.InfoGraph_TV8Data), MemberType = typeof(TestDataProvider))]
        public void InfoGraph_TV8(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }

        [Theory]
        [MemberData(nameof(TestDataProvider.InfoGraph_TV9Data), MemberType = typeof(TestDataProvider))]
        public void InfoGraph_TV9(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }
    }
}
