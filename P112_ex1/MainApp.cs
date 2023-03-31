using System;

namespace P112_ex1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            float widthConvert = float.Parse(width);
            float heightConvert = float.Parse(height);
            Console.Write("사각형의 넓이는 : ");
            Console.WriteLine(widthConvert * heightConvert);

            //한줄버전
            Console.WriteLine($"사각형의 넓이는 : {float.Parse(width) * float.Parse(height)}");

        }
    }
}
