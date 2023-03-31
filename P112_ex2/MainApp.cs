using System;

namespace P112_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //현재년도를 입력하세요
            //리드라인
            //출생년도를 입력하세요
            //리드라인
            //나의 나이는 : 출력

            Console.WriteLine("현재년도를 입력하세요.");
            string a = Console.ReadLine();
            Console.WriteLine("출생년도를 입력하세요.");
            string b = Console.ReadLine();

            Console.Write("나의 나이는 : ");
            Console.WriteLine(float.Parse(a) - float.Parse(b) +1);


        }
    }
}
