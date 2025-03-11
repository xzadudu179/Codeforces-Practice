namespace Watermelon;

class Program
{
    static void Main(string[] args)
    {
        // Watermelon
        int w = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < w; i++)
        {
            Console.WriteLine($"{i} {w - i}");
            if (i % 2 != 0 || (w - i) % 2 != 0) continue;
            Console.WriteLine("YES");
            return;
        }
        Console.WriteLine("NO");
    }
}