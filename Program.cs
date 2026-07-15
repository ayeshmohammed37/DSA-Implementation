namespace DSA_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2 };
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            //list[3] = 4;
            //Console.WriteLine(list[3]);
        }
    }
}
