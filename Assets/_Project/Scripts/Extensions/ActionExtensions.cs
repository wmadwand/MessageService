using System;

namespace Bluehorse.Extensions
{
    public static class ActionExtensions
    {
        public static void Call(this Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        public static void Call<T>(this Action<T> action, T arg)
        {
            if (action != null)
            {
                action(arg);
            }
        }

        public static void Call<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            if (action != null)
            {
                action(arg1, arg2);
            }
        }

        public static void Call<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            if (action != null)
            {
                action(arg1, arg2, arg3);
            }
        }

        public static void Call<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (action != null)
            {
                action(arg1, arg2, arg3, arg4);
            }
        }

        public static T Call<T>(this Func<T> func, T @default = default(T))
        {
            return func != null ? func() : @default;
        }

        public static T Call<T1, T>(this Func<T1, T> func, T1 arg1, T @default = default(T))
        {
            return func != null ? func(arg1) : @default;
        }

        public static T Call<T1, T2, T>(this Func<T1, T2, T> func, T1 arg1, T2 arg2, T @default = default(T))
        {
            return func != null ? func(arg1, arg2) : @default;
        }

        public static T Call<T1, T2, T3, T>(this Func<T1, T2, T3, T> func, T1 arg1, T2 arg2, T3 arg3,
            T @default = default(T))
        {
            return func != null ? func(arg1, arg2, arg3) : @default;
        }

        public static T Call<T1, T2, T3, T4, T>(this Func<T1, T2, T3, T4, T> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T @default = default(T))
        {
            return func != null ? func(arg1, arg2, arg3, arg4) : @default;
        }
    }
}