using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Investment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPW.PasswordChar = '*';
        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = tbID.Text;
            string password = tbPW.Text;

            // UserId, Username, Password는 필수 입력 항목으로 가정
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("사용자 ID, 비밀번호는 필수 입력 항목입니다.", "경고");
                return;
            }

            bool success = dbManager.LoginUser(userId, password);

            if (success)
            {
                MessageBox.Show("✅ 로그인 성공!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID.Clear();
                tbPW.Clear();

                this.Close();
            }
            else
            {
                MessageBox.Show("❌ 로그인 실패. ID 혹은 비밀번호를 확인하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
