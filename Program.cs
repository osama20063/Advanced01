
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




        #region Q12
        // Q12: How do you apply multiple constraints? Write an example.

        //public class BaseEntity
        //{
        //    public int Id { get; set; }
        //}

        //public class Manager<T> where T : BaseEntity, IComparable<T>, new()
        //{
        //    public T CreateAndCompare(T existing)
        //    {
        //        T newItem = new T();
        //        return newItem.CompareTo(existing) > 0 ? newItem : existing;
        //    }
        //}
        #endregion




        #region Q13
        // Q13: What does the 'default' keyword do in generics?

        //public class DefaultExample<T>
        //{
        //    public T GetDefaultValue()
        //    {

        //        return default(T);
        //    }
        //}
        #endregion




        #region Q14
        // Q14: Write a SafeList<T> that returns default when the index is invalid.

        //public class SafeList<T>
        //{
        //    private List<T> _items = new List<T>();

        //    public void Add(T item)
        //    {
        //        _items.Add(item);
        //    }

        //    public T Get(int index)
        //    {
        //        if (index >= 0 && index < _items.Count)
        //        {
        //            return _items[index];
        //        }
        //        return default;
        //    }
        //}
        #endregion




        #region Q15
        // Q15: What is covariance? Explain the 'out' keyword.

        // Covariance allows you to use a more derived type than originally specified.
        // The 'out' keyword marks a generic type parameter as covariant, restricting it to return types only.

        //public interface ICovariant<out T>
        //        {
        //            T GetItem();
        //        }
        #endregion





        #region Q16
        // Q16: What is contravariance? Explain the 'in' keyword.

        // Contravariance allows you to use a more generic (base) type than originally specified.
        // The 'in' keyword marks a generic type parameter as contravariant, restricting it to input parameters only.

        //public interface IContravariant<in T>
        //{
        //    void SetItem(T item);
        //}
        #endregion


        #region Q17
        // Q17: What is the difference between covariance and contravariance?

        // Covariance ('out'): Allows returning a derived type; used for output parameters (Read-only).
        // Contravariance ('in'): Allows passing a base type; used for input parameters (Write-only).

        //public interface IExample<out TOut, in TIn>
        //{
        //    TOut Produce();       // Covariant (Output)
        //    void Consume(TIn data); // Contravariant (Input)
        //}
        #endregion



        #region Q18
        // Q18: How do static members work in generic types?

        // Static members are unique to each closed generic type combination.
        // MyGenericClass<int> and MyGenericClass<string> have separate copies of static fields.

        //public class Counter<T>
        //{
        //    public static int Count;

        //    public Counter()
        //    {
        //        Count++;
        //    }
        //}
        #endregion








        #region Q19
        //// Q19: How can you inherit from a generic class?

        //// 1. Inherit with a concrete type argument
        //public class IntContainer : Container<int>
        //{
        //}

        //// 2. Inherit with a generic type parameter (passing it through)
        //public class CustomContainer<T> : Container<T>
        //{
        //}

        //public class Container<T>
        //{
        //    public T Data { get; set; }
        //}
        #endregion
    }
}
}
