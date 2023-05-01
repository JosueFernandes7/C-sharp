
namespace Course
{
    class Program
    {
        static void Main(string[] args) {

            List<int> list = new List<int>() { 1, 2, 3};
            list.Add(1);
            list.Add(4);
            list.Add(2);
            Console.WriteLine(list);
            list.ForEach(x => Console.WriteLine(x));
        }

    }
}