﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Class_Function
{
    class Program

    {

        static bool doPrintHelloWorld = true;

        static void Main(string[] args)

        {

            if (doPrintHelloWorld)

            {

                PrintHelloWorld();

            }



            string tmpSomething = "bla bla~~";

            bool tmpIsFinished = false;

            tmpIsFinished = PrintSomethingAndReturnIsFinished(tmpSomething);

            Console.WriteLine(tmpIsFinished);

        }

        // 입력 x 출력 x 

        static void PrintHelloWorld()

        {

            Console.WriteLine("Hello World!");

        }

        // 입력 o 출력 x 

        static void PrintSomething(string something)

        {

            Console.WriteLine(something);

        }

        // 입력 o 출력 o 

        static bool PrintSomethingAndReturnIsFinished(string something)

        {

            bool isFinished = false;

            Console.WriteLine(something);

            isFinished = true;

            return isFinished;

        }

    }

}