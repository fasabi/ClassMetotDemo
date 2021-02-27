using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Saliha");
            myDictionary.Add(2, "Tuğba");

            myDictionary.Print();


            myDictionary.Add(3, "Büşra");

            myDictionary.Print();

            Console.ReadKey();
        }
    }
}
