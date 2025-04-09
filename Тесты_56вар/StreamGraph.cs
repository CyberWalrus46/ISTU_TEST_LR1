
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib.Tests
{
    public class StreamGraphTests
    {
        [Theory]
        [MemberData(nameof(TestDataProvider.StreamGraph_TV1Data), MemberType = typeof(TestDataProvider))]
        public void StreamGraph_TV1(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }
        [Theory]
        [MemberData(nameof(TestDataProvider.StreamGraph_TV2Data), MemberType = typeof(TestDataProvider))]
        public void StreamGraph_TV2(List<int> arr, List<int> expectedArray, int expectedProduct, List<string> expectedErrors)
        {
            var result = ArrayProcessor.TransformArray(arr);

            Assert.Equal(expectedArray, result.Item1);
            Assert.Equal(expectedErrors, result.Item3);
            Assert.Equal(expectedProduct, result.Item2);
        }
    }
}
