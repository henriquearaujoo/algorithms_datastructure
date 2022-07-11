using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[1];
        }

        public int Count { get; private set; }

        public MyList<T> Add(T element)
        {
            if (array.Length == Count)
                array = NewArray(array);

            array[Count] = element;
            Count++;

            return this;
        }

        private T[] NewArray(T[] oldArray)
        {
            var newArray = new T[Count * 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = oldArray[i];
            }
            return newArray;
        }

        public void RemoveAt(int index)
        {
            var arrayAux = new T[Count - 1];
            var indexAux = 0;
            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                    continue;
                arrayAux[indexAux] = array[i];
                indexAux++;
            }
            array = arrayAux;
            Count--;
        }

        public void Insert(int index, T item)
        {
            var arrayAux = new T[Count + 1];
            var indexAux = 0;
            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                {
                    arrayAux[indexAux] = item;
                    indexAux++;
                }

                arrayAux[indexAux] = array[i];
                indexAux++;
            }
            array = arrayAux;
            Count++;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                    return i;
            }

            return -1;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }


        public override string ToString()
        {
            var stringArray = new StringBuilder();
            for (int i = 0; i < Count - 1; i++)
            {
                stringArray.Append(array[i] + ", ");
            }
            stringArray.Append(array[Count - 1] + "");
            return stringArray.ToString();
        }
    }
}
