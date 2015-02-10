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
    public partial class AddForm : Form
    {
        private XMLOperate xmlOperater;
        private SymmetricMethod symmetricMethod;

        public AddForm(XMLOperate operater, SymmetricMethod symmetric)
        {
            InitializeComponent();
            xmlOperater = operater;
            symmetricMethod = symmetric;
        }
        /// <summary>
        /// 添加账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            saveClick();
        }
        /// <summary>
        /// 验证同名
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public bool ValidateType(string typeName)
        {

            XmlNodeList list = xmlOperater.GetChildNodes("accountBox");
            foreach (XmlNode item in list)
            {
                string type = ((XmlElement)item).GetAttribute("type");
                //string nameResult = symmetricMethod.Decrypto(nameSource);
                if (type == typeName)
                {
                    return false;
                }
            }
            return true;
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.saveClick();
            }
        }

        private void saveClick()
        {
            string childName = "a" + System.Guid.NewGuid();//txtType.Text.ToString().Trim();
            string accountType = txtType.Text.ToString().Trim();
            if (!ValidateType(accountType))
            {
                labMessage.Text = "已存在同名账号类型！";
                return;
            }
            string name = symmetricMethod.Encrypto(txtName.Text.ToString().Trim());
            string code = symmetricMethod.Encrypto(txtCode.Text.ToString().Trim());

            bool flag = xmlOperater.InsertSingleNode("accountBox", childName, accountType, name, code);

            if (flag == true)
            {
                this.labMessage.Text = "添加成功";
                this.Close();
                QueryForm parentForm = (QueryForm)this.Owner;
                parentForm.Initialise();
            }
            else
            {
                this.labMessage.Text = "添加失败";
            }
        }
    }
}
