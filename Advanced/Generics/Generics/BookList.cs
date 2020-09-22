using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class BookList
    {
        public void Add(Book number)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<Tkey, Tvalue>
    {
        public void Add(Tkey key, Tvalue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
