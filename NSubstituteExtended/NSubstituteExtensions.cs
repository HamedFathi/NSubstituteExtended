using System;
using System.Linq;
using System.Reflection;

namespace NSubstitute
{
    public static class NSubstituteExtensions
    {
        public static object Protected(this object target, string methodName, params object[] args)
        {
            var type = target.GetType();
            var method = type
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Single(x => x.Name == methodName);

            if (!method.IsVirtual)
            {
                throw new Exception("The method must be a virtual member.");
            }

            return method.Invoke(target, args);
        }
    }
}