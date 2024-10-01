using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex06 {
        static void Main() {
            //반복문 for문 while문
            //패턴
            //for( 초기화; 조건식; 증감문 ){
            //   수행문;
            //}
            for(int i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }
            //중괄호 생략하는 경우 - 수행문이 한줄일때만
            for(int i = 0; i < 5; i++)
                Console.WriteLine(i);

            if(10 < 20)
                Console.WriteLine("10<20");

            //연습문제 5
            //1. 반복변수 i를 1부터 100까지 출력하시오.
            for(int i = 1; i <= 100; i++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //2. 반복변수 i를 1부터 100사이의 짝수만 출력하시오.
            for(int i = 1; i <= 100; i++) {
                if(i % 2 == 0) {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            //3. 10부터 -10까지 출력하시오.
            for(int i = 10; i >= -10; i--) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //4. 1부터 100사이의 수 중에서 3이나 6이나 9가 포함된 수만 출력하시오.
            // 출력예) 3, 6, 9, ... 3, 33 ... 99
            int count = 0;
            for(int i = 1; i <= 100; i++) {
                if(i % 10 == 3 || (i / 10) % 10 == 3 ||
                    i % 10 == 6 || (i / 10) % 10 == 6 ||
                    i % 10 == 9 || (i / 10) % 10 == 9) {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine(count + "개");

            //5. 1부터 100사이의 2의 배수이거나 3의 배수인 수의 갯수를 출력하시오.
            count = 0;
            for(int i = 1; i <= 100; i++) {
                if(i % 2 == 0 || i % 3 == 0) {
                    Console.Write(i + " ");
                    count += 1;
                }
            }
            Console.WriteLine(count + "개");

            //6. 10의 약수의 갯수와 그 약수를 출력하시오.
            // 약수란 나누어 떨어지는 수
            // 출력예) 10의 약수는 1 2 5 10 
            count = 0;
            for(int i = 1; i <= 10; i++) {
                if(10 % i == 0) {
                    Console.WriteLine(i + " ");
                    count += 1;
                }
            }
            Console.WriteLine(count + "개 약수");

            //7. 2부터 100사이의 랜덤한 정수를 발생시키고,
            // 그 수가 소수인지 아닌지 판별하시오.
            // 소수는 약수의 갯수가 2개인 정수이다.
            // 출력예) 7은 소수입니다.
            //        10은 소수가 아닙니다.
            Random random = new Random();
            int randomNum = random.Next(2, 100);
            Console.WriteLine(randomNum);
            count = 0;
            for(int i = 1; i <= randomNum; i++) {
                if(randomNum % i == 0) {
                    count++;
                }
            }
            if(count == 2) {
                Console.WriteLine("소수입니다. ");
            } else {
                Console.WriteLine("소수가 아닙니다.");
            }
        }
    }
}
