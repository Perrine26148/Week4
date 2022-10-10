using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise1
            /*Console.WriteLine("What is your string to change ? ");
            string s = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The result is :" + Exercise1(s));*/

            //Exercise2
            /*Console.WriteLine("How many numbers do you want ?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nChoose " + n + " number(s) :");
            int[] tab = new int[n];
            for(int i =0; i<n; i++ )
            {
                int r = Convert.ToInt32(Console.ReadLine());
                r = tab[i];
            }
            Console.Clear();
            Console.WriteLine("How many numbers do you want to verify ?");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nChoose " + v + " numbers that you want to verify :");
            int[] tab1 = new int[v];
            for (int j =0; j<v;j++ )
            {
                int t = Convert.ToInt32(Console.ReadLine());
                t = tab1[j];
            }
            Console.WriteLine("The result is : " + Exercise2(tab, tab1));*/

            //Exercise3a
            Console.WriteLine("Enter a word :");
            int w = Convert.ToInt32(Console.ReadLine());

            //Exercise3


        }
        static string Exercise1(string s)
        {
            string finalS = "";
            int size = s.Length;
            if (size ==1)
            {
                return s;
            }
            else if (size ==0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (i==0)
                    {
                        finalS = finalS + s[size - 1];
                    }
                    else if (i==size -1)
                    {
                        finalS = finalS + s[0];
                    }
                    else
                    {
                        finalS = finalS + s[i];
                    }
                }
                return finalS;
            }
        }
        static bool Exercise2(int[]tab, int []tab1)
        {
            bool result = false;
            bool f = false;
            bool t = true;
            int index = 0;
            if (tab == null || tab.Length == 0 || tab1 == null|| tab1.Length ==0)
            {
                return result;
            }
            else
            {
                for (int i = 0; i < tab.Length && f== false; i++)
                {
                    if (tab[i] == tab1[0])
                    {
                        index = i;
                        f = true;
                    }
                    /*for (int j = 0; j < tab1.Length; j++)
                    {
                        if ()
                        {
                            return true;
                        }
                    }*/
                }
                if (f == true)
                {
                    for (int j = index; (j < tab1.Length + index) && t == true; j++)
                    {
                        if (tab[j] != tab1[j - index])
                        {
                            t = false;
                        }
                    }
                    if (t == true)
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
    }
}
