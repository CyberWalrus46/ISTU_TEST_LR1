using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;


// Дата провайдер
namespace TestLib.Tests
{
    public class TestData
    {
        public string name { get; set; }
        public List<int> array { get; set; }
        public List<int> expectedArray { get; set; }
        public int expectedProduct { get; set; }
        public List<string> expectedErrors { get; set; }
    }

    public static class TestDataProvider
    {
        public static IEnumerable<object[]> GetTestData(string testCaseName)
        {
            //string path = Path.Combine("resources", "test_cases.json");
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "test_cases.json");
            string json = File.ReadAllText(filePath);
            List<TestData> testCases = JsonSerializer.Deserialize<List<TestData>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals
            });

            if (testCases == null) throw new Exception("Error: Json file is empty or contains incorrect data.");

            var testCase = testCases.Find(tc => tc.name == testCaseName);

            if (testCase != null)
            {
                yield return new object[]
                {
                     testCase.array,
                     testCase.expectedArray,
                     testCase.expectedProduct,
                     testCase.expectedErrors
                };
            }
        }

        public static IEnumerable<object[]> IsNull() => GetTestData("EQ1");
        public static IEnumerable<object[]> IsEmpty() => GetTestData("EQ2");
        public static IEnumerable<object[]> HasOneElement() => GetTestData("EQ3");
        public static IEnumerable<object[]> MoreThanOneElement() => GetTestData("EQ4");
        public static IEnumerable<object[]> OnlyZero() => GetTestData("EQ5");
        public static IEnumerable<object[]> OnlyOne() => GetTestData("EQ6");
        public static IEnumerable<object[]> OnlyNegativeOne() => GetTestData("EQ7");
        public static IEnumerable<object[]> OnlyMaxValue() => GetTestData("EQ8");
        public static IEnumerable<object[]> OnlyMinValue() => GetTestData("EQ9");
        public static IEnumerable<object[]> HasMaxValue() => GetTestData("EQ10");
        public static IEnumerable<object[]> HasNotMaxValue() => GetTestData("EQ11");
        public static IEnumerable<object[]> HasMinValue() => GetTestData("EQ12");
        public static IEnumerable<object[]> HasNotMinValue() => GetTestData("EQ13");
        public static IEnumerable<object[]> Has1023Elements() => GetTestData("EQ14");
        public static IEnumerable<object[]> Has1024Elements() => GetTestData("EQ15");
        public static IEnumerable<object[]> Has1025Elements() => GetTestData("EQ16");
        public static IEnumerable<object[]> HasOnlyZeros() => GetTestData("EQ17");
        public static IEnumerable<object[]> HasOnlyPositiveValues() => GetTestData("EQ18");
        public static IEnumerable<object[]> HasOnlyNegativeValues() => GetTestData("EQ19");
        public static IEnumerable<object[]> HasOnlyPositiveEvenEqualValues() => GetTestData("EQ20");
        public static IEnumerable<object[]> HasOnlyNegativeEvenEqualValues() => GetTestData("EQ21");
        public static IEnumerable<object[]> HasOnlyPositiveOddEqualValues() => GetTestData("EQ22");
        public static IEnumerable<object[]> HasOnlyNegativeOddEqualValues() => GetTestData("EQ23");
        public static IEnumerable<object[]> HasOnlyPositiveEvenValues() => GetTestData("EQ24");
        public static IEnumerable<object[]> HasOnlyPositiveOddValues() => GetTestData("EQ25");
        public static IEnumerable<object[]> HasOnlyNegativeEvenValues() => GetTestData("EQ26");
        public static IEnumerable<object[]> HasOnlyNegativeOddValues() => GetTestData("EQ27");

        public static IEnumerable<object[]> StreamGraph_TV1Data() => GetTestData("TV1");
        public static IEnumerable<object[]> StreamGraph_TV2Data() => GetTestData("TV2");
        public static IEnumerable<object[]> StreamGraph_TV7Data() => GetTestData("TV7");
        public static IEnumerable<object[]> StreamGraph_TV8Data() => GetTestData("TV8");
        public static IEnumerable<object[]> StreamGraph_TV9Data() => GetTestData("TV9");

        public static IEnumerable<object[]> InfGraph_TV1Data() => GetTestData("PV1");
        public static IEnumerable<object[]> InfGraph_TV2Data() => GetTestData("PV2");
    }
}