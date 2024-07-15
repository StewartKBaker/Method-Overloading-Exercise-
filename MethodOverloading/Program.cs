namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public static double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        public static string Add(int numOne, int numTwo, bool isTrue)
        {
            var sum = numOne + numTwo;
            if (isTrue)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else return $"{sum} dollars";
            }
            else return sum.ToString();
        }
        static void Main(string[] args)
        {
            var x = 30;
            var y = 20;
            var intAdd = Add(x, y);

            var xx = 20.5;
            var yy = 30.8;
            var doubleAdd = Add(xx, yy);

            var dollarsAdd = Add(15, 4, true);
            var dollarAdd = Add(1, 0, true);
            
            
            Console.WriteLine($"int add: {intAdd} decimal add {doubleAdd}");
            Console.WriteLine(dollarsAdd);
            Console.WriteLine(dollarAdd);
        }
    }
}
