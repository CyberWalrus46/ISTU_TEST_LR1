using System.Collections.Generic;
using System.Linq;
using System;

namespace TestLib
{
    public class ArrayProcessor
    {
        public static (int[], long, List<string>) TransformArray(int[] inputArray)
        {
            if (inputArray == null)
                return (Array.Empty<int>(), 0, new List<string> { "Input array is null." });

            long product = 1;
            List<string> errors = new List<string>();

            foreach (var number in inputArray)
            {
                product *= number;
                if (product == 0)
                    break;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < 0 && inputArray[i] % 2 != 0)
                {
                    try
                    {
                        inputArray[i] = (inputArray[i] - (int)product) * (inputArray[i] + (int)product);
                    }
                    catch (OverflowException)
                    {
                        errors.Add($"Overflow occurred at index {i} for value {inputArray[i]}.");
                    }
                }
            }

            return (inputArray, product, errors);
        }
    }
}
