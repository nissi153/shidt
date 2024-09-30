using System;

namespace Examples
{
    internal class ex03
    {
        static void Main()
        {
            //콘솔로부터 입력받기
            Console.Write("입력하세요:");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            int myInt = int.Parse(input);
            Console.WriteLine(myInt*2);

            //연습문제2
            //1. 콘솔로부터 정수 1개를 입력받고, 
            //  그 수에 10을 곱한 수를 출력하시오.
            // 입력예) 10
            // 출력예) 100
            //int myInt = Convert.ToInt32(Console.ReadLine());

            //2. 콘솔로부터 정수 1개를 입력받고 (1~100까지 중 하나)
            //  그 수가 짝수이면 "짝수", 홀수이면 "홀수"라고 출력하시오.
            // 힌트) %연산자 이용, if문
            // 입력예) 5
            // 출력예) 홀수

            //3. 콘솔로부터 문자열 2개를 입력받고, 합쳐서 출력하시오.
            //  문자열 연결 연산자 +
            // 입력예) 대한
            //        민국
            // 출력예) 대한민국

        }
    }
}
