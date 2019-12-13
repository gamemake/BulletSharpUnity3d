
#if UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE || UNITY_EDITOR
#else
using System;

namespace AOT
{
    public class MonoPInvokeCallbackAttribute : Attribute
    {
        public MonoPInvokeCallbackAttribute(Type type)
        {
        }
    }
}
#endif
