﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Class_If
{
    class Program

    {

        static bool condition1 = false;

        static bool condition2 = false;

        static bool condition3 = false;



        static void Main(string[] args)

        {

            if (condition1)

            {

                Console.WriteLine("조건 1이 참이다");

            }

            else if (condition2)

            {

                Console.WriteLine("조건 1이 거짓이고 조건 2가 참이다");

            }

            else if (condition3)

            {

                Console.WriteLine("조건 1,2가 거짓이고 조건 3이 참이다");

            }

            else

            {

                Console.WriteLine("조건 1,2,3 모두 거짓이다");

            }

        }

    }

}
