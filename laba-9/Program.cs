using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace laba_9
{
    internal class Program
    {
        public static void Main()
        {
            Stack myStack = new Stack();
            int[] v = { 1, 2, 3, 4, 5, 6 };
            myStack.Push(new GeometricFigure<int>(v));
            myStack.Push(new GeometricFigure<string>(new[] { "ssdsd", "sdsds" }));
            myStack.Pop();
            foreach (object obj in myStack)
            {
                Console.WriteLine(obj.ToString());
            }
            Stack<int> myStack2 = new Stack<int>();
            myStack2.Push(1);
            myStack2.Push(2);
            myStack2.Push(3);
            myStack2.Push(4);
            foreach (int obj in myStack2)
            {
                Console.WriteLine(obj);
            }
            myStack2.Pop();
            myStack2.Pop();
            myStack2.Push(10);
            HashSet<int> hashSet = new HashSet<int>();
            foreach (int i in myStack2)
            {
                hashSet.Add(i);
                Console.Write($"{i}, ");
            }
            int v2 = 0;
            hashSet.TryGetValue(10, out v2);
            Console.WriteLine(v2);

            ObservableCollection<GeometricFigure<int>> numbers = new ObservableCollection<GeometricFigure<int>>();
            numbers.CollectionChanged += EventMethod;
            numbers.Add(new GeometricFigure<int>(new int[] {1,1,1,1,1,1}));
            numbers.Add(new GeometricFigure<int>(new int[] { 3, 3, 3, 33, 3, 3 }));
            numbers.RemoveAt(0);
            void EventMethod(object? sender, NotifyCollectionChangedEventArgs e)
            {
                Console.WriteLine($"Элемент коллекции был изменен: {e.Action}");
            }
        }
    }
}
