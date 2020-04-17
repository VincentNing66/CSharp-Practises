using System;

//where T : IComparble (numbers)
//where T : Product (class)
//where T : struct (value type)
//where T : calss (reference type)
//where T : new() (object which has a default constractor)
namespace practise
{
    class Generics
    {
        public void GMain()
        {
            //Generics List with integer
            GenericsList<int> numberList = new GenericsList<int>();
            numberList.Add(2);

            //Generics List with Class
            var bookList = new GenericsList<Book>();
            bookList.Add(new Book());

            //Generics Dictionary
            var dict = new GenericsDictionary<int, Book>();
            dict.Add(202, new Book());

            //comparing 2 intager using the Generics way
            Console.WriteLine("Give me to numbers, I will return the larger one using the Generics way!");
            Console.WriteLine("Enter the 1st Number;");
            var a = Console.ReadLine();
            Console.WriteLine("Enter the 2nd Number;");
            var b = Console.ReadLine();
            int convertedA = 0, convertedB = 0;
            try
            {
                Int32.TryParse(b, out convertedB);
                Int32.TryParse(a, out convertedA);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Invalid input, Please try again");
                GMain();
            }
            var _genericsCompare = new GenericsCompare<int>();
            Console.WriteLine("The larger number is : " + _genericsCompare.Max(convertedA, convertedB));
            Console.WriteLine("There are 6 different types of way to use Generics, please look up the code.");
        }
    }

    //where T : IComparble (numbers)
    class GenericsCompare<T> where T : IComparable //comparing 2 intager using the Generics way
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
    }
    class GenericsList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    class GenericsDictionary<Tkey, Tvalue>
    {
        public void Add(Tkey key, Tvalue value)
        {

        }
    }

    //where T : Product (class)
    class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float calculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }


    //where T : struct (value type)
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HaveValue
        {
            get { return _value != null; }

        }
        public T GetValueOrDefault()
        {
            if (HaveValue)
                return (T)_value;

            return default(T);
        }
    }

    //where T : new() (object which has a default constractor)
    class obj<T> where T : IComparable, new()
    {
        public void Something(T value)
        {
            var obj = new T();
        }
    }

}