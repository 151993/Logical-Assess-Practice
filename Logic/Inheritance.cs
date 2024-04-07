using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

    public class A
    {
        internal static int number = 1;

        public static void print()
        {
            Console.WriteLine("From A method");
        }

    }
    abstract class B : A
    {
        public abstract void Print();

    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("am C constructor");
        }
        public override void Print()
        {
            Console.WriteLine("From c method");
        }


    }

    public  class Parent
    {
        public static int StaticVariable = 10;

        public static void StaticMethod()
        {
            Console.WriteLine("Static method in Parent");
        }
    }

    public abstract class Child : Parent
    {
        // This is not inheritance of static members, just a separate static variable in Child class
        public static int AnotherStaticVariable = 20;

        public static void AnotherStaticMethod()
        {
            Console.WriteLine("Another static method in Child");
        }
    }


}
