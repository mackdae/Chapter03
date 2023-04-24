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

            //3.7 var 암시적 형식
            // var는 필드선언 불가, 지역변수로만 사용가능 (지역: 메소드 내부의 공간)

            // var: 넣은 데이터에 알맞는 형식을 컴파일러가 찾아줌
            // object: 모든 형식의 데이터를 넣을 수 있음 
            // 오브젝트는 박싱해서 힙에 저장 // 힙에서 꺼내서 타입변수에 넣기: 언박싱
        }
    }
}