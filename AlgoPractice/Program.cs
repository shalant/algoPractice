namespace AlgoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(test(103));
            //Console.WriteLine(test(90));
            //Console.WriteLine(test(89));
            //Console.WriteLine(test(20,25));

            Console.WriteLine(stringTest("Python", 1));
            Console.WriteLine(stringTest("Python", 0));
            Console.WriteLine(stringTest("Python", 4));

            Console.ReadLine();
        }

        //public static int test(int x, int y)
        public static bool test(int x)
        {
            return (x >= 90 && x <= 110) || (x >= 190 && x <= 210);
            
            //return x == 30 ? (x - 51) * 3 : 51 - x;
        }

        public static string stringTest(string x, int y)
        {
            return x.Remove(y,1);
            //if (x.Substring(0, 2) == "if")
            //{
            //    return x;
            //}
            //else return "if " + x;
        }
    
    }
}
