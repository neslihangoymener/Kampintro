using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        //Consructor
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //newlemeden önceki listeyi tutması için
            items = new T[items.Length + 1]; //listenin eleman sayısını add için 1 artıralım

            for (int i = 0; i < tempArray.Length; i++) // önceki listeyi newlediğin yeni listeye atmak için
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Lenght
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
