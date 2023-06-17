namespace TaskTrim
{
    internal class Program
    {
        static void Main(string[] args)
        {   string str = Console.ReadLine();
            
            TrimMethods.Trim(str);
            Console.WriteLine(str);
        }
    }
}