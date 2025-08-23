using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace Investment.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        // 이벤트 선언
        public event PropertyChangedEventHandler PropertyChanged;

        // PropertyChanged 이벤트 호출 메서드 (helper)
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string _id;
        private string _password;

        public string ID
        {
            get => _id;
            set
            {
                if(_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                    (LoginCommand as RelayCommand)?.RaiseCanExecuteChanged();
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                    (LoginCommand as RelayCommand)?.RaiseCanExecuteChanged();
                }
            }
        }

        // ICommand 바인딩용
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(
                _ => Login(),
                _ => !string.IsNullOrWhiteSpace(ID) && !string.IsNullOrWhiteSpace(Password) // 로그인 버튼 활성화 조건
            );

            RegisterCommand = new RelayCommand(_ => Register());
        }

        private void Login()
        {
            // TODO: DB에서 ID/Password 확인 로직 추가 
            if(ID == "admin" && Password == "1234")
            {
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                MessageBox.Show("로그인 실패!");
            }
        }
        private void Register()
        {
            // TODO: 회원가입 창 띄우기 or DB 저장
            MessageBox.Show("회원가입 화면으로 이동합니다.");
        }
        // 로그인 처리 (DB 연동)
        public async Task<bool> LoginAsync()
        {
            // DB 조회하는 코드 들어감 (예: Dapper, EF Core)
            await Task.Delay(200); // DB Access 시뮬레이션
            return (ID == "admin" && Password == "1234");
        }
    }
}
