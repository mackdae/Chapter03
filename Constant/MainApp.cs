using System;

namespace Constant
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 3.5.1 상수
            // 변수선언 앞에 const 추가하면 상수선언
            // 값을 바꾸지 말아야 할 변수를 건드리는 실수를 막아줌

            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483647;
            // _INT: 상수는 식별자(상수명)에 데이터형식을 표시해주는 편

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}
