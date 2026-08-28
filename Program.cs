
namespace AssignmentAAdvanced_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            /*
             * Q1: What is a generic class? Why use generics?
             * 
             * Answer:
             * What is a Generic Class?
             *   A generic class is a class that allows you to define placeholders 
             *   for data types. The actual data type is specified when the class is instantiated.
             * 
             *  Why use Generics?
             *   1. Type Safety: Catch type mismatch errors at compile-time rather than runtime.
             *   2. Code Reusability: Write code once and use it with any data type.
             *   3. Performance: Avoids boxing/unboxing overhead when working with value types 
             */
            #endregion




            #region Q2

            //            Q2: Write a generic class Container<T> with Add and Get methods.



            //public class Container<T>
            //        {
            //            private T[] _items;
            //            private int _count;

            //            public Container(int capacity = 10)
            //            {
            //                _items = new T[capacity];
            //                _count = 0;
            //            }

            //            public void Add(T item)
            //            {
            //                if (_count < _items.Length)
            //                {
            //                    _items[_count] = item;
            //                    _count++;
            //                }
            //            }

            //            public T Get(int index)
            //            {
            //                if (index >= 0 && index < _count)
            //                {
            //                    return _items[index];
            //                }
            //                throw new IndexOutOfRangeException("Index is out of range.");
            //            }
            //        }
            #endregion


            #region Q3
//public class Pair<TKey, TValue>
//        {
//            public TKey Key { get; set; }
//            public TValue Value { get; set; }

//            public Pair(TKey key, TValue value)
//            {
//                Key = key;
//                Value = value;
//            }
        //}
            #endregion


    }
}
}
