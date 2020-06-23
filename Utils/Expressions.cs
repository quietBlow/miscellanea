using System;
using System.Linq.Expressions;

namespace miscellanea.Utils
{
    public static class Expressions
    {
        public static string NameOf<T, TValue>(Expression<Func<T, TValue>> memberAccess) =>
            ((MemberExpression) memberAccess.Body).Member.Name;
    }
}