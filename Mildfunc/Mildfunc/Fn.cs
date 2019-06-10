using System;

namespace Mildfunc
{
    public static class Fn
    {
        public static Action fn(Action act) => act;
        public static Action<T1> fn<T1>(Action<T1> act) => act;
        public static Action<T1, T2> fn<T1, T2>(Action<T1, T2> act) => act;
        public static Action<T1, T2, T3> fn<T1, T2, T3>(Action<T1, T2, T3> act) => act;
        public static Action<T1, T2, T3, T4> fn<T1, T2, T3, T4>(Action<T1, T2, T3, T4> act) => act;
        public static Action<T1, T2, T3, T4, T5> fn<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6> fn<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7> fn<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> fn<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> act) => act;
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> act) => act;

        public static Func<TResult> fn<TResult>(Func<TResult> func) => func;
        public static Func<T1, TResult> fn<T1, TResult>(Func<T1, TResult> func) => func;
        public static Func<T1, T2, TResult> fn<T1, T2, TResult>(Func<T1, T2, TResult> func) => func;
        public static Func<T1, T2, T3, TResult> fn<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func) => func;
        public static Func<T1, T2, T3, T4, TResult> fn<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, TResult> fn<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, TResult> fn<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> fn<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) => func;
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) => func;
    }
}
