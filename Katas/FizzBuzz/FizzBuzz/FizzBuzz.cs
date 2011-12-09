namespace FizzBuzzKata
{
    using System.Collections.Generic;
    using System.Diagnostics;

    public class FizzBuzz
    {
        public static IEnumerable<string> From1To100()
        {
            for (int i = 1; i <= 100; i++)
            {
                var result = Of(i);
                Trace.WriteLine(result);
                yield return result;
            }
        }

        public static string Of(int number)
        {
            string result = "";
            if (number.Is_Multiple_Of(3) || number.Contains(3))
            {
                result += "Fizz";
            }
            if (number.Is_Multiple_Of(5) || number.Contains(5))
            {
                result += "Buzz";
            }

            if (result != "")
                return result;

            return number.ToString();
        }
    }
}