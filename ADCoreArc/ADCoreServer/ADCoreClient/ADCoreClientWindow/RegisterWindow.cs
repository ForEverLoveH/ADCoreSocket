using ADCoreClient.ADCoreClientSys;
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

namespace ADCoreClient.ADCoreClientWindow
{
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        RegisterSys registerSys = new RegisterSys();
        private void Surebtn_Click(object sender, EventArgs e)
        {
            var acc = AcccountText.Text.Trim();
            var tel = TelPhoneInput.Text.Trim();
            var pass = passwordinput.Text.Trim();
            var pa = PasswordAginstInput.Text.Trim();
            if(!string.IsNullOrEmpty(acc))
            {
                if (JudgeIsTelPhone(tel))
                {
                    if (!string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(pa))
                    {
                        if (pass == pa)
                        {
                            registerSys.Req_register(acc, tel, pass);
                        }
                        else
                        {
                            MessageBox.Show("俩次密码不一致，请重新输入！");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("应填写手机号码");return;
                    }
                }
                else
                {
                    MessageBox.Show("请将信息填写完整!"); return;
                }
            }
            else
            {
                MessageBox.Show("请将信息填写完整!"); return;
            }
        }
        public bool JudgeIsTelPhone(string account)
        {
            if (string.IsNullOrEmpty(account))
                return false;
            return Regex.IsMatch(account, @"^(1)\d{10}$");
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            ClearAllData();
            SetWindowState();
        }

        public  void ClearAllData()
        {
            TelPhoneInput.Text = String.Empty;
            PasswordAginstInput.Text  = String.Empty;
            passwordinput.Text = string.Empty;
            AcccountText.Text = String.Empty;
        }

        public  void SetWindowState()
        {
            this.Close();
        }
    }
}
