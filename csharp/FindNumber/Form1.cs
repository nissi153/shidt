using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private int findNumber = 0; //1~20사이의 랜덤수
        private int chance = 0; //몇번만에 맞추었나?

        //게임시작 버튼
        private void ButtonStart_Click(object sender, EventArgs e) {
            
            //1부터 20사이의 랜덤수 발생!
            Random random = new Random();
            this.findNumber = random.Next(1, 20);

            //10회 찬스 설정
            this.chance = 10;

            //게임 초기화
            display.Text = "1부터 20사이의 수를 맞추세요.";
        }

        //번호입력 버튼
        private void ButtonInput_Click(object sender, EventArgs e) {
            //텍스트박스의 입력된 숫자를 가져오기
            //string => int로 바꾸기
            int inputNumber = Int32.Parse(textBox.Text);

            //랜덤수와 입력된 숫자를 비교하기
            //1. 일치한 경우 = "승리했습니다."
            Console.WriteLine("inputNumber:" + inputNumber);
            Console.WriteLine("findNumber:" + this.findNumber);
            
            if(inputNumber == this.findNumber) {
                display.Text = $"승리했습니다.({this.chance})";
                return;
            }
            
            if(this.chance == 0) { //마지막 찬스였을때
                display.Text = "실패했습니다";
                return;
            } else { //찬스가 남았을 때
                if(inputNumber > this.findNumber) {
                    display.Text = $"정답{this.findNumber}은 더 작은 수입니다.{this.chance}회";
                } else {
                    display.Text = $"정답{this.findNumber}은 더 큰 수입니다.{this.chance}회";
                }

            }
            this.chance -= 1; //찬스를 1 감소한다.
            
        }

    }
}
