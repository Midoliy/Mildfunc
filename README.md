# Mildfunc

## Mildfuncとは

Mildfuncは、delegate型やメソッドをより柔軟に扱うための機能を提供するライブラリです。  

## Mildfuncの使い方

### Mildfunc.Fn クラス

```cs
/**
 * using static で Mildfunc.Fn を指定してあげる.
 */
using static Mildfunc.Fn;
using System;

namespace ConsoleApp
{
    class Program
    {
        static int Mul(int x, int y) => x * y;

        static void Main(string[] args)
        {
            /**
             * 通常だと, ラムダ式は自動でdelegate型に推論されないため,
             * 以下のようにキャストする必要があります.
             */
            var add = (Func<int, int, int>)((x, y) => x + y);
            Console.WriteLine($"10 + 20 = { add(10, 20) }");

            /**
             * Mildfuncを利用することで, 以下のように記述を簡略化することができます.
             * 記述方法は2種類あり, どちらで記述しても同じ結果となります. 
             */
            // (1) 引数の型を明示する方法.
            //     ラムダ式を指定する場合に効果があります.
            var sub = fn( (int x, int y) => x - y );
            Console.WriteLine($"10 - 20 = { sub(10, 20) }");


            // (2) 型パラメータを指定する方法.
            //     メソッドを指定する場合に効果があります.
            var mul = fn<int, int, int>( Mul );
            Console.WriteLine($"10 * 20 = { mul(10, 20) }");
        }
    }
}
```

### Mildfunc.Curry クラス

```cs
/**
 * using static で Mildfunc.Curry を指定してあげる.
 */
using static Mildfunc.Curry;
using System;

namespace ConsoleApp
{
    class Program
    {
        static int Mul (int x, int y) => x * y;

        static void Main(string[] args)
        {
            /**
             * curry関数を使うことで, 既存のメソッドを簡単にカリー化することが可能です.
             * 記述方法は2種類あり, どちらで記述しても同じ結果となります. 
             */
            // (1) 引数の型を明示する方法.
            //     ラムダ式をカリー化する場合に効果があります.
            var add = curry( (int x, int y) => x + y );
            Console.WriteLine($"10 + 20 = { add(10)(20) }");

            // カリー化しているため, 部分適用することも可能です.
            var add5 = add(5);
            Console.WriteLine($"add5(20) = { add5(20) }");


            // (2) 型パラメータを指定する方法.
            //     メソッドを指定する場合に効果があります.
            var mul = curry<int, int, int>( Mul );
            Console.WriteLine($"10 * 20 = { mul(10)(20) }");

            // カリー化しているため, 部分適用することも可能です.
            var mul10 = mul(10);
            Console.WriteLine($"mul10(20) = { mul10(20) }");
        }
    }
}
```