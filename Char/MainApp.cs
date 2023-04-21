using System;
using static System.Console;

namespace Char
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 3.4.3 문자 형식
            // char 정수형식 유니코드문자

            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Write(a);
            Write(b);
            Write(c);
            Write(d);
            Write(e);
            WriteLine();

            WriteLine($"{a}{b}{c}{d}{e}");

            WriteLine(a + b + c + d + e);
        }
    }
}
