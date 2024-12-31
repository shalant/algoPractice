using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;

namespace AlgoPractice
{
    internal class Program
    {
        //Revisit #85

        static void Main(string[] args)
        {
            //Console.WriteLine(test(4, 5,6));
            //Console.WriteLine(test(7, 12,13));
            //Console.WriteLine(test(-1,0,1));
            //Console.WriteLine(test(17,33));

            Console.WriteLine(stringTest("abcab"));
            Console.WriteLine(stringTest("python"));
            Console.WriteLine(stringTest("aacda"));
            Console.WriteLine(stringTest("jython"));
            //Console.WriteLine(stringTest("xyzsder"));

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


        public static string stringTest(string s1)
        {
            if (s1.Length > 1)
            {
                if (s1.Substring(1,1) == "a")
                {
                    s1 = s1.Remove(1,1);
                }

                if (s1.Substring(0, 1) == "a")
                {
                    s1 = s1.Remove(0, 1);
                }
            }

            return s1;


            //if(s1.Length < 3)
            //{
            //    return "";
            //}
            //if(s1.StartsWith("abc"))
            //{
            //    return "abc";
            //}
            //else if(s1.StartsWith("xyz"))
            //{
            //    return "xyz";
            //}
            
            //else return "";

            //string result = String.Empty;
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    if (s1[i] !=)
            //    result += s1[i];
            //}
            //for (int j = 0; j < s2.Length; j++)
            //{
            //    result += s2[j];
            //}
            //return result;

        }
        
//return lastChars;
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
