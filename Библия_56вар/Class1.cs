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
                    checked { product = checked(product * inputArray[i]);  }
                    //product = checked(product * inputArray[i]);
                    //long a = product * inputArray[i];
                    //if (a > -2147483648 && a < 2147483647)
                    //    product = (int)a;
                    //else
                    //    throw new OverflowException();
                }
                catch(OverflowException) 
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
                        checked { inputArray[i] = (inputArray[i] - product) * (inputArray[i] - product); }
                        //inputArray[i] = checked((inputArray[i] - product) * (inputArray[i] - product));
                        //long a = (inputArray[i] - product) * (inputArray[i] - product);
                        //if (a < -2147483648 || a > 2147483647)
                        //    throw new OverflowException();
                        //else
                        //    inputArray[i] = (int)a;
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
