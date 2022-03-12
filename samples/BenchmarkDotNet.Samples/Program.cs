using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNet.Samples
{
    public class Program
    {
        public static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        //private static void Main(string[] args)
        //{
        //    BenchmarkRunner.Run<IntroBasic>();

        //    Console.ReadLine();
        //}
    }
}