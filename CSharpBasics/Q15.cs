﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q15
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }
    }
}
