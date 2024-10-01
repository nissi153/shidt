using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex07 {
        static void Main() {
            //반복문 while
            //패턴
            //초기화
            //while(조건식){
            // 수행문
            // 증감문
            //}
            int i = 0;
            while(i < 5 ) {
                Console.WriteLine( i );
                i++;
            }
            //무한루프
            i = 0;
            while(true) {
                Console.WriteLine( i );
                if( i > 10) {
                    break;
                }
                i++;
            }
            //연습문제 6
            //1. 철수와 영희가 주사위게임을 한다. 무한루프로 돌린다.
            //  주사위를 한번씩 던져서, 2나 4이면 1칸 전진, 홀수(1,3,5)이면 그 자리에,
            //  6이면 뒤로 한칸이다.
            // 앞으로 10칸을 먼저 전진하는 사람이 승리한다.
            // 이때의 게임결과를 출력하시오.
            // 출력예) 철수: 1 그자리
            //         영희: 2 1칸전진!
            //         ...
            //         영희: 4 1칸전진!
            //         영희 승!
            Random rnd = new Random();
            int 철수위치 = 0;
            int 영희위치 = 0;
            int 턴 = 0; //0 철수턴 1 영희턴
            while(true) {
                int dice = rnd.Next(1, 6);
                //6이면 뒤로 한칸이다.
                if(dice == 6) {
                    if( 턴 == 0) {
                        철수위치--;
                        Console.WriteLine($"철수: {dice}  뒤로 한칸");
                    } else {
                        영희위치--;
                        Console.WriteLine($"영희: {dice}  뒤로 한칸");
                    }
                    continue;
                }
                //2나 4이면 1칸 전진
                if(dice == 2 || dice == 4) {
                    if( 턴 == 0) {
                        철수위치++;
                        Console.WriteLine($"철수: {dice}  한칸 전진");
                    } else {
                        영희위치++;
                        Console.WriteLine($"영희: {dice}  한칸 전진");
                    }
                    continue;
                }
                // 홀수(1,3,5)이면 그 자리에
                if(턴 == 0) {
                    Console.WriteLine($"철수: {dice}  그자리");
                } else {
                    Console.WriteLine($"영희: {dice}  그자리");
                }

                //턴 바꿈
                if( 턴 == 0) {
                    턴 = 1;
                } else {
                    턴 = 0;
                }

                Console.WriteLine($"철수위치{철수위치}");
                Console.WriteLine($"영희위치{영희위치}");

                if(철수위치 == 10) {
                    Console.WriteLine($"철수 승");
                    break;
                }
                if(영희위치 == 10) {
                    Console.WriteLine($"영희 승");
                    break;
                }
            }

            //2. 페널티킥 게임
            // 손흥민이 공을 차고, 조현우가 골키퍼를 한다.
            // 공의 방향은 왼쪽(0), 가운데(1), 오른쪽(2) 이다.
            // 랜덤하게 공을 찬다. 왼쪽으로 찰 확률은 30%, 가운데는 20%, 오른쪽은 50%로 찬다.
            // 조현우도 수비방향이 왼쪽(0), 가운데(1), 오른쪽(2) 이다.
            // 수비 확률은 왼쪽은 40%, 가운데는 30%, 오른쪽은 30%로 수비한다.
            // 이때 골인인지? 방어인지? 출력하시오.
            // 랜덤수 1~10 뽑아서, 1,2,3이면 왼쪽 킥, 4,5이면 가운데킥, 6,7,8,9,10이면 오른쪽
            // 출력예) 손흥민 킥 - 오른쪽
            //         조현우 수비 - 왼쪽
            //        골인!


        }
    }
}
