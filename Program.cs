using System;


namespace WasmTest
{
    class Program
    {
        static WasmMath.Math Math = new WasmMath.Math();

        static void Main(string[] args)
        {
            var result = Math.Subtract(Math.Add(5, 8), 1);
            Console.WriteLine($"Result: {result}");
        }
    }
}