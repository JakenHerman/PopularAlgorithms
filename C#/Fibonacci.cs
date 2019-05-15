using System;
public class Fibonacci {
        /// <summary>
        ///     Returns the Nth number in Fibonacci Sequence
        /// </summary>
        /// <param name="n">How many times to run the Fibonacci sequence</param>
        /// <returns></returns>
        static int Fibonacci(int n)
        {
            return n <= 1 ? n : (Fibonacci(n - 1) + Fibonacci(n - 2));
        }
}
