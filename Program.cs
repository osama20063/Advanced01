
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


            #region Q4
            // Q4: What is a generic method? Write Swap<T> method.

            //public static class Helper
            //        {
            //            public static void Swap<T>(ref T a, ref T b)
            //            {
            //                T temp = a;
            //                a = b;
            //                b = temp;
            //            }
            //        }
            #endregion


            #region Q5
            // Q5: Write a generic method FindMax<T> that finds maximum value

            //public static class ArrayHelper
            //        {
            //            public static T FindMax<T>(T[] array) where T : IComparable<T>
            //            {
            //                if (array == null || array.Length == 0)
            //                {
            //                    return default;
            //                }

            //                T max = array[0];
            //                for (int i = 1; i < array.Length; i++)
            //                {
            //                    if (array[i].CompareTo(max) > 0)
            //                    {
            //                        max = array[i];
            //                    }
            //                }
            //                return max;
            //            }
            //        }
            #endregion


            #region Q6
            // Q6: What is a generic interface? Write IRepository<T>.

            //public interface IRepository<T>
            //        {
            //            void Add(T item);
            //            T GetById(int id);
            //            IEnumerable<T> GetAll();
            //            void Delete(T item);
            //        }
            #endregion



            #region Q7
            // Q7: What is the 'struct' constraint? Write an example.

            //public class ValueContainer<T> where T : struct
            //        {
            //            public T Data { get; set; }

            //            public ValueContainer(T value)
            //            {
            //                Data = value;
            //            }
            //        }
            #endregion

            #region Q8
            // Q8: What is the 'class' constraint? Write an example.

            //public class ReferenceContainer<T> where T : class
            //        {
            //            public T Data { get; set; }

            //            public ReferenceContainer(T value)
            //            {
            //                Data = value;
            //            }
            //        }
            #endregion






            #region Q9
            // Q9: What is the 'new()' constraint? Write an example.

            //public class Creator<T> where T : new()
            //        {
            //            public T CreateInstance()
            //            {
            //                return new T();
            //            }
            //        }
            #endregion






            #region Q10
            // Q10: What is the interface constraint? Write an example.

//public class DataHandler<T> where T : IComparable<T>
//        {
//            public bool IsGreater(T item1, T item2)
//            {
//                return item1.CompareTo(item2) > 0;
//            }
        }
            #endregion






        #region Q11
        // Q11: What is the base class constraint? Write an example.

        //public class BaseEntity
        //{
        //    public int Id { get; set; }
        //}

        //public class BaseRepository<T> where T : BaseEntity
        //{
        //    public void PrintId(T item)
        //    {
        //        System.Console.WriteLine(item.Id);
        //    }
        //}
        #endregion
    }
}
}
