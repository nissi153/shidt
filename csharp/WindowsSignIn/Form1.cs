using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSignIn {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e) {
            //텍스트박스의 입력된 값을 가져오기
            string userId = id.Text;
            string userPw = password.Text;

            //hong/1234이면 로그인 성공!
            if( userId.Equals("hong") && userPw.Equals("1234")) {
                //로그인성공
                MessageBox.Show("로그인 성공", "로그인");
            } else {
                //로그인실패
                MessageBox.Show("로그인 실패", "로그인");
            }

        }
    }
}
