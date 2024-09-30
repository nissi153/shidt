using System;
using System.Collections;

namespace Examples {
    internal class ex04 {
        static void Main() {
            //연산자
            int num1 = 10;
            int num2 = 3;
            //산술연산자 : + - * / %
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2); //나누기의 몫을 반환
            Console.WriteLine(num1 % num2); //나누기의 나머지를 반환
            //증감연산자 : ++ --
            Console.WriteLine(num1++); //num1 = num1 + 1; 
            Console.WriteLine(num1);
            //뒷++은 자신의 항목뒤에 연산.
            Console.WriteLine(num1++ + num1);
            Console.WriteLine(num1);
            //++, -- 연산자는 가급한 한줄에 여러개 쓰지 않는다.
            //한줄에 한개정도만 사용한다.
            Console.WriteLine(num1--); //num1 = num1 - 1; 
            Console.WriteLine(num1);

            //관계(비교)연산자 : == != < > <= >=
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 >= num2);
            //논리연산자 : &&(and), ||(or), !(not)
            Console.WriteLine(true && true); //true
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false); //false


            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //삼항연산자 : ? :
            Console.WriteLine(10 % 2 == 0 ? "짝수" : "홀수");

            //대입연산자 : =  복합(+= -= *= /=) 예) a+=b => a = a+b
            num1 += 10; //num1 = num1 + 10;

            //null : 값이 없는 것을 의미함. 메모리에 할당 안됨.
            //     : 값 대입 불가, 연산 불가, 0도 아님.

            //null조건부 연산자 : ?. ?[]  C#6.0버전이상에서 지원
            ArrayList list = null;
            //list.Add("야구"); // null 오류 발생
            //if(list != null) {
            //    list.Add("야구");
            //}
            list?.Add("야구"); //list가 null이면 Add함수를 수행하지 않음.
            Console.WriteLine(list?.Count);

            list = new ArrayList();
            list?.Add("야구");
            list?.Add("축구");
            Console.WriteLine(list?.Count);
            Console.WriteLine(list?[0]);
            Console.WriteLine(list?[1]);


            //null병합 연산자 : ??
            //nullable 타입 : int? , null일수도 있는 타입을 의미
            
            //a ?? 0의 의미:
            //만약 a가 null이면 0을 반환.
            //만약 a에 값이 있으면 그 값을 반환.
            int? a = null;
            Console.WriteLine($"{a ?? 0}"); // a는 null이므로 0 출력

            a = 99;
            Console.WriteLine($"{a ?? 0}"); // a는 null이 아니므로 99 출력


        }
    }
}

