using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    internal class Program
    {
        public static void Main()
        {
            List ListOne = new List();
            ListOne.AddEnd();
            ListOne = ListOne + "2";
            ListOne.ViewItems();
            ListOne--;
            ListOne.ViewItems();
            List ListTwo = new List();
            ListTwo.AddEnd();
            if (ListOne != ListTwo) 
                Console.WriteLine("Списки не равны");
            if (ListOne)
                Console.WriteLine("Список отсортирован");
            ListOne.ViewItems();
            StaticOperation.CheckForNull(ListOne);
            ListOne.WordCounter();

           
            List.Developer Dev = new List.Developer();
            ListOne.Prod.Organization = "BSTU";
            Dev.Id = 23;
            Dev.Department = "BSTU";
            Dev.FIO = "TDV";
        }
    }

    internal class List
    {
        public Product Prod;
        public String?[] Items;
        public List()
        {
            Items = new String[0];
        }
        public void ViewItems()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.Write(i + ". ");
                Console.WriteLine(Items[i]);
            }
        }
        private void InputItem(int position)
        {
            Array.Resize(ref Items, Items.Length + 1);
            Items[position] = Convert.ToString(Console.ReadLine());
        }
        //list+item
        public static List operator +(List List, String Item)
        {

            if (List.Items.Length == 0)
            {
                List.InputItem(0);
            }
            else
            {
                Array.Resize(ref List.Items, List.Items.Length + 1);
                List.Items[List.Items.Length-1] = Item;
            }
            return List;
        }
        //добавление элемента в конец массива 
        public void AddEnd()
        {
            InputItem(Items.Length);
        }
        //list--
        public static List operator --(List List)
        {
            List tmp = List;
            List.Items[List.Items.Length-1] = null;
            Array.Resize(ref List.Items, List.Items.Length - 1);
            return tmp;
        }
        //вложенный клас Product, который содержит Id, название организации.
        
        //вложенный класс Developer (разработчик – фио, id, отдел).
        internal class Developer
        {
            int? id = 0;
            public int? Id
            {
                get { return id; }
                set { id = value; }
            }
            string? fio = "";
            public string? FIO
            {
                get { return fio; }
                set { fio = value; }
            }
            string? department = "";
            public string? Department
            {
                get { return department; }
                set { department = value; }
            }
        }

        //!=
        public static bool operator !=(List ListOne, List ListTwo)
        {
            return ! ListOne.Equals(ListTwo);
        }
        public static bool operator ==(List ListOne, List ListTwo)
        {
            return ListOne.Equals(ListTwo);
        }
        //true
        public static bool operator true(List _list)
        {
            for (int i = 0; i < _list.Items.Length-1; i++)
            {
                if (String.Compare(_list.Items[i+1],_list.Items[i]) > 1)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator false(List _list)
        {
            for (int i = 0; i < _list.Items.Length - 1; i++)
            {
                if (String.Compare(_list.Items[i + 1], _list.Items[i]) < 1)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    internal static class StaticOperation
    {
        //проверки на нулевых элементы в списке
        public static void CheckForNull(this List _list)
        {
            Console.WriteLine("Проверка нулевых элементов в списке");
            for (int i = 0; i < _list.Items.Length; i++)
            {
                if (String.IsNullOrEmpty(_list.Items[i]))
                {
                    Console.WriteLine( i + " нулевой");
                }
            }
        }
        //подсчета количества слов
        public static void WordCounter(this List List)
        {
            int counter = 0;
            foreach (string? item in List.Items)
            {
                if (item != null) counter++;
            }
            Console.WriteLine(counter);
        }
    }
    internal class Product
    {
        int? id = 0;
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        string? organization = "";
        public string? Organization
        {
            get { return organization; }
            set { organization = value; }
        }
    }
}