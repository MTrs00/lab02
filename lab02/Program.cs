using System.Text.Json;

namespace lab02
{

    internal class Program
    {
        static void Main(string[] args)
        {
            APITest t = new APITest();
            t.getData().Wait();
        }
    }
}

