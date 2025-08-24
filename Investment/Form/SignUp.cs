using Investment.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Investment
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            tbPW.PasswordChar = '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userId = tbID.Text;
            string userName = tbName.Text;
            string password = tbPW.Text;
            string phone = tbPhone.Text;

            // ----------------- 유효성 검사 로직 추가 -----------------

            // 1. 사용자 ID 유효성 검사: 영어와 숫자만 허용
            Regex userIdRegex = new Regex("^[a-zA-Z0-9]+$");
            if (!userIdRegex.IsMatch(userId))
            {
                MessageBox.Show("사용자 ID는 영어와 숫자만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbID.Focus();
                return;
            }

            // 2. 비밀번호 유효성 검사: 12자리 이하, 영문과 숫자만 허용
            if (password.Length > 12)
            {
                MessageBox.Show("비밀번호는 12자리 이하로 입력해야 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPW.Focus();
                return;
            }
            Regex passwordRegex = new Regex("^[a-zA-Z0-9]+$");
            if (!passwordRegex.IsMatch(password))
            {
                MessageBox.Show("비밀번호는 영문과 숫자만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPW.Focus();
                return;
            }

            // 3. 핸드폰 번호 유효성 검사: 010으로 시작하는 11자리 숫자
            Regex phoneRegex = new Regex("^010\\d{8}$");
            if (!phoneRegex.IsMatch(phone))
            {
                MessageBox.Show("핸드폰 번호는 '010'으로 시작하는 11자리 숫자만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPhone.Focus();
                return;
            }

            // UserId, Username, Password는 필수 입력 항목으로 가정
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("사용자 ID, 이름, 비밀번호, 핸드폰 번호는 필수 입력 항목입니다.", "경고");
                return;
            }

            bool success = dbManager.RegisterUser(userId, userName, password, phone);

            if (success)
            {
                MessageBox.Show("✅ 회원가입 성공!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID.Clear();
                tbName.Clear();
                tbPW.Clear();
                tbPhone.Clear();
            }
            else
            {
                MessageBox.Show("❌ 회원가입 실패. 사용자 ID나 이름이 이미 존재하거나 데이터베이스 오류입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
