using System;
using System.Runtime.Serialization;
using miscellanea.Extensions;
using miscellanea.Utils;

namespace miscellanea
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"TestEnum - {TestEnum.None.ToStringValue()}");
            Console.WriteLine($"NameOf - {Expressions.NameOf((Request r) => r.Property)}");
        }
    }
    
    public enum TestEnum
    {
        [EnumMember(Value = "None")] None = 0
    }
    
    public class Request
    {
        public Guid Property { get; set; }
    }
}