using System;
using System.Collections.Generic;
using System.IO;
using Typegendary_Classes;
using Typegendary_Classes.MapPoint;

namespace Typegendary_Server
{
    class Program
    {
        public static readonly List<Player> Players = new List<Player>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Map map = new Map(File.ReadAllBytes(args[0]));

        }
    }
}
