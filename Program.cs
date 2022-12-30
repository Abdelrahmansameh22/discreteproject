namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int num1, num2;

            Console.Write("Input the starting range or number : ");
            num1 = int.Parse(Console.ReadLine()); 
            Console.Write("Input the ending range of number : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (n = num1; n <= num2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }
    }
}