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
        }
    }
}
