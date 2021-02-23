using System;

namespace skeletonCode
{
    class source1
    {

        private int num1 = 5;
        private int num2 = 10;
        public int add(int a, int b)
        {
            return a + b; 
        }
        public void calculate()
        {
            Console.WriteLine(num1 + num2);
        }
        public void printInfo(int sum)
        {
            Console.WriteLine(sum);
        }
        public static void printInfo2()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
