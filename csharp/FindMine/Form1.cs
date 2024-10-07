using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMine {
    public partial class Form1 : Form {
        //배열,List,ArrayList
        List<Button> btnList = new List<Button>();

        //생성자함수 : 클래스생성시 자동호출
        public Form1() {
            InitializeComponent();
            //게임초기화
            initGame();
        }
        private void initGame() { //게임초기화
            for(int i = 1; i <= 25; i++) {
                //버튼을 이름으로 찾아서 리스트에 추가
                Control[] controls = this.Controls.Find("button" + i, true);
                if(controls.Length > 0 && controls[0] is Button) {
                    btnList.Add((Button)controls[0]);
                }
            }
            display.Text = "찾은 버튼 갯수" + btnList.Count;
            foreach(Button btn in btnList) {
                btn.Text = "";
                //버튼이벤트 연결
                btn.Click += new EventHandler(onButtonClick);
            }
        }
        //25개의 모든 버튼의 클릭 이벤트를 받는다.
        //sender : 이벤트을 보낸 컨트롤(Button)
        //e : 이벤트 정보
        private void onButtonClick(object sender, EventArgs e) {
            //클릭된 버튼 가져오기
            Button clickedBtn = (Button)sender;
            MessageBox.Show(clickedBtn.Name + "이 클릭됨");
        }
    }
}
