using System;

namespace dotNetV2
{
    class Program
    {
        public struct Book
        {
            public decimal price;
            public string author;
            public string description;


        }

        static void Main(string[] args)
        {
            int[] myArr = new int[6];

            myArr[0] = 34;
            myArr[1] = 4;
            myArr[2] = 14;
            myArr[3] = 24;
            myArr[4] = 44;
            myArr[5] = 54;

            Console.WriteLine(myArr.Length);

            Book book;

            book.price = 12.12m;
            book.author = "Pythagoras";
            book.description = "Book for Sanjay";


        }
    }
}
