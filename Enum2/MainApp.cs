using System;
using static System.Console;

namespace Enum2
{
    class MainApp
    {
        // 3.5.2 열거형식 - 여러개의 상수
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args) //시작점을 잡아주는 특별한 메소드
        {
            DialogResult result = DialogResult.YES;

            WriteLine(result == DialogResult.YES);
            WriteLine(result == DialogResult.NO);
            WriteLine(result == DialogResult.CANCEL);
            WriteLine(result == DialogResult.CONFIRM);
            WriteLine(result == DialogResult.OK);

            //3.7 var형식: 지역변수로만 사용 가능
            //지역변수의 지역: 메소드 내부의 공간

        }
    }
}
