﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Examples {
    internal class ex10 {
        static void Main() {
            //배열 Array : 동일한 타입의 데이터를 순차적으로 나열한 데이터 구조이다.
            int[] arrayNum = [ 10, 20, 30 ];
            int[] arrayNum2 = { 10, 20, 30 };
            int[] arrayNum3 = new int[3];
            arrayNum3[0] = 10;

            int[][] array2DNum = [ [10,20],[30,40] ];
            int[][] array2DNum2 = new int[3][];
            array2DNum2[0] = [10, 20, 30];
            array2DNum2[1] = [40, 50, 60];
            array2DNum2[2] = [70, 80, 90];

            //콜렉트(모음) : List, ArrayList, Queue, Stack, HashTable, Dictionary
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            foreach (int n in list) {
                Console.WriteLine( n );
            }
            for(int i = 0; i < list.Count; i++) {
                Console.WriteLine( list.ElementAt(i) );
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("20");
            arrayList.Add(3.14f);
            arrayList.Add(true);
            //var : 타입이 고정되지 않는 변수형
            foreach(var item in arrayList) {
                //object타입으로 arraylist는 저장한다.
                if(typeof(int) == item.GetType()) {
                    Console.WriteLine( "int타입입니다." );
                    int num = Convert.ToInt32(item);
                    Console.WriteLine( num );
                }
                if(typeof(string) == item.GetType()) {
                    Console.WriteLine("string타입입니다.");
                }
                Console.WriteLine(item);
            }
            //큐 Queue : FIFO(First In First Out) 타입의 데이터 구조
            //           먼저 들어간 데이터가 먼저 나온다.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            while(queue.Count > 0) {
                Console.WriteLine(queue.Dequeue());
            }
            
            //스택 Stack : FILO(First In Last Out)
            //          먼저 들어간 데이터가 맨 나중에 나옴
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            while(stack.Count > 0) {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
