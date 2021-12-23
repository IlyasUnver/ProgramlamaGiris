using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // burada tempArray tutucu olarak stackte kalması için kodlanıyor. Çünkü her new yazdığında önceki new'in değeri kayboluyor.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++) // tempArray uzunluğuna ek olarak i değerine +1 ver.
            {
                items[i] = tempArray[i]; // for döngüsündeki i'yi tempArray'de tut.
            }

            items[items.Length - 1] = item; // 
        }
    }
}
