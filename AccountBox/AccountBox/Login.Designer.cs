namespace AccountBox
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginCode = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labLoginName = new System.Windows.Forms.Label();
            this.labLoginCode = new System.Windows.Forms.Label();
            this.labMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginName.Location = new System.Drawing.Point(115, 36);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(100, 23);
            this.txtLoginName.TabIndex = 0;
            // 
            // txtLoginCode
            // 
            this.txtLoginCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginCode.Location = new System.Drawing.Point(115, 80);
            this.txtLoginCode.Name = "txtLoginCode";
            this.txtLoginCode.PasswordChar = '*';
            this.txtLoginCode.Size = new System.Drawing.Size(100, 23);
            this.txtLoginCode.TabIndex = 1;
            this.txtLoginCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginCode_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(83, 129);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            // 
            // labLoginName
            // 
            this.labLoginName.AutoSize = true;
            this.labLoginName.Location = new System.Drawing.Point(49, 40);
            this.labLoginName.Name = "labLoginName";
            this.labLoginName.Size = new System.Drawing.Size(53, 12);
            this.labLoginName.TabIndex = 3;
            this.labLoginName.Text = "登录名：";
            // 
            // labLoginCode
            // 
            this.labLoginCode.AutoSize = true;
            this.labLoginCode.Location = new System.Drawing.Point(51, 84);
            this.labLoginCode.Name = "labLoginCode";
            this.labLoginCode.Size = new System.Drawing.Size(53, 12);
            this.labLoginCode.TabIndex = 4;
            this.labLoginCode.Text = "密  码：";
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.ForeColor = System.Drawing.Color.Red;
            this.labMessage.Location = new System.Drawing.Point(66, 175);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 12);
            this.labMessage.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 232);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.labLoginCode);
            this.Controls.Add(this.labLoginName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginCode);
            this.Controls.Add(this.txtLoginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labLoginName;
        private System.Windows.Forms.Label labLoginCode;
        private System.Windows.Forms.Label labMessage;
    }
}