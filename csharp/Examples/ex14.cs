using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex14 {
        static void Main() {
            //자료(데이터)구조 
            //알고리즘 : 문제를 풀어가는 순서나 방법

            //최대값/최소값 구하기
            int[] nums = [ 10, 30, 20, 50, 40 ];
            //1. max 변수에 최소값 설정한다.
            //   min 변수에 최대값 설정한다.
            int max = 10;
            int min = 50;
            //2. 전체요소를 순회하면서 max변수보다 더 큰 요소를 발견하면
            //  max에 그 값을 넣는다.
            for(int i = 0; i < nums.Length; i++) {
                if( max < nums[i] ) {
                    max = nums[i];
                }
                if(min > nums[i]) {
                    min = nums[i];
                }
            }
            //3. 순회 종료 후에는 max는 최대값이 된다.
            Console.WriteLine(max);
            Console.WriteLine(min);

            //정렬(Sort) 알고리즘
            // 1. 버블 정렬
            // 2. 선택 정렬
            // 3. 삽입 정렬

            //Swap 치환
            int a = 10;
            int b = 20;
            //a에 b값을, b에 a값을 넣고 싶다.
            //a = b;//20 = 20
            //b = a;//20 = 20
            //치환용 임시변수를 사용한다.
            int temp = 0;
            temp = a;
            a = b;
            b = temp;

            //1.버블정렬 : 오름차순으로
            nums = [10, 30, 20, 50, 40];
            for(int i = 0; i < 5; i++) {
                for(int j = i+1; j<5; j++) {
                    if( nums[i] > nums[j]) {
                        //치환!
                        int tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                    }
                }
            }
            foreach(int num in nums) {
                Console.WriteLine(num);
            }

            //2.선택정렬 : 
            nums = [10, 30, 20, 50, 40];
            int minIndex = 0;
            for(int i = 0; i < 5; i++) {
                minIndex = i;
                for(int j = i + 1; j < 5; j++) {
                    if(nums[j] < nums[minIndex]) {
                        //더 작은 값을 발견! minIndex값을 변경
                        minIndex = j;
                    }
                }
                Console.WriteLine(minIndex);
                //치환
                int tmp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = tmp;
            }
            foreach(int num in nums) {
                Console.WriteLine(num);
            }

        }
    }
}
