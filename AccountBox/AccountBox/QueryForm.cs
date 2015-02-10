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
    public partial class QueryForm : Form
    {
        private XMLOperate xmlOperater;
        private SymmetricMethod symmetricMethod;

        public string SelectedType;

        public QueryForm()
        {
            InitializeComponent();
            if (System.IO.File.Exists("AccountBox"))
            {
                xmlOperater = new XMLOperate("AccountBox");
            }
            else
            {
                xmlOperater = new XMLOperate("c:/AccountBox");
            }
            symmetricMethod = new SymmetricMethod();

            Initialise();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        public void Initialise()
        {
            this.cmbType.Items.Clear();
            XmlNodeList list = xmlOperater.GetChildNodes("accountBox");
            this.cmbType.Items.Add("-------请选择-------");
            this.cmbType.SelectedIndex = 0;
            foreach (XmlNode item in list)
            {
                if (((XmlElement)item).GetAttribute("type") != "zcs")
                {
                    string accountType = ((XmlElement)item).GetAttribute("type");
                    //string nameResult = symmetricMethod.Decrypto(nameSource);
                    this.cmbType.Items.Add(accountType);
                }
            }
            this.txtName.Text = "";
            this.txtCode.Text = "";
            this.labMessage.Text = "";
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryClick();
        }

        /// <summary>
        /// 菜单添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this.xmlOperater, this.symmetricMethod);
            addForm.Owner = this;
            addForm.ShowDialog();
        }

        /// <summary>
        /// 菜单退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
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
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 菜单删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.cmbType.Text != "-------请选择-------")
            {
                this.labMessage.Text = "";

                if (MessageBox.Show("删除后将无法恢复，确认删除？", "提示", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                    return;

                string selectedType = this.cmbType.Text;

                XmlNodeList list = xmlOperater.GetChildNodes("accountBox");
                foreach (XmlNode item in list)
                {
                    string type = ((XmlElement)item).GetAttribute("type");
                    if (type == selectedType)
                    {
                        xmlOperater.RemoveChildNode("accountBox", item);
                        this.Initialise();
                        this.txtCode.Text = "";
                        this.txtName.Text = "";
                    }
                }
            }
            else
            {
                this.labMessage.Text = "请选择账号信息！";
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditUser editUserForm = new EditUser(this.xmlOperater, this.symmetricMethod);
            editUserForm.Owner = this;
            editUserForm.ShowDialog();
        }
        /// <summary>
        /// 查询用户名密码
        /// </summary>
        private void QueryClick()
        {
            string selectedType = this.cmbType.Text;
            bool flag = false;

            XmlNodeList list = xmlOperater.GetChildNodes("accountBox");
            foreach (XmlNode item in list)
            {
                string type = ((XmlElement)item).GetAttribute("type");
                //string nameResult = symmetricMethod.Decrypto(nameSource);
                if (type == selectedType)
                {
                    flag = true;

                    string nameSource = ((XmlElement)item).GetAttribute("name");
                    this.txtName.Text = symmetricMethod.Decrypto(nameSource);

                    string codeSource = ((XmlElement)item).GetAttribute("code");
                    this.txtCode.Text = symmetricMethod.Decrypto(codeSource);
                    this.labMessage.Text = "";
                    return;
                }
            }
            if (flag == false)
            {
                this.txtName.Text = "";
                this.txtCode.Text = "";
                this.labMessage.Text = "查无对应的账号类型！";
            }
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QueryClick();
            }
        }

        /// <summary>
        /// 修改账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.cmbType.Text != "-------请选择-------")
            {
                this.labMessage.Text = "";

                UpdateForm update = new UpdateForm(SelectedType, this.xmlOperater, this.symmetricMethod);
                update.Owner = this;
                update.ShowDialog();
            }
            else
            {
                this.labMessage.Text = "请选择账号信息！";
            }
        }
        /// <summary>
        /// combobox选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
            this.SelectedType = this.cmbType.Text;
        }
        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
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
