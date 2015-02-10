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
    public partial class EditUser : Form
    {
        private XMLOperate xmlOperater;
        private SymmetricMethod symmetricMethod;

        public EditUser(XMLOperate operater, SymmetricMethod symmetric)
        {
            InitializeComponent();
            xmlOperater = operater;
            symmetricMethod = symmetric;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitClick();
        }

        private void SubmitClick()
        {
            if (this.txtNewCode1.Text == this.txtNewCode2.Text && this.txtName.Text != "")
            {
                string name = symmetricMethod.Encrypto(this.txtName.Text.Trim());
                string newCode = symmetricMethod.Encrypto(this.txtNewCode1.Text.Trim());

                XmlNode userNode = xmlOperater.SelectNode("accountBox");
                ((XmlElement)userNode).SetAttribute("name", name);
                ((XmlElement)userNode).SetAttribute("code", newCode);

                xmlOperater.SaveXml();
                this.labMessage.Text = "修改成功！";
            }
            else
            {
                this.labMessage.Text = "密码不一致，或者用户名为空！";
            }
        }

        private void txtNewCode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitClick();
            }
        }
    }
}
