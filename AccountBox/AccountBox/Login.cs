using Encryption.DESFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AccountBox
{
    public partial class Login : Form
    {
        private string LoginName;
        private string LoginCode;
        private XMLOperate xmlOperater;
        private SymmetricMethod symmetricMethod;

        public Login()
        {
            InitializeComponent();
            if (System.IO.File.Exists("AccountBox.bat"))
            {
                DESFileEncryption.DecryptFile("AccountBox.bat", "AccountBox", "zcs&wxt00896014");
                System.IO.File.Delete("AccountBox.bat");
                xmlOperater = new XMLOperate("AccountBox");
            }
            else
            {
                if (System.IO.File.Exists("c:/AccountBox.bat"))
                {
                    DESFileEncryption.DecryptFile("c:/AccountBox.bat", "c:/AccountBox", "zcs&wxt00896014");
                    System.IO.File.Delete("c:/AccountBox.bat");
                }
                xmlOperater = new XMLOperate("c:/AccountBox");
            }
            this.DialogResult = DialogResult.No;
            symmetricMethod = new SymmetricMethod();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClick();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginClick();
            }
        }

        private void txtLoginCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginClick();
            }
        }

        private void LoginClick()
        {
            XmlNode userNode = xmlOperater.SelectNode("accountBox");
            LoginName = symmetricMethod.Decrypto(((XmlElement)userNode).GetAttribute("name"));
            LoginCode = symmetricMethod.Decrypto(((XmlElement)userNode).GetAttribute("code"));
            if (this.txtLoginName.Text == LoginName && this.txtLoginCode.Text == LoginCode)
            {
                //this.Hide();
                //QueryForm queryForm = new QueryForm();
                //queryForm.ShowDialog();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.labMessage.Text = "用户名或密码错误！";
            }
        }
        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                if (System.IO.File.Exists("AccountBox"))
                {
                    DESFileEncryption.EncryptFile("AccountBox", "AccountBox.bat", "zcs&wxt00896014");
                    System.IO.File.Delete("AccountBox");
                }
                else
                {
                    DESFileEncryption.EncryptFile("c:/AccountBox", "c:/AccountBox.bat", "zcs&wxt00896014");
                    System.IO.File.Delete("c:/AccountBox");
                }
            }
        }
    }
}
