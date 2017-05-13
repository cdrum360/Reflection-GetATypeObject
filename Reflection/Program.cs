using System;
using System.Reflection;

namespace Reflection
{
    public class BaseClass
    {
        public int BaseField = 0;
    }

    public class DerivedClass : BaseClass
    {
        public int DerivedField = 0;
    }   
    
    
    public class Program
    {
        static void Main()
        {
            var baseClass = new BaseClass();
            var dervivedClass = new DerivedClass();
            BaseClass[] bca = new BaseClass[] { baseClass, dervivedClass };
    
            foreach (var v in bca)
            {
                Type t = v.GetType();                   // Get the type.
                Console.WriteLine("Object type : {0}", t.Name);
                
                FieldInfo[] fi = t.GetFields();         // Get the field information.
                foreach (var f in fi)
                Console.WriteLine(" Field : {0}", f.Name);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }


}

