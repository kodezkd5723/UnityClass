using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Orc 객체를
namespace UnityLesson_CSharp_ForLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];
            // arr_Orc[0] = new Orc(0);
            // arr_Orc[1] = new Orc(1);
            // arr_Orc[2] = new Orc(2);
            // arr_Orc[3] = new Orc(3);
            // .... 대신
            int lengh = arr_Orc.Length;
            for (int i = 0; i < arr_Orc.Length; i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
            }

            // arr_Orc[0].name = "오크0";
            // arr_Orc[1].name = "오크1";
            // arr_Orc[2].name = "오크2";
            // arr_Orc[3].name = "오크3";
            // arr_Orc[4].name = "오크4";
            // ... 대신

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
