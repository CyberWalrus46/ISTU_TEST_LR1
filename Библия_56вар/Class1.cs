using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.Design;

namespace TestLib
{
    public class ArrayProcessor
    {
        public static (List<int>, long, List<string>) TransformArray(List<int> inputArray)
        {   
            Int32 product = 1;
            List<string> errors = new List<string>();

            if (inputArray == null)
                return (new List<int>(), 0, new List<string> { "Input array is null." });
            if (inputArray.Count == 0)
                return (new List<int>(), 0, new List<string> { "Input array is empty." });
            if (inputArray.Count > 1024)
            {
                errors.Add("Too many elements. Array truncated to 1024");
                inputArray.RemoveRange(1024, inputArray.Count - 1024);
            }

            for (int i = 0; i < inputArray.Count && product != 0; i++)
            {
                try
                {
                    product = checked(product * inputArray[i]);
                }
                catch (OverflowException)
                {
                    product = 0;
                    errors.Add($"The product overflowed when multiplied with {inputArray[i]} at index {i}. The product is set to 0.");
                }
            }


            for (int i = 0; i < inputArray.Count; i++)
            {
                if (inputArray[i] < 0 && inputArray[i] % 2 != 0)
                {
                    try
                    {
                        inputArray[i] = (inputArray[i] - product) * (inputArray[i] - product);
                    }
                    catch (OverflowException)
                    {
                        errors.Add($"Переполнение по индексу {i} для значения {inputArray[i]}.");
                    }
                }
            }

            return (inputArray, product, errors);
        }
    }
}
