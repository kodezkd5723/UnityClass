using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Class_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }



    class Person

    {

        // bit = 한자리 이진수.( 0과 1 . 정보 처리의 최소단위 ) 

        // 1 byte = 8 bit. ( CPU의 데이터 처리 최소 단위. ) 

        // 4 byte = 8*4 bit = 32 bit. 

        // 표현할 수 있는 수의 범위는 2^(bit 수). 

        public int age; // 4 byte 정수 -2147483648~2147483647 

        public float height; // 4 byte 실수 

        public bool isFemale; // 1 byte 논리 

        public char genderChar; // 2 byte 문자 

        public string name; // 문자열. 문자 갯수 * 2 byte 크기 



    }

}
