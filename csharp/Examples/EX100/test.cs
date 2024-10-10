using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Examples.EX100 {
    internal class test {
        static void Main() {
            //문제 15번
            //년, 월, 일을 입력받아 형식에 맞게 출력
            //입력 예시
            //2012 1 3
            //출력 예시
            //2012.01.03
            int year = 2012, month = 1, day = 3;
            string formattedDate = $"{year:D4}.{month:D2}.{day:D2}"; //D 정수, n 자릿수
            Console.WriteLine(formattedDate);

            Console.WriteLine("{0:c}", 123); //통화단위
            Console.WriteLine("{0:f}", 123.45); //실수
            Console.WriteLine("{0:p}", 0.10); //10 퍼센트
            
            Console.WriteLine("{0:#,###}", 12345); //세자릿수마다 꼼마
            Console.WriteLine("{0:0.000}", 123.45678); //소숫점 3자리까지(반올림)
            Console.WriteLine("{0:0##-####-####}", 01037462265); //전화번호 형식

            //문제 43
            //숫자를 한글로 바꾸기
            //입력 예시
            //12345
            //출력 예시
            //일만이천삼백사십오

            //1.숫자 입력
            int number = 12345;
            int[] nums = new int[5];
            //2.각 자릿수 숫자 구하기
            nums[0] = number / 10000; // 만의 자릿수
            nums[1] = (number / 1000) % 10; // 천의 자릿수
            nums[2] = (number / 100) % 10; // 백의 자릿수
            nums[3] = (number / 10) % 10; // 십의 자릿수
            nums[4] = number % 10; // 일의 자릿수

            string str = "";//일만이천삼백사십오

            for(int i = 0; i < 5; i++) {
                //3."일"~"구" 숫자 한글 더하기
                if(nums[i] == 1) {
                    str = str + "일";
                } else if(nums[i] == 2) {
                    str = str + "이";
                } else if(nums[i] == 3) {
                    str = str + "삼";
                } else if(nums[i] == 4) {
                    str = str + "사";
                } else if(nums[i] == 5) {
                    str = str + "오";
                } else if(nums[i] == 6) {
                    str = str + "육";
                } else if(nums[i] == 7) {
                    str = str + "칠";
                } else if(nums[i] == 8) {
                    str = str + "팔";
                } else if(nums[i] == 9) {
                    str = str + "구";
                }

                //4."만"~"십" 자릿수 한글 더하기  
                if(i == 0 && nums[i] > 0) {
                    str += "만";
                }
                if(i == 1 && nums[i] > 0) {
                    str += "천";
                }
                if(i == 2 && nums[i] > 0) {
                    str += "백";
                }
                if(i == 3 && nums[i] > 0) {
                    str += "십";
                }

            }

            //5.출력하기
            Console.WriteLine(str);

            //문제59
            //로또 순위 매기기
            //1등 - 당첨번호 6개 일치
            //2등 - 당첨번호 5개 일치 + 보너스번호 일치
            //3등 - 5개 번호 일치
            //4등 - 4개 번호 일치
            //5등 - 3개 번호 일치
            //꽝 - 2개 이하 일치

            //1. 로또당첨번호 + 보너스번호, 내 로또번호 설정
            int[] lotto = { 13, 23, 24, 35, 40, 45 };
            int bonus = 7;
            int[] myNumber = { 13, 123, 33, 22, 11, 45 };
            int count = 0;
            for(int i = 0; i < 6; i++) {
                for(int j = 0; j < 6; j++) {
                    if( myNumber[i] == lotto[j]) {
                        count++;
                    }
                }
            }
            //2. 1등당첨
            if(count == 6) {
                Console.WriteLine("1등 당첨");
            }
            //3. 2등 또는 3등 당첨
            else if(count == 5) {
                int bonusCount = 0;
                for(int i = 0; i < 6; i++) {
                    if(bonus == myNumber[i]) {
                        bonusCount++;
                    }
                }
                if(bonusCount > 0) {
                    Console.WriteLine("2등 당첨");
                } else {
                    Console.WriteLine("3등 당첨");
                }
            }
            //4. 4등
            else if(count == 4) {
                Console.WriteLine("4등 당첨");
            }
            //5. 5등
            else if(count == 3) {
                Console.WriteLine("3등 당첨");
            }
            //6. 꽝!
            else{
                Console.WriteLine("꽝!");
            }
  
            //문제 52
            //영어에서 서수를 나타낼 때 다음과 같이 나타낸다.
            //1st  2nd  3rd  4th  5th  6th... 
            //11th 12th 13th 14th 15th...
            //21st 22nd 23rd 24th 25th...
            //31st 32nd 33rd 34th 35th...
            //...
            //91st 92nd 93rd 94th 95th... 99th
            //1부터 99까지의 숫자가 입력되면 영어 서수 표현으로 출력하시오.

            //입력
            //1~99 중 자연수가 하나 입력된다.
            //출력
            //영어 서수로 출력한다.

            //입력 예시
            //2
            //출력 예시
            //2nd

        }
    }
}
