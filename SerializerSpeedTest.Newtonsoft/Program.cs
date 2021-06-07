using SerializerSpeedTest.Entities;
using System;
using System.Diagnostics;

namespace SerializerSpeedTest.NewtonsoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            string test = "Newtonsoft";
            Console.WriteLine($"Test {test} starting!");
            sw.Start();
            var obj = ExampleClass1.GenerateRandom();
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(obj));
            sw.Stop();
            Console.WriteLine($"Test {test} took {sw.ElapsedMilliseconds} milliseconds");
        }
    }
}
