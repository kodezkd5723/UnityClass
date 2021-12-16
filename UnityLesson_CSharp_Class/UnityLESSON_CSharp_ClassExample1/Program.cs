using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 추상화
// 객체선정은 Orc
// -Orc의 특징
// Orc의 이름은 상급오크이다
// Orc의 키는 240.2cm이다
// Orc의 몸무게는 200.0kg이다
// Orc의 나이는 140살이다
// Orc의 성병은 남자다.
// Orc는 현재 놀고 있는가? 아니다
// -Orc의 기능 ( jump , smash )
// Orc1 점프를 한다.
// Orc2 휘두르기 한다.


namespace UnityLESSON_CSharp_ClassExample1
{
    class Program // 객체화(Orc 2마리를 만들 것)
    {
        static void Main(string[] args)
        {
            Orc Orc1 = new Orc(); // 클래스화를 짤때 public을 접근 시켜줘야 객체화를 만들때 참조가 가능하다.

            Orc1.name = "상급오크";
            Orc1.height = 240.2f;
            Orc1.weight = 200.0f; // kg 몸무게를 나타내는 용어?.. weight
            Orc1.age = 140;
            Orc1.isFemale = false;
            Orc1.genderchart = '남';
            Orc1.play = false;
            // Orc1.isResing = true; << 사용가능
            Orc1.Jump();


            Orc Orc2 = new Orc();

            Orc1.name = "하급오크";
            Orc1.height = 140.4f;
            Orc1.weight = 120.0f; // kg 몸무게를 나타내는 용어?.. weight
            Orc1.age = 60;
            Orc1.isFemale = true;
            Orc1.genderchart = '여';
            Orc1.play = true;
            // Orc2.isResing = true; << 사용가능
            Orc1.Smash();
        }
    }
}


class Orc // 클래스화
{
    public string name;
    public float height;
    public float weight;
    public int age;
    public bool isFemale;
    public char genderchart;
    public bool play; // 놀고있는가에 대한것은?? true , flase 의 구분으로 bool 사용 (isResting)
                      // public bool isResting; << 가능
 

    // 오크의 기능 점프 , 휘두르기에 대한것
    public void Smash()
    {
        Console.WriteLine("Smash");
    }
    public void Jump()
    {
        Console.WriteLine("Jump");

    }
    
    



}
