using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace Sampleproject
{
    public class MainClass
    {
        int i;
        int j;

        public int num;

        public class clas
        {

        }

        public static void Main(string[] args)
        {
            var num = 1;
            var two = 2;
            var three = 3;
            var four = 4;

            var sum = four + two;

            MainClass ex = new MainClass();
            int number = ex.num;
            var cls =  new clas();

            Console.WriteLine("sum of two numbers is {0}", sum);

            if (sum == 3)
            {
                Console.WriteLine("happy path");
            }
            else
            {
                throw new Exception("unhappy path");
            }

            //try
            //{
            //    sum = num + two;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Happy Path");
            //}


        }
    }
}