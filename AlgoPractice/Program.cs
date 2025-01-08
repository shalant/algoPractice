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
            //Console.WriteLine("Does this array contain adjacent 3's or 5's? ");
            Console.WriteLine("Problem #146: ");

            //Console.WriteLine(test(123));
            //Console.WriteLine(test(13));
            //Console.WriteLine(test(222));
            //Console.WriteLine(test(new[] { "1", "2", "3", "4" }));

            //Console.WriteLine(stringTest(new string[] { "a", "b", "bb", "c", "ccc" }, 3));
            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.Write(stringTest(new string[] { "a", "b", "bb", "c", "ccc" }, 3).ToString());
            //}
            //Console.WriteLine(stringTest("python"));
            //Console.WriteLine(stringTest("aacda"));
            //Console.WriteLine(stringTest("jython"));
            //Console.WriteLine(stringTest("xyzsder"));
            //List<int> item = new List<int> { 1, 2, 3, 4 };
            ////int[] item2 = new[] { 40, 50, 60 };
            List<int> myList = test(new List<int> { 10, 22, 35, 41 });
            //string[] item = new[] { "1", "2", "3", "4" };
            //List<int> result = test(item);

            foreach (var i in myList)
            {
                Console.Write(i.ToString() + " ");
            }
            //Console.WriteLine("Sum sans 17: ");
            //Console.WriteLine(test(new[] { 3, 5, 1, 3, 7 }));
            //Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            //Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            //Console.WriteLine(test(new[] { 2, 4, 5, 6 }));
            //Console.WriteLine(test(new[] { 1, 5, 9, 10, 17, 5 }));
            //int[] result = test(new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 });
            //string[] item = stringTest(new[] { "a", "aaa", "b", "bbb", "c", "ccc" }, 3);

            //Console.WriteLine("New array: ");
            //foreach (var i in item)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            //Console.ReadLine();
        }

        //public static int test(int x, int y)
        //public static bool test(int x, int y)
        //public static int[] test(int[] x)
        //public static string[] test(string[] x)
        public static List<int> test(List<int> nums_str)
        {
            // use LINQ to append '#' at the start and end of each string in nums_str
            IEnumerable<int> s = nums_str.Select(x => x % 10);
            //string[] result = new string[x.Length];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    result[i] = "#" + x[i] + "#";
            //}
            //IEnumerable<int> result = x.Select(x => x * x *x);


            return s.ToList();
            //for (int j = x.Length / 2; j < x.Length; j++)
            //{
            //    //secondSum += x[j];
            //}
            //var firstHalf = Average(x, 0, x.Length /2);
            //var secondHalf = Average(x, x.Length / 2, x.Length);

            
            //return 2;
        }

        private static int Average(int[] num, int start, int end)
        {
            var sum = 0; //variable to store sum of elements within specified range

            //loop to sum elementes within the specified range
            for (int i = start; i < end; i++)
            {
                sum += num[i];
            }

            return sum / (num.Length / 2);

        }

        //return firstHalf > secondHalf ? firstHalf : secondHalf;
        //return (firstSum / (x.Length / 2) > secondSum / x.Length / 2) ? firstSum / x.Length / 2 : secondSum / x.Length / 2;
        //int firstSum = 0;
        //int secondSum = 0;

        //    for (int i = 0; i<x.Length / 2; i++)
        //    {
        //        firstSum += x[i];
        //    }
        //    for (int i = x.Length / 2; i<x.Length; i++)
        //    {
        //        secondSum += x[i];
        //    }
        //int[] result = new int[x.Length];
        //int counter = 0;
        //for (int i = 0; i < x.Length; i++)
        //{
        //    if (x[i] == 0)
        //    {
        //        result[counter] = x[i];
        //        counter++;
        //    }
        //}
        //for (int j = 0; j < x.Length - counter; j++)
        //{
        //    if (x[j] != 0)
        //    {
        //        result[j + counter] = x[j];
        //    }
        //}
        //return result;


        //while (i >= 0 && x[i] != 5)
        //{
        //    i--; 
        //}
        //i++;

        //size = x.Length - i;
        //result = new int[size];

        //for (int j = 0; j< size; j++)
        //{
        //        result[j] = x[j+i];
        //}

        //return result;


        //for (int i = 0; i < x.Length; i++)
        //{
        //    if (x[i] == 5)
        //    {
        //        if ((i > 0 && x[i - 1] == 5) || (i < arr_len - 1 && x[i + 1] == 5))
        //        {
        //            flag = true;
        //        }
        //        else if (i == arr_len - 1)
        //        {
        //            flag = false;
        //        }
        //        else
        //            return false;
        //    }
        //}

        //return flag;


        //return max;
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




        public static string[] stringTest(string[] s1, int num)
        {
            string[] result = new string[num];

            for (int i = 0; i < num; i++)
            {
                if (s1[i].Length == num)
                {
                    result[i] = s1[i];
                }
            }

            return result;


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
