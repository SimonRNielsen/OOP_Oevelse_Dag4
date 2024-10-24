namespace TestLibrary
{
    /// <summary>
    /// Contains simple math equators
    /// </summary>
    public class SimpleMath
    {
        /// <summary>
        /// Adds 2 integers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Added result</returns>
        public int AddInts(int a, int b)
        {
            int c = a + b;
            return c;
        }
        /// <summary>
        /// Subtracts 2 integers
        /// </summary>
        /// <param name="a">Number to subtract from</param>
        /// <param name="b">Number to subtract</param>
        /// <returns>Subtracted result</returns>
        public int SubtractInts(int a, int b)
        {
            int c = a - b;
            return c;
        }
        /// <summary>
        /// Divides 2 integers
        /// </summary>
        /// <param name="a">Number to be divided</param>
        /// <param name="b">Number to divide with</param>
        /// <returns>Divided result</returns>
        public int DividedInts(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
