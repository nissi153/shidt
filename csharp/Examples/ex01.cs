using System;

namespace Examples
{
    internal class ex01
    {
        //CLI : hwp.exe a.hwp b.hwp
        //["a.hwp", "b.hwp"]
        //    : npm install express
        static void Main(string[] args)
        {
            //정수형 변수 선언
            int num = 10;
            Console.WriteLine(num);

            //정수형 상수 선언
            //상수 : 한번 값이 정해지면 바꿀수 없는 변수
            const double PI = 3.141592;
            Console.WriteLine(PI);
            //PI = 4.14; //상수에 값을 재할당하면 오류!

            //논리형(부울형)
            bool myBool = true;
            //정수형 4바이트
            int myInt = 100;
            //정수형 8바이트
            long myLong1 = 200; //int 200을 만들어서 long 형변환됨.
            long myLong2 = 300L; //long 300을 만들어서 값이 복사됨.
            //실수형 4바이트
            float myFloat = 3.14f; //리터럴 뒤에 f를 꼭 써야 됨.
            //실수형 8바이트
            double myDouble = 4.25; //실수는 기본이 double타입이다.
            //문자형(단따옴표만)
            char myChar1 = 'a';
            char myChar2 = '가';
            //문자열(쌍따옴표만)
            string myString = "대한민국";
        }
    }
}
