using System;
using static System.Console;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args) // Main메소드 //메소드=함수
                                        //static 한정자 void 반환형식 Main 메소드명 ()매개변수 {}코드블록
        {
            // 3.4.1 정수 형식

            sbyte a = 10;
            byte b = 40;
            
            WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            WriteLine($"c={c}, d={d}");

            int e = -1000_0000; // _는 자릿수구분자 (위치자유)
            uint f = 3_0000_0000;

            WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            WriteLine($"g={g}, h={h}");

            //$: 문자열보간
        }
    }
}
