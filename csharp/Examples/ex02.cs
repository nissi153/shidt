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

            //변수(함수) 이름 짓는 법
            //1. 영소문자로 시작
            //2. Camel Case(낙타등)을 사용(단어의 시작은 대문자로)
            //  예) myStudentCount
            //3. _(언더바) 외에 특수문자(!@#$) 사용 불가
            //4. 상수는 대문자로
            //5. 클래스 이름은 첫글자가 대문자

            //연습문제-1
            //1. 정수형 변수 100을 선언하고,
            //  실수형으로 형변환 한 후에 그 변수를 출력하시오.
            int myNumber = 100;
            float myFloatNumber = myNumber; //묵시적(암시적) 강제
            Console.WriteLine(myFloatNumber);
            Console.WriteLine(myFloatNumber.GetType().Name); //Single

            //2. 실수형 변수 3.14를 선언하고
            // 정수형으로 형변환 한 후에 그 변수를 출력하시오.
            double myDoubleNumber = 3.14;
            Console.WriteLine(myDoubleNumber.GetType().Name); //Double
            int myNumber2 = (int)myDoubleNumber;
            Console.WriteLine(myNumber2);
            Console.WriteLine(myNumber2.GetType().Name);

            //3. int 타입 변수에 200을 넣어 선언하고
            //  long타입으로 형변환 한 후에 출력하시오.
            int myNumber3 = 200;
            long myLongNumber = myNumber3;
            Console.WriteLine(myLongNumber);
            Console.WriteLine(myLongNumber.GetType().Name);

            //4. long 타입 변수에 200억을 넣어 선언하고,
            // int 타입으로 형변환 한 후에 출력하시오.(잘림현상 발생!)
            long myLongNumber2 = 20_000_000_000L;
            int myNumber4 = (int)myLongNumber2;
            Console.WriteLine(myNumber4);

        }
    }
}
