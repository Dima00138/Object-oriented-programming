using System;
using System.Reflection;

namespace laba11
{
    public static class Reflector
    {
        public static T Create<T>() where T : new()
        {
            T ob = new T();
            return ob;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Type? Types = Type.GetType("laba11.Class1");
            Console.WriteLine(Types.Assembly);
            ConstructorInfo[] Constructor = Types.GetConstructors();

            object ClassObject = Constructor[0].Invoke(new object[] { 2 });

            MethodInfo[] Method = Types.GetMethods();
            FieldInfo[] fileds = Types.GetFields();
            PropertyInfo[] properties = Types.GetProperties();
            Type[] intarfaces = Types.GetInterfaces();
            MethodInfo methods = Types.GetMethod("pre");
            object Value = Method[0].Invoke(ClassObject, new object[] { 100 });

            Class1 obj = Reflector.Create<Class1>();
            Console.WriteLine(Method[0]);
            Console.WriteLine(fileds[0]);
            Console.WriteLine(methods);
            Console.WriteLine("MethodInfo.Invoke() Example\n");
            Console.WriteLine("Class.Its() returned: {0}", Value);
        }
    }
}