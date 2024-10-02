using System;
using System.Collections.Generic;

namespace Examples {
    //클래스 선언
    //객체지향 프로그래밍(OOP, Object Oriented Programming)
    //사물을 클래스로 추상화(코드화)하는 것
    //예) 강아지 : 속성(변수)과 행동(함수)

    //접근제한자 
    //public : 다른 클래스에서 자신의 변수나 함수에 접근하게 열어줌. 공개한다는 의미.
    //private : 기본값(생략시), 자신만 변수나 함수를 사용가능.
    class Dog {
        public string name = "까미";
        public void eat() {
            Console.WriteLine("먹는다");
        }
    }
    //메인 클래스
    internal class ex11 {
        static void Main() {
            //클래스를 메모리에 옮겨놓아야 실행가능하다.
            //객체(인스턴스)를 생성한다. 

            //클래스 변수이름 = new 클래스();
            Dog dog = new Dog();
            //변수(객체)이름 뒤에 점.을 찍으면 변수와 함수에 접근 가능하다.
            Console.WriteLine(dog.name);
            //Console.WriteLine(dog.eat()); //eat의 반환값이 void는 출력할 수 없다.
            dog.eat();
        }
    }
    //연습문제 8


}
