using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBusiness.Tools
{
    /// <summary>
    /// Singleton
    /// One instance to guarantee the array will be loaded only once.
    /// </summary>
    public sealed class FibonacciSingleton
    {

        private static long[] _tempArray = new long[93];
        private static readonly FibonacciSingleton instance = new FibonacciSingleton();

        static FibonacciSingleton()
        {
        }

        private FibonacciSingleton()
        {
            FibonacciNumberConstructor();
        }

        public static FibonacciSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public long[] GetFibonacci
        {
            get
            {
                return _tempArray;
            }
        }

        /// <summary>
        /// Build a temporary list with all possible fibonacci numbers
        /// </summary>
        private void FibonacciNumberConstructor()
        {
            try
            {
                long n = 93;
                long a = 0, b = 1, c = 0;
                long i = 0;

                for (; i < n; i++)
                {
                    c = a;
                    _tempArray[i] = a;
                    a = b;
                    b = c + b;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
