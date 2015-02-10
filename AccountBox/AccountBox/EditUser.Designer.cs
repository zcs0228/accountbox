namespace AccountBox
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNewCode2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNewCode1 = new System.Windows.Forms.TextBox();
            this.labMessage = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labNewCode = new System.Windows.Forms.Label();
            this.labNewCode1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(100, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtNewCode2
            // 
            this.txtNewCode2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewCode2.Location = new System.Drawing.Point(100, 105);
            this.txtNewCode2.Name = "txtNewCode2";
            this.txtNewCode2.PasswordChar = '*';
            this.txtNewCode2.Size = new System.Drawing.Size(147, 23);
            this.txtNewCode2.TabIndex = 2;
            this.txtNewCode2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewCode2_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(86, 162);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNewCode1
            // 
            this.txtNewCode1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewCode1.Location = new System.Drawing.Point(100, 72);
            this.txtNewCode1.Name = "txtNewCode1";
            this.txtNewCode1.PasswordChar = '*';
            this.txtNewCode1.Size = new System.Drawing.Size(147, 23);
            this.txtNewCode1.TabIndex = 1;
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.ForeColor = System.Drawing.Color.Red;
            this.labMessage.Location = new System.Drawing.Point(84, 209);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 12);
            this.labMessage.TabIndex = 5;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(34, 37);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(65, 12);
            this.labName.TabIndex = 6;
            this.labName.Text = "新用户名：";
            // 
            // labNewCode
            // 
            this.labNewCode.AutoSize = true;
            this.labNewCode.Location = new System.Drawing.Point(36, 76);
            this.labNewCode.Name = "labNewCode";
            this.labNewCode.Size = new System.Drawing.Size(53, 12);
            this.labNewCode.TabIndex = 7;
            this.labNewCode.Text = "新密码：";
            // 
            // labNewCode1
            // 
            this.labNewCode1.AutoSize = true;
            this.labNewCode1.Location = new System.Drawing.Point(36, 109);
            this.labNewCode1.Name = "labNewCode1";
            this.labNewCode1.Size = new System.Drawing.Size(65, 12);
            this.labNewCode1.TabIndex = 8;
            this.labNewCode1.Text = "确认密码：";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 245);
            this.Controls.Add(this.labNewCode1);
            this.Controls.Add(this.labNewCode);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.txtNewCode1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNewCode2);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNewCode2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtNewCode1;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labNewCode;
        private System.Windows.Forms.Label labNewCode1;
    }
}