using System;

namespace SerializerSpeedTest.Entities
{
    public class ExampleClass1
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
        public DateTime Property3 { get; set; }
        public ExampleClass2 ExampleClass2 { get; set; }

        public static ExampleClass1 GenerateRandom()
        {
            var rnd = new Random();
            return new ExampleClass1
            {
                Property1 = Guid.NewGuid().ToString(),
                Property2 = rnd.Next(0, 10000),

                //just to simplify, up to day 28th
                Property3 = new DateTime(rnd.Next(1900, 2050), rnd.Next(1, 12), rnd.Next(1, 28)),
                ExampleClass2 = new ExampleClass2
                {
                    Property1 = Guid.NewGuid().ToString(),
                    Property2 = rnd.Next(0, 10000),
                    Property3 = new DateTime(rnd.Next(1900, 2050), rnd.Next(1, 12), rnd.Next(1, 28)),
                    ExampleClass3 = new ExampleClass3
                    {
                        Property1 = Guid.NewGuid().ToString(),
                        Property2 = rnd.Next(0, 10000),
                        Property3 = new DateTime(rnd.Next(1900, 2050), rnd.Next(1, 12), rnd.Next(1, 28)),
                    }
                }
            };
        }
    }
}
