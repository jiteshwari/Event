using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEvent
{
    class ClsSingle_Delegate
    {
        public delegate void delmethod();
        public class P
        {
            public static void display()
            {
                Console.WriteLine("C#");
            }
            public static void show()
            {
                Console.WriteLine("Hi!");
            }
            public void print()
            {
                Console.WriteLine("Print");
            }
        }
        static void Main(string[] args)
        {
            // here we have assigned static method show() of class P to delegate delmethod()
            delmethod del1 = P.show;

            // here we have assigned static method display() of class P to delegate delmethod() using new operator
 
            delmethod del2 = new delmethod(P.display);
            P obj = new P();

            // here first we have create instance of class P and assigned the method print() to the delegate i.e. delegate with class

            delmethod del3 = obj.print;
            del1();
            del2();
            del3();
            Console.ReadLine();
        }
    }
}
 