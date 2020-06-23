using System;
using System.Runtime.Serialization;
using miscellanea.Extensions;

namespace miscellanea
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"TestEnum - {TestEnum.None.ToStringValue()}");
        }
    }
    
    public enum TestEnum
    {
        [EnumMember(Value = "None")] None = 0
    }
}