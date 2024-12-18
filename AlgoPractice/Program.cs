using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;

namespace AlgoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 3, 5 }));
            //Console.WriteLine(test(7, 12, 13));
            //Console.WriteLine(test(-1, 0, 1));
            //Console.WriteLine(test(17,33));

            //Console.WriteLine(stringTest("[[]]", "Hello"));
            //Console.WriteLine(stringTest("(())", "Hi"));
            //Console.WriteLine(stringTest("Buzz"));
            //Console.WriteLine(stringTest("Founder"));
            //Console.WriteLine(stringTest("zzzz"));
            //Console.WriteLine(stringTest("ZZZZ"));

            Console.ReadLine();
        }

        //public static int test(int x, int y)
        //public static bool test(int x, int y)
        public static int test (int[] testArray)
        {
            int counter = 0;
            for(int i=0; i < testArray.Length; i++)
              {
                counter++;
  	            if(counter != testArray[i])
    	            return counter;
              };
            return 0;
        }
            //return (y - x == z - y);
            //if (x <= 13 && y <= 13)
            //{
            //    if (x > y)
            //        return x;
            //    return y;
            //}
            //return 0;
            //{
            //    return x+y;
            //}
            //else if (x % 10 == y % 10 || x % 10 == y / 10 || x / 10 == y % 10 || x / 10 == y / 10)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            //) {
            //if ((x >= 10 && x <= 20) || (y >= 10 && y <= 20))
            //{
            //    return 18;
            //}
            //else return x+y;

        //}

            public static string stringTest(string s1, string s2)
            {
                return s1.Substring(0,2) + s2 + s1.Substring(2,2);
            //if (testString[0] == 'F')
            //{
            //    return "Fizz";
            //}
            //else if (testString[testString.Length - 1] == 'B')
            //{
            //    return "Buzz";
            //}
            //else if (testString[0] == 'F' && testString[testString.Length - 1] == 'B')
            //{
            //    return "FizzBuzz";
            //}
            //else return testString;

            //int ara_len = nums.Length -1;
            //int n = 0;
            //for(int i = 0;i< nums.Length -1;i++)
            //{
            //        n = nums[i];
            //        if(n == nums[i+1] && n == nums[i+2])
            //            return true;                
            //}
            //return false;

                //for (int i = 0; i < x.Length - 2; i++)
                //{
                //    if (x[i] == 1 && x[i + 1] == 2 && x[i + 2] == 3)
                //    { return true; }
                //}
                //if (x.Contains(y))
                //    return true;
                //return false;

                //string sampleString = x.Substring(x.Length-2,2);
                //int counter = 0;
                //for (int i = 0; i < x.Length -2 ; i++)
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
                //    {
                //        if (x[i] == 'a')
                //        {
                //            counter++;
                //        }
                //        if(x.Substring(i,2) == "aa" && counter < 2)
                //    {
                //        return true;
                //    }
                //    }
                //return false;

                //}
                //if (x.Length < 3)
                //{
                //    return x.ToUpper();
                //}
                //return x.Substring(0, x.Length - 3) + x.Substring(x.Length - 3, 3).ToUpper();

                //int count = 0;
                //for (int i = 0; i < x.Length; i++)
                //{
                //    if (x[i] == 'z') count++;
                //}
                //return (count > 1 && count < 5);
                //return x.Substring(1,2) == "yt" ? x.Remove(1,2) : x;
                //string y = x.Substring(0, 1);
                //string z = x.Substring(x.Length - 1);
                //return z + x.Substring(1,x.Length -2) + y;

                //if (x.Substring(0, 2) == "if")
                //{
                //    return x;
                //}
                //else return "if " + x;
        }

    }
    }