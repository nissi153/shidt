using System;

namespace Examples.EX100
{
    internal class ex01
    {
        static void Main()
        {
            //문제1
            //입력 예시
            //없음
            //출력 예시
            //Hello
            Console.WriteLine("Hello");

            //문제6
            //출력 예)
            //C:\Download\hello.java
            Console.WriteLine("C:\\Download\\hello.java");

            //문제11
            // 첫 번째 문자 입력
            string firstInput = Console.ReadLine();
            char firstChar = firstInput.Length > 0 ? firstInput[0] : ' ';

            // 두 번째 문자 입력
            string secondInput = Console.ReadLine();
            char secondChar = secondInput.Length > 0 ? secondInput[0] : ' ';

            // 순서를 바꿔 출력
            Console.WriteLine($"{secondChar} {firstChar}");
        }
        
    }
}
