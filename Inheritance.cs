using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Practicals
{
    internal class Inheritance
    {
        public Inheritance()
        {
            Derived d = new Derived();
            d.FunctionToOverride();
            Base b = new Base();
            b.FunctionToOverride();
            Base bd = new Derived();
            bd.FunctionToOverride();
        }

    }
    public class Base
    {
        int initializer = 0;
        public Base() {
            Console.WriteLine("Base class constructor.");
        }
         static Base()
        {
            Console.WriteLine("Base class static constructor.");
        }
        public virtual void FunctionToOverride()
        {
            Console.WriteLine("Base class virtual function");
        }

    }
    public class Derived:Base
    {
        int initializer = 0;
        public Derived()
        {
            Console.WriteLine("Derived class constructor.");
        }
        static Derived()
        {
            Console.WriteLine("Derived class static constructor.");
        }
        public override void FunctionToOverride()
        {
            Console.WriteLine("Derived class overriden function");
        }
    }
}
