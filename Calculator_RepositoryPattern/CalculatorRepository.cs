namespace Calculator_RepositoryPattern
{
    public class CalculatorRepository
    {
        public int AddTwoNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int SubtractTwoNumbers(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int MultiplyTwoNumbers(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int DivideTwoNumbers(int a, int b)
        {
            int c = a / b;
            return c;
        }

        public int GetRemainder(int a, int b)
        {
            int c = a % b;
            return c;
        }
    }
}
