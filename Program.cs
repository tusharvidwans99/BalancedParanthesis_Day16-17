namespace SimpleBalanceParanthesis
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the expression: ");
            string exp = Console.ReadLine();
            BalancedParentheses balancedParentheses = new BalancedParentheses();


            if (balancedParentheses.balancedParentheses(exp))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("not Balanced");
        }
    }
}