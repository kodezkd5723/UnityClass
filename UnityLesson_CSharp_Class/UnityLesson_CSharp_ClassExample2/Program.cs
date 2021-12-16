using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -객체선정
// 일하기 싫은 마법사

// -추상화
// 1.마법사의 특징
// 마법사의 이름은 일하기싫어이다.
// 마법사의 나이는 28살이다.
// 마법사의 키는 175.5cm이다.
// 마법사의 몸무게는 87.7kg이다.
// 마법사는 남자이다.
// 마법사는 일을 하고 있다.
// 2.마법사의 기능
// 일하기싫다
// 너무 싫다

// -클래스화

// -객체화

// -인스턴스화

namespace UnityLesson_CSharp_ClassExample2
{
    internal class Program // 객체화
    {
        static void Main(string[] args)
        {
            wizard wizard1 = new wizard();
            wizard1.name = "일하기싫어";
            wizard1.age = 28;
            wizard1.height = 175.5f;
            wizard1.weight = 87.7f;
            wizard1.isFemale = false;
            wizard1.genderchar = '남';
            wizard1.work = true;

            wizard1.Ihatetowork();
            wizard1.veryveryhate();

        }
    }

    class wizard // 클래스화
    {
        public string name;
        public int age;
        public float height;
        public float weight;
        public bool isFemale;
        public char genderchar;
        public bool work;

        public void Ihatetowork()
        {
            Console.WriteLine("IHateToWork!");
        }
        public void veryveryhate()
        {
            Console.WriteLine("VeryVeryHate!");
        }

    }
}
