using SerializerSpeedTest.Entities;
using System;
using System.Diagnostics;

namespace SerializerSpeedTest.SystemJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            string test = "System.Text.Json";
            Console.WriteLine($"Test {test} starting!");
            sw.Start();
            var obj = ExampleClass1.GenerateRandom();
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(obj));
            sw.Stop();
            Console.WriteLine($"Test {test} took {sw.ElapsedMilliseconds} milliseconds");
        }
    }
}
