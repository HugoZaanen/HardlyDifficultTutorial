using System;
using System.Collections.Generic;

namespace HardlyDifficultTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedString collection example
            //LinkedString itemTwo = new LinkedString("There", null);

            //LinkedString itemOne = new LinkedString("hi", itemTwo);

            //LinkedString currentItem = itemOne;
            //do
            //{
            //    Console.WriteLine(currentItem.myValue);
            //} while ((currentItem = currentItem.nextValue) != null);
            #endregion

            List<int> myIntList = new List<int>();
            myIntList.Add(12);
            myIntList.Add(2);
            myIntList.Add(1);
            myIntList.Add(2);
            
            //myList.Add("hi");            
            //myList.Add("there");
            //myList.Add("hi2");
            //myList.Add("There2");
            //myList.Add("a");


            foreach (var item in myIntList)
            {
                Console.WriteLine(item);
            }

            #region Hash Collection example
            //Hash hash = new Hash();
            //hash.Add("hi");
            //hash.Add("there");

            //LinkedString results = hash.GetAllAtHash(("hi").GetHashCode());
            //LinkedString currentItem = results;
            //do
            //{
            //    Console.WriteLine(currentItem.myValue);
            //} while ((currentItem = currentItem.nextValue) != null);
            //Console.Read();
            #endregion
        }
    }

    class LinkedString
    {
        public string myValue;
        public LinkedString nextValue;

        public LinkedString(string myValue, LinkedString nextValue)
        {
            this.myValue = myValue;
            this.nextValue = nextValue;
        }
    }

    class Hash
    {
        const int capacity = 100;
        LinkedString[] values;

        public Hash()
        {
            values = new LinkedString[capacity];
        }

        public void Add(string item)
        {
            LinkedString me = new LinkedString(item, null);
            int hashKey = (int)((uint)item.GetHashCode() % capacity);
            LinkedString currentAtHash = values[hashKey];
            if(currentAtHash != null)
            {
                if(currentAtHash.nextValue != null)
                {
                    currentAtHash = currentAtHash.nextValue;
                }

                currentAtHash.nextValue = me;
            }
            else
            {
                values[hashKey] = me;
            }
        }

        public LinkedString GetAllAtHash(int hashCode)
        {
            int hashKey = (int)((uint)hashCode % capacity);
            return values[hashKey];
        }
    }
}
