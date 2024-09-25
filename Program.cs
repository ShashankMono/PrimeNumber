// See https://aka.ms/new-console-template for more information
class Prime
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The given number is: "+PrimeOrNot(num));
    }

    public static String PrimeOrNot(int num)
    {
        for(int i = 2; i < num; i++)
        {
            if(num % i == 0 && i!=num)
            {
                return "Not Prime";
            }
        }
        return "Prime";
    }
}
