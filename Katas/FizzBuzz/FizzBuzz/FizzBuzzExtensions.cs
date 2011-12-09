namespace FizzBuzzKata
{
    public static class FizzBuzzExtensions
    {
        public static string Test_For_FizzBuzz(this int input)
        {
            return FizzBuzz.Of(input);
        }

        public static bool Is_Multiple_Of(this int input, int number)
        {
            return input % number == 0;
        }

        public static bool Contains(this int input, int digit)
        {
            return input.ToString().Contains(digit.ToString());
        }
    }
}