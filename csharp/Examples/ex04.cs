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

            //연습문제3
            //1. 정수형 변수 하나를 선언하고 123으로 초기화한다.
            //  백의 자릿수와 십의 자릿수, 일의 자릿수를 구하여 출력하시오.
            // 출력예) 백의 자릿수: 1
            //        십의 자릿수: 2
            //        일의 자릿수: 3
            int myInt = 123;
            Console.WriteLine($"백의 자릿수는 {myInt/100}");
            Console.WriteLine($"십의 자릿수는 {(myInt / 10) % 10}");
            Console.WriteLine($"십의 자릿수는 {myInt % 10}");

            //2. 콘솔로부터 정수 2개를 입력받고
            // 더 큰 수를 출력하시오.
            // 입력예) 10
            //        20
            // 출력예) 20
            int myInt1 = Convert.ToInt32(Console.ReadLine());
            int myInt2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( myInt1 >= myInt2 ? myInt1 : myInt2 );

            //3. 콘솔로부터 10자미만의 문자열을 입력받고,
            // null이 아니라면(null 조건부 연산자 사용 ?. ?[]), 그 문자열의 길이를 출력하시오.
            // string str; str.Length 문자열의 길이
            string str = Console.ReadLine();
            Console.WriteLine( str?.Length );

            //4. string input = null 로 선언하고
            // input이 null이라면 기본값 "null값입니다."를 출력하는 코드를 작성하시오.
            // null 병합 연산자 사용 ??
            string input = null;
            Console.WriteLine(input ?? "null값입니다.");


        }
    }
}

