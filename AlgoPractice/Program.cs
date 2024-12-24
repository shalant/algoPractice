using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;

namespace AlgoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(test(4, 5,6));
            //Console.WriteLine(test(7, 12,13));
            //Console.WriteLine(test(-1,0,1));
            //Console.WriteLine(test(17,33));

            Console.WriteLine(stringTest("Hello", 1));
            Console.WriteLine(stringTest("Python", 2));
            Console.WriteLine(stringTest("on", 1));
            Console.WriteLine(stringTest("o", 1));

            Console.ReadLine();
        }

        //public static int test(int x, int y)
        //public static bool test(int x, int y)
        public static bool test (int x, int y, int z)
        {
            if (y-x == z-y)
            {
                return true;
            }
            else 
                return false;
            //int counter = 0;
            //if (x == 13 || x == 17) counter += x;
            //if(x >= 10 && x <= 20)
            //{
            //    counter += 0;
            //}
            //else
            //{
            //    counter += x;
            //}
            //int counter = 0;
            //if (x != 13) counter += x;
            //if (x == 13) return counter;
            //if (y == 13) return counter;
            //if (y != 13) counter += y;
            //if (z == 13) return counter;
            //if (z != 13) counter += z;
            //return counter;
            //{
            //    return (x > y) ? y : x;
            //}
            //else if(x == y)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return (x > y) ? x : y;
            //}
        }


        public static string stringTest(string s1, int n)
        {
            if(s1.Length > n)
            {
                return s1.Substring(0, n) + s1.Substring(s1.Length - n) ;
            }
            else return s1 + s1;
           
                //{
                //    if(x.Substring(i,2) == sampleString)
                //{
                //    counter++;
                //}
                //    //result += x.Substring(0, i+1);
                //}
                //return counter ;
                //    int counter = 0;  
                //    for(int i = 0;i < x.Length - 1; i++)
              
            }
        }
    }