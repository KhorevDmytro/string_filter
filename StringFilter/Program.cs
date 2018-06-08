using System.Diagnostics;

namespace StringFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = new Filter();
            Debug.WriteLine(filter.FindFirstUniqChar("aaattttbbbfzff"));
        }
    }
}