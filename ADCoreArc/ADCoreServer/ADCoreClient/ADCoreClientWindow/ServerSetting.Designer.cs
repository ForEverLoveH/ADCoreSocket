namespace ADCoreClient
{
    partial class ServerSetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.IPAddressInput = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.PortInput = new Sunny.UI.UITextBox();
            this.ConnectBtn = new Sunny.UI.UIButton();
            this.MessageSendText = new Sunny.UI.UIRichTextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.RecieveMsgText = new Sunny.UI.UIRichTextBox();
            this.jkie = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(12, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "IP地址:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IPAddressInput
            // 
            this.IPAddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPAddressInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPAddressInput.Location = new System.Drawing.Point(91, 17);
            this.IPAddressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPAddressInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.IPAddressInput.Name = "IPAddressInput";
            this.IPAddressInput.ShowText = false;
            this.IPAddressInput.Size = new System.Drawing.Size(210, 29);
            this.IPAddressInput.TabIndex = 1;
            this.IPAddressInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPAddressInput.Watermark = "";
            this.IPAddressInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(377, 23);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(88, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "端口：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PortInput
            // 
            this.PortInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PortInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortInput.Location = new System.Drawing.Point(427, 17);
            this.PortInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.PortInput.Name = "PortInput";
            this.PortInput.ShowText = false;
            this.PortInput.Size = new System.Drawing.Size(117, 29);
            this.PortInput.TabIndex = 3;
            this.PortInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortInput.Watermark = "";
            this.PortInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectBtn.Location = new System.Drawing.Point(560, 12);
            this.ConnectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 35);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "连接";
            this.ConnectBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // MessageSendText
            // 
            this.MessageSendText.FillColor = System.Drawing.Color.White;
            this.MessageSendText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessageSendText.Location = new System.Drawing.Point(13, 76);
            this.MessageSendText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageSendText.MinimumSize = new System.Drawing.Size(1, 1);
            this.MessageSendText.Name = "MessageSendText";
            this.MessageSendText.Padding = new System.Windows.Forms.Padding(2);
            this.MessageSendText.ShowText = false;
            this.MessageSendText.Size = new System.Drawing.Size(1244, 282);
            this.MessageSendText.Style = Sunny.UI.UIStyle.Custom;
            this.MessageSendText.TabIndex = 5;
            this.MessageSendText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageSendText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(16, 51);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(178, 23);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "发送消息：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RecieveMsgText
            // 
            this.RecieveMsgText.FillColor = System.Drawing.Color.White;
            this.RecieveMsgText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecieveMsgText.Location = new System.Drawing.Point(13, 395);
            this.RecieveMsgText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecieveMsgText.MinimumSize = new System.Drawing.Size(1, 1);
            this.RecieveMsgText.Name = "RecieveMsgText";
            this.RecieveMsgText.Padding = new System.Windows.Forms.Padding(2);
            this.RecieveMsgText.ShowText = false;
            this.RecieveMsgText.Size = new System.Drawing.Size(1244, 264);
            this.RecieveMsgText.Style = Sunny.UI.UIStyle.Custom;
            this.RecieveMsgText.TabIndex = 7;
            this.RecieveMsgText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecieveMsgText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // jkie
            // 
            this.jkie.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jkie.Location = new System.Drawing.Point(16, 367);
            this.jkie.Name = "jkie";
            this.jkie.Size = new System.Drawing.Size(100, 23);
            this.jkie.TabIndex = 8;
            this.jkie.Text = "接收消息：";
            this.jkie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jkie.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ServerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 661);
            this.Controls.Add(this.jkie);
            this.Controls.Add(this.RecieveMsgText);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.MessageSendText);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.IPAddressInput);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ServerSetting";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox IPAddressInput;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox PortInput;
        private Sunny.UI.UIButton ConnectBtn;
        private Sunny.UI.UIRichTextBox MessageSendText;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIRichTextBox RecieveMsgText;
        private Sunny.UI.UILabel jkie;
    }
}

