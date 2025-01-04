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
            //Console.WriteLine(test(new int[5] ));
            //Console.WriteLine(test(new[] { 12, 20 }));
            //Console.WriteLine(test(new[] { 20,20 }));
            //Console.WriteLine(test(new[] { 10, 20, -30, -40, 30 }));
            //Console.WriteLine(test(new[] { 10,10 }));
            //Console.WriteLine(test(new[] { 10 }));

            //Console.WriteLine(stringTest("abcab"));
            //Console.WriteLine(stringTest("python"));
            //Console.WriteLine(stringTest("aacda"));
            //Console.WriteLine(stringTest("jython"));
            //Console.WriteLine(stringTest("xyzsder"));
            int[] item = (new[] { 1,5,7 });
            int[] item2 = test(item);

            Console.WriteLine("Original array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine("New array: ");
            foreach (var i in item2)
            {
                Console.Write(i.ToString() + " ");
            }
            //Console.Write("New array: ");
            //foreach (var i in item)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            //Console.ReadLine();
        }

        //public static int test(int x, int y)
        //public static bool test(int x, int y)
        public static int[] test(int[] x)
        {
            for (int i = 0; i < x.Length -1; i++)
            {
                if (x[i] == 5 && x[i+1] == 7)
                {
                    x[i + 1] = 1;
                }
            }
            return x;
            
            
           

            //int[] result = new int[2];

            //if (x.Length >= 1)
            //{
            //    result[0] = x[0];
            //    result[1] = x[x.Length - 1];
            //}
            //return result;
            //int[] result = new int[2];
            //result[0] = x[2];
            //result[1] = y[2];
            //return result;
            //int[] y = new[] { 10, 20, -30, -40, 50 };
            ////return new int[] { a1[1], a1[2], a1[3], a1[0] };
            //int[] result = new int[5];
            //int j = 0;
            //for (int i = 4; i >= 0; i--) {
            //    result[j] = y[i];
            //    j++;
            //}
            //return result;
            //return new int[] { x[1], x[2], x[3], x[0] };

            //int counter = 0;
            //if (x == 13 || x == 17) counter += x;

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
