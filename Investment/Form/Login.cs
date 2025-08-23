using Investment.ViewModel;
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

namespace Investment
{
    public partial class Login : Form
    {
        private readonly LoginViewModel _viewModel;

        public Login()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();

            //Data Binding
            tbID.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ID), false, DataSourceUpdateMode.OnPropertyChanged);
            tbPW.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = await _viewModel.LoginAsync();
            if (result)
                MessageBox.Show("로그인 성공");
            else
                MessageBox.Show("ID 또는 Password가 올바르지 않습니다.");
        }
    }
}
