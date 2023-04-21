using System;
using static System.Console;

namespace Enum
{
    class MainApp
    {
        // 3.5.2 열거형식 - 여러개의 상수
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        // DialogResult 라는 열거 데이터형식을 만듦
        // 사용예시: DialogResult result = DialogResult.YES;

        static void Main(string[] args)
        {
            WriteLine((int)DialogResult.YES);
            WriteLine((int)DialogResult.NO);
            WriteLine((int)DialogResult.CANCEL);
            WriteLine((int)DialogResult.CONFIRM);
            WriteLine((int)DialogResult.OK);
        }
    }
}
