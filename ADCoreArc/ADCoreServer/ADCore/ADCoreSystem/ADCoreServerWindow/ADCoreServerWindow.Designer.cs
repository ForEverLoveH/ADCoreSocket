namespace ADCore.ADCoreSystem
{
    partial class ADCoreServerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.IPAddressInput = new Sunny.UI.UITextBox();
            this.GetIPButton = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.PortInput = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.ClientDrop = new Sunny.UI.UIComboBox();
            this.RecieveMsg = new Sunny.UI.UIRichTextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SendMessage = new Sunny.UI.UIRichTextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(51, 40);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(94, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "IP地址：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IPAddressInput
            // 
            this.IPAddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPAddressInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPAddressInput.Location = new System.Drawing.Point(121, 33);
            this.IPAddressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPAddressInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.IPAddressInput.Name = "IPAddressInput";
            this.IPAddressInput.ShowText = false;
            this.IPAddressInput.Size = new System.Drawing.Size(239, 30);
            this.IPAddressInput.TabIndex = 1;
            this.IPAddressInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPAddressInput.Watermark = "";
            this.IPAddressInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // GetIPButton
            // 
            this.GetIPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetIPButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetIPButton.Location = new System.Drawing.Point(399, 33);
            this.GetIPButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.GetIPButton.Name = "GetIPButton";
            this.GetIPButton.Size = new System.Drawing.Size(100, 35);
            this.GetIPButton.TabIndex = 2;
            this.GetIPButton.Text = "获取IP";
            this.GetIPButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetIPButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.GetIPButton.Click += new System.EventHandler(this.GetIPButton_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(569, 39);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "端口号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PortInput
            // 
            this.PortInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PortInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortInput.Location = new System.Drawing.Point(652, 39);
            this.PortInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.PortInput.Name = "PortInput";
            this.PortInput.ReadOnly = true;
            this.PortInput.ShowText = false;
            this.PortInput.Size = new System.Drawing.Size(148, 29);
            this.PortInput.TabIndex = 4;
            this.PortInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortInput.Watermark = "";
            this.PortInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(830, 33);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "启动服务";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(974, 40);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(89, 23);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "客户端：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ClientDrop
            // 
            this.ClientDrop.DataSource = null;
            this.ClientDrop.FillColor = System.Drawing.Color.White;
            this.ClientDrop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientDrop.Location = new System.Drawing.Point(1057, 33);
            this.ClientDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientDrop.MinimumSize = new System.Drawing.Size(63, 0);
            this.ClientDrop.Name = "ClientDrop";
            this.ClientDrop.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ClientDrop.Size = new System.Drawing.Size(150, 35);
            this.ClientDrop.TabIndex = 7;
            this.ClientDrop.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientDrop.Watermark = "";
            this.ClientDrop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RecieveMsg
            // 
            this.RecieveMsg.FillColor = System.Drawing.Color.White;
            this.RecieveMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecieveMsg.Location = new System.Drawing.Point(40, 107);
            this.RecieveMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecieveMsg.MinimumSize = new System.Drawing.Size(1, 1);
            this.RecieveMsg.Name = "RecieveMsg";
            this.RecieveMsg.Padding = new System.Windows.Forms.Padding(2);
            this.RecieveMsg.ShowText = false;
            this.RecieveMsg.Size = new System.Drawing.Size(1217, 262);
            this.RecieveMsg.Style = Sunny.UI.UIStyle.Custom;
            this.RecieveMsg.TabIndex = 8;
            this.RecieveMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecieveMsg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(40, 76);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(181, 23);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "接收到的消息：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SendMessage
            // 
            this.SendMessage.FillColor = System.Drawing.Color.White;
            this.SendMessage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendMessage.Location = new System.Drawing.Point(36, 410);
            this.SendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Padding = new System.Windows.Forms.Padding(2);
            this.SendMessage.ShowText = false;
            this.SendMessage.Size = new System.Drawing.Size(1221, 267);
            this.SendMessage.Style = Sunny.UI.UIStyle.Custom;
            this.SendMessage.TabIndex = 10;
            this.SendMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendMessage.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(44, 378);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(134, 23);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "发送的消息：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ADCoreServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 682);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.RecieveMsg);
            this.Controls.Add(this.ClientDrop);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.GetIPButton);
            this.Controls.Add(this.IPAddressInput);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ADCoreServerWindow";
            this.Text = "ADCoreServerWindow";
            this.Load += new System.EventHandler(this.ADCoreServerWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox IPAddressInput;
        private Sunny.UI.UIButton GetIPButton;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox PortInput;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox ClientDrop;
        private Sunny.UI.UIRichTextBox RecieveMsg;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIRichTextBox SendMessage;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.Timer timer1;
    }
}