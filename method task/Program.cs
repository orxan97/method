namespace method_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            char opr = Convert.ToChar(Console.ReadLine ());
            
            Console.WriteLine(calculator(num1, num2, opr));

        } 
        static int calculator( int num1, int num2, char opr)
        {
            int result = 0;
            switch (opr) 
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            return result;


        }

    }
}