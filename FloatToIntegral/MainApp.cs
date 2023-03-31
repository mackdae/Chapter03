using System;

namespace FloatToIntegral
{
    class MainApp //클래스는 데이터와 기능
    {
        static void Main(string[] args) //메소드는 기능
        {
            // 3.4.7 데이터 형식 바꾸기 (형변환)
            // 부동 소수점 형식과 정수 형식 사이의 변환

            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);
        }
    }
}
