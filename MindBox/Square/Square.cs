using System;
using System.Linq;
using System.Collections.Generic;

namespace MindBox
{
    public static class Square
    {
        /// <summary>
        /// Get circle or triangle square.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static double Get(params double[] values) // Сan be done with different static methods 
        {

            #region null parameters

            if (values.Length == 0)
                return 0;

            #endregion

            #region 1 parameter for circle square

            if (values.Length == 1)
                return Math.Round(Math.PI * Math.Pow(values[0], 2), 5);

            #endregion

            #region 3 parameters for triangle square

            if (values.Length == 3)
            {
                if (!((values[0] + values[1] > values[2]) 
                    && (values[0] + values[2] > values[1]) 
                    && (values[1] + values[2] > values[0])))
                    throw new Exception("Triangle does not exist!");

                double p = (values.Sum()) / 2; //semi-perimeter

                var nums = new List<double>(); //list for just because
                foreach (var value in values)
                {
                    nums.Add(Math.Pow(value, 2));
                }
                nums.Sort();
                nums.Reverse();
                Console.WriteLine($"Triangle is {(nums[0] == nums[1] + nums[2] ? "" : "not")} rectangular");

                return Math.Sqrt(p * (p - values[0]) * (p - values[1]) * (p - values[2]));
            }

            #endregion

            Console.WriteLine("Invalid parameters");
            return 0;

        }
    }
}
