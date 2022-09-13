using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_programs
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            //1)  To find the given number is Prime or not..........

            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime)
            {
                Console.WriteLine("it is a prime number");
            }
            else
            {
                Console.WriteLine("is not prime number");
            }






            //2)  Print 1 to 100 prime numbers............

            // bool Prime=true;
            //for(int a=2;a<=100;a++)
            // {
            //     for(int b=2;b<=100;b++)
            //     {
            //         if(a!=b && a%b == 0)
            //         {
            //             Prime = false;
            //             break;
            //         }
            //     }
            //     if(Prime)
            //     {
            //         Console.WriteLine("\t"+a);

            //     }
            //     Prime=true;
            // }



            //3)   Find Armstrong number............

            //int num,reminder,res=0;
            //Console.WriteLine("Enter the number");
            //num=Convert.ToInt32(Console.ReadLine());
            //for(int n=num;n>0;n=n/10)
            //{
            //    reminder = n % 10;
            //    res=res+reminder*reminder*reminder;
            //}
            //if(res==num)
            //{
            //    Console.WriteLine("Number is an Armstrong number");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not an Armstrong number");
            //}



            //4)  To find area of circle............

            //int r;
            //Console.WriteLine("Enter the radius");
            //r = Convert.ToInt32(Console.ReadLine());
            //double area = 3.14 * r * r;
            //Console.WriteLine($"Area is {area}");



            //5)  To find Perimeter..............

            //int l, b,i=2;
            //Console.WriteLine("Enter the length and breadth of rectangle");
            //l=Convert.ToInt32(Console.ReadLine());
            //b=Convert.ToInt32(Console.ReadLine());

            //double p = i*(l + b);

            //Console.WriteLine($"Perimeter is {p}");



            //6)  Find out given number is palindrome or not...........

            //int num, x, rev = 0;
            //Console.WriteLine("Enter the number");
            //num = Convert.ToInt32(Console.ReadLine());
            //x = num;
            //while(num> 0)
            //{
            //    rev = (rev * 10) + num % 10;
            //    num=num/10;
            //}
            //if(rev==x)
            //{
            //    Console.WriteLine("Number is Palindrome");
            //}
            //else
            //{

            //    Console.WriteLine("Number is not Palindrome");
            //}
        }
        
    }
}
