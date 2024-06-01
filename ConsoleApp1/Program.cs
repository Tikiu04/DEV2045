namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang.......");
            Console.WriteLine("Nhap vao so phan tu cua mang : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 100;
                Console.WriteLine("phan tu {0} co gia tri la {1}", i, arr[i]);
            }
            Console.ReadKey();

        }
    }
}
