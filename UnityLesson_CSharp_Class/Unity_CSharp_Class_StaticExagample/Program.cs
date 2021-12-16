using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_CSharp_Class_StaticExagample
{
    class Program

    {

        static void Main(string[] args)

        {

            // Person 클래스 타입의 객체를 두개 생성해서  

            // Person 클래스 타입의 변수 person1, person2 에 각각 대입시켜줌 (인스턴스화) 

            // person1 과 person2 인스턴스의 이름을 설정해줌 

            Person person1 = new Person();

            person1.name = "김아무개";



            Person person2 = new Person();

            person2.name = "이아무개";



            Person.typeName = "사람 타입";

            Orc.typeName = "오크 타입";



            // static 멤버(변수와 함수)는 객체 단위로 접근할수가없음. 

            // 아래 person1 객체에서 SayTypeName() 이라는 static 함수를 호출시 에러가 나고  

            // 클래스 Person 에서 SayTypeName() 을 호출했을 경우 정상적으로 동작함. 

            // 즉 static 멤버는 클래스 자체의 정보 또는 기능. 

            // 설계도로 어떤 객체를 생성한 후 그 객체에 접근하는것이 아니라 

            // 설계도 자체에 접근해서 설계도에대한 정보나 기능들이 필요할 때 사용. 

            Person.SayTypeName();

            Person.SayTypeName();



            //static 으로 정의된 클래스는 객체생성 불가. 인스턴스화 불가. 

            // 기존 클래스개념을 설계도와 비슷하다고 설명했으나, static 클래스는 설명서에 더 가까움. 


        }

    }

    static class Orc

    {

        static public string typeName;

    }

    class Person

    {

        // 접근제한자 : 자료형 앞에 붙여준다. 

        // public, private ,protected 

        // public : 다른 클래스가 접근 할수 있다. 

        // private : 다른 클래스는 접근할 수 없다. 

        // protected : 상속자만 접근할 수 있다.  

        public int age; // 나이 

        public float height; // 키 

        public bool isFemale; // 여자인지? 

        public char genderChar; // 성별 문자 

        public string name; // 이름 



        static public string typeName; //타입이름 

        static public void SayTypeName()

        {

            Console.WriteLine(typeName);

        }

        public void SayAllInfo()

        {

            //Console.WriteLine($"나이 : {age}, 키 : {height}, 여자인가? : {isFemale}, 성별문자: {genderChar}, 이름 : {name}"); 

            SayAge();

            SayHeight();

            SayIsFemale();

            SayGenderChar();

            SayName();

        }

        public void SayAge()

        {

            Console.Write($"나이 : {age}");

        }

        public void SayHeight()

        {

            Console.Write($"키 : {height}");

        }

        public void SayIsFemale()

        {

            Console.Write($"여자인가? : {isFemale}");

        }

        public void SayGenderChar()

        {

            Console.Write($"성별문자 : {genderChar}");

        }

        public void SayName()

        {

            Console.Write($"이름 : {name}");

        }

    }

}