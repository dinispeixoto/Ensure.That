using System.Diagnostics;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureObjectExtensions
    {
        [DebuggerStepThrough]
        public static Param<T> IsNotNull<T>(this Param<T> param) where T : class
        {
            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param.Name, ExceptionMessages.EnsureExtensions_IsNull);

            return param;
        }
    }
}