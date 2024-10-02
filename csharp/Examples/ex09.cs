using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex09 {
        static void Main() {
            Console.WriteLine(원의둘레( 5 ));
            Console.WriteLine(Max(10, 20, 30));
            Console.WriteLine(Max(20, 10, 30));
            Console.WriteLine(Max(30, 10, 20));

            CompressString("aaabbcccc");



            Console.WriteLine();

            Console.WriteLine("min:" + FindMin([1,3,2,5,4]));


            int[] mergedArray = MergeAndSort([1, 3, 5], [2, 4, 6]);
            Console.WriteLine( string.Join(',', mergedArray));

            Console.WriteLine( DecryptCaesarCipher("Khoor Zruog!") );
        }
        //연습문제 7
        //1. 원의 둘레 구하는 함수를 선언하고,
        //  매개변수로 반지름을 입력하면 원주율을 반환하여 출력하시오.
        // 원의 둘레 공식: 2 × 반지름 × 3.14 = 2πr
        //패턴
        //static double 함수이름( 반지름 ) {
        //  return 원주율;
        //}
        static double 원의둘레(int r) {
            return 2 * Math.PI * r;
        }

        //2. 정수 3개를 매개변수를 입력받고, 그중 가장 큰 수를 반환하는 함수를
        // 선언하시오. 
        // 입력예) 10,20,30 매개변수로 입력
        // 출력예) 30
        static int Max(int a, int b, int c) {
            //if(a > b) {
            //    if( a > c) {
            //        return a;
            //    } else {
            //        return c;
            //    }
            //} else {
            //    if(b > c) {
            //        return b;
            //    } else {
            //        return c;
            //    }
            //}
            return Math.Max(Math.Max(a, b), c);

        }

        //3. 문자열 압축 함수
        //주어진 문자열에서 연속된 문자를 압축하는 CompressString(string input) 함수를
        //작성하세요.(영소문자 a에서 z까지만)
        //예를 들어, 입력이 "aaabbcccc"일 경우 "a3b2c4"를 반환하도록 하세요.
        //접근법:
        //반복문 a부터 z까지 검사하는데, 문자열의 길이만큼 반복
        static void CompressString(string input) {
            int[] alphbet = new int[26];
            // a b c d     z
            //[0,0,0,0,...,0]
            //aaabbcccc
            //[3,2,4,0,....,0]
            //문자열을 char타입 배열로 변환
            char[] cArray = input.ToCharArray(); //"aaabbcccc"
            //['a','a','a','b','b','c','c','c','c']
            for(int i = 0; i < cArray.Length; i++) {
                for(int j = 0; j < alphbet.Length; j++) {
                    //'a'는 아스키코드값으로 97이다.
                    if(cArray[i] == 'a' + j) {
                        alphbet[j]++;
                    }
                }
            }
            Console.WriteLine(string.Join(',', alphbet));
            //"a3b2c4"
            for(int n = 0; n < alphbet.Length; n++) {
                if(alphbet[n] > 0) {
                    Console.Write($"{(char)('a' + n)}{alphbet[n]}");
                }
            }
        }

        //4. 배열을 매개변수로 받는 int FindMin(int[] array) 함수를 선언하고
        // 배열의 요소 중 최소값을 찾아서 반환하시오.
        static int FindMin(int[] array) {
            //int min = array.Min();
            //return min;

            Array.Sort(array); // 오름차순 정렬
            return array[0];
        }

        //5. 두개의 배열을 병합하고, 오름차순으로 정렬된 배열을 반환하는 함수를 선언하시오.
        // int[] MergeAndSort(int[] array1, int[] array2) 형식으로 설계하시오.
        static int[] MergeAndSort(int[] array1, int[] array2) {
            int[] mergedArray  = array1.Concat(array2).ToArray();
            Array.Sort(mergedArray);
            return mergedArray;
        }
        //6. 간단한 암호해독기 함수를 작성하시오.
        // 시저 암호(Caesar Cipher)는 알파벳을 3칸 이동하여 작성된 암호이다.
        //암호화된 문자열: "Khoor Zruog!" (3칸 오른쪽 이동)
        //복호화된 문자열: "Hello World!" (3칸 왼쪽 이동)
        //string DecryptCaesarCipher(string input); 함수를 설계하여 복호화하시오.
        //아스키 코드표 이용
        //https://blog.naver.com/ouwukwfy/220248439711
        static string DecryptCaesarCipher(string input) {
            string decodedString = "";
            foreach(char c in input) {
                // 'A' ~ 'Z'                'a' ~ 'z'
                if((65 <= c && c <= 90) || (97 <= c && c <= 122)) {
                    decodedString += (char)(c - 3);
                } else {
                    decodedString += c;
                }
            }
            return decodedString;
        }
    }
}
