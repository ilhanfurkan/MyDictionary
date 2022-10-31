using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] tempKey;
        TKey[] mainKey;
        TValue[] tempValue;
        TValue[] mainValue;
        TKey[] garbKey;
        TValue[] garbValue;
        public MyDictionary()
        {
            mainKey = new TKey[0];
            mainValue = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKey = mainKey;
            tempValue = mainValue;
            mainKey = new TKey[mainKey.Length + 1];
            mainValue = new TValue[mainValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                if (i == Convert.ToInt32(key) - 1)
                {
                    Console.WriteLine("Hatalı giriş yaptınız!! ID, eski kayıtla aynı olmamalıdır.");
                }
                else
                {
                    mainKey[i] = tempKey[i];
                    mainValue[i] = tempValue[i];
                }
            }

            mainValue[mainValue.Length - 1] = value;
            mainKey[mainKey.Length - 1] = key;
        }
        public void Remove(int index)
        {
            garbKey = mainKey;
            garbValue = mainValue;
            mainKey = new TKey[mainKey.Length - 1];
            mainValue = new TValue[mainValue.Length - 1];
            for (int i = 0; i < index; i++)
            {
                mainKey[i] = tempKey[i];
                mainValue[i] = tempValue[i];
            }

            for (int i = index + 1; i <= mainKey.Length; i++)
            {
                mainKey[i - 1] = garbKey[i];
                mainValue[i - 1] = garbValue[i];
            }
        }
        public void PrintD(MyDictionary<TKey, TValue> dictionary)
        {
            string person;
            for (int i = 0; i < dictionary.Count; i++)
            {
                person = (Convert.ToString(dictionary.ItemsKey[i]) + "-" + dictionary.ItemsValue[i]);
                Console.WriteLine(person);
            }
        }


        public TKey[] ItemsKey
        {
            get { return mainKey; }
        }
        public TValue[] ItemsValue
        {
            get { return mainValue; }
        }

        public int Count
        {
            get { return mainKey.Length; }
        }

    }



}
