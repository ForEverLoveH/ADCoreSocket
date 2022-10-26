using ADCoreClient.ADCoreClientSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreClient
{
    public partial class LoginWindow : Form
    {
        LoginSys LoginSys = new LoginSys();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoginSys.GoToRegister();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginSys.LoginGame(Accountinput.Text.Trim(), PasswordInput.Text.Trim());
        }

        private void ToSettingPage_CheckedChanged(object sender, EventArgs e)
        {
            LoginSys.ToServerSetting();
        }
    }
}
