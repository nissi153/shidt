using System;

namespace Examples{
    internal class ex05{
        static void Main() {
            //조건문 if문 swith문
            //1.단일 if문
            //패턴 
            //if( 조건식 ) { //비교,논리연산자로 이루어진 식
            //  true일때만 수행되는 수행문
            //}
            if( true ){
                Console.WriteLine("조건식이 true임");
            }
            if( 10 == 20)
            { //조건식이 false이므로 실행되지 않음.
                Console.WriteLine("10과 20은 같음");
            }

            //2.if else문
            //패턴
            //if( 조건식 ) {
            //   true일 때 수행
            //}else{
            //   false일 때 수행
            //}
            if( 10 == 20){
                Console.WriteLine("true임");
            }else{
                Console.WriteLine("false임");
            }

            //3.if else if문
            int num = 30;
            if (num == 10){
                Console.WriteLine("10입니다.");
            }else if (num == 20){
                Console.WriteLine("20입니다.");
            }else if (num == 30){
                Console.WriteLine("30입니다.");
            }else{
                Console.WriteLine("그외의 수입니다.");
            }

            //4.중첩 if문 - if문 안에 if문
            if(true) {
                if(true) {

                } else {

                }
            }
        }
    }
}
