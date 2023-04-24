using System;

namespace StringNumverConversion
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 3.4.7 데이터 형식 바꾸기
            // 문자열을 숫자로, 숫자를 문자열로

            int a = 123;
            string b = a.ToString();
            // b = Convert.ToString(a);
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            // d = Convert.ToString(c);
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            // f = int.Parse(e);
            Console.WriteLine(f);

            string g = "1.23456";
            float h = float.Parse(g);
            Console.WriteLine(h);
        }
    }
}