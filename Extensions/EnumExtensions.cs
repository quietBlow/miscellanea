using System;
using System.Linq;
using System.Runtime.Serialization;

namespace miscellanea.Extensions
{
    public static class EnumExtensions
    {
        public static string ToStringValue(this Enum value)
        {
            return value
                .GetType()
                .GetMember(value.ToString())
                .FirstOrDefault()
                ?.GetCustomAttributes(false)
                .OfType<EnumMemberAttribute>()
                .FirstOrDefault()
                ?.Value;
        }
    }
}