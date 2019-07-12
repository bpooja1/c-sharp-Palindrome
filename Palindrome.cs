using System;

namespace MyProgram
{
    class Test
    {
        int num;
        int rev;
        int mod= 0;
        int temp;
        public void Palindrome()
        {
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rev = num % 10;
                mod = (mod * 10) + rev;
                num = num / 10;
            }
            if(temp==mod)
            {
                Console.WriteLine("The given number is Palindrome");
            }
            else
            {
                Console.WriteLine("The given number is Not Palindrome");
            }
        }
        public static void Main(string[] args)
        {
            Test t = new Test();
            t.Palindrome();
        }
    }
}
