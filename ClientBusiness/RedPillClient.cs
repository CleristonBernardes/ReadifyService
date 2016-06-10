using ClientBusiness.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClientBusiness.Tools.Enums;

namespace ClientServices
{
    public static class RedPillClient
    {
        public const string ReadifyNameSpace = "http://KnockKnock.readify.net";
        

        /// <summary>
        /// Retrieves the candidate's token
        /// </summary>
        /// <returns>Guid</returns>
        public static Guid WhatIsYourToken()
        {
            try
            {
                return new Guid("");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Validades and get the fibonacci from a temp array
        /// </summary>
        /// <param name="n">Nth position</param>
        /// <returns>fibonacci number</returns>
        public static long FibonacciNumber(long n)
        {
            bool negative = false;
            int limit = 92;
            if (n == 0)
                return 0;
            else if (n >= -limit && n < 0)
            {
                negative = true;
                n = -n;
            }
            else if (n < -limit || n > limit)
                throw new ArgumentOutOfRangeException("Number informed is beyond fibonacci limits");

            try
            {
                FibonacciSingleton fib = FibonacciSingleton.Instance;
                long result = fib.GetFibonacci[n];
                return ((negative && n % 2 == 0 ? -result : result) );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a triagulo's shape
        /// </summary>
        /// <param name="a">edgeA</param>
        /// <param name="b">edgeB</param>
        /// <param name="c">edgeC</param>
        /// <returns>Triangule Type</returns>
        public static TriangleType WhatShapeIsThis(int a, int b, int c)
        {            
            try
            {
                int[] values = new int[3] { a, b, c };
                values = values.OrderByDescending(o => o).ToArray();

                if (a <= 0 || b <= 0 || c <= 0)
                    return TriangleType.Error;
                else if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                    return TriangleType.Error;
                else if (values.Distinct().Count() == 1)
                    return TriangleType.Equilateral;
                else if (values.Distinct().Count() == 2)
                    return TriangleType.Isosceles;
                else if (values.Distinct().Count() == 3)
                    return TriangleType.Scalene;
                else
                    return TriangleType.Error;

            }
            catch
            {
                return TriangleType.Error;
            }

        }

        /// <summary>
        /// Reverts the value of a given string
        /// </summary>
        /// <param name="s">text</param>
        /// <returns>word reversed</returns>
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new NullReferenceException("Please, inform a valid value.");

            try
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
                
    }
}
