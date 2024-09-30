using System;

namespace Examples
{
    internal class ex02
    {
        static void Main()
        {
            //형변환(type casting)
            //예) int(4) -> long(8) 문제없음
            //    long(8) -> int(4) 데이터 잘릴 수 있음.
            int myInt = 10;
            long myLong = myInt; //문제없음, 자동형변환

            long myLong2 = 1234_5678_9000;
            Console.WriteLine(myLong2);
            int myInt2 = (int)myLong2; //데이터 잘릴 수 있음. 강제형변환
            //형변환 연산자 : (타입)
            Console.WriteLine(myInt2);

            //byte(1) < short(2) < int,uint(4) < long,ulong(8)
            // < float(4) < double(8)
            // int -> float : 문제없음
            // float -> int : 데이터잘릴 수 있음
            int myInt3 = 10;
            float myFloat = myInt3;

            float myFloat2 = 3.14f;
            int myInt4 = (int)myFloat2; //실수 -> 정수(소숫점 잘림)
            Console.WriteLine(myInt4);

            //문자열을 숫자로 형변환
            string myString = "123";
            int myNum1 = int.Parse(myString);
            int myNum2 = Int32.Parse(myString);
            Console.WriteLine(myNum1);
            float myNum3 = float.Parse("3.14");
            Console.WriteLine(myNum3);

            //숫자를 문자열로 형변환
            int myNum4 = 30;
            string myStr1 = myNum4.ToString();
            Console.WriteLine(myStr1);
            Console.WriteLine(myStr1.GetType().Name);
        }
    }
}
