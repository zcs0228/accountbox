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
    public partial class UpdateForm : Form
    {
        private XMLOperate xmlOperater;
        private SymmetricMethod symmetricMethod;
        private string selectedType;

        public UpdateForm(string accountType, XMLOperate operater, SymmetricMethod symmetric)
        {
            this.selectedType = accountType;
            InitializeComponent();
            xmlOperater = operater;
            symmetricMethod = symmetric;
            InitializeForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitClick();
        }

        private void InitializeForm()
        {
            XmlNodeList list = xmlOperater.GetChildNodes("accountBox");

            foreach (XmlNode item in list)
            {
                string type = ((XmlElement)item).GetAttribute("type");
                if (type == selectedType)
                {
                    string nameSource = ((XmlElement)item).GetAttribute("name");
                    this.txtName.Text = symmetricMethod.Decrypto(nameSource);

                    string codeSource = ((XmlElement)item).GetAttribute("code");
                    this.txtCode.Text = symmetricMethod.Decrypto(codeSource);
                    this.labMessage.Text = "";
                    return;
                }
            }
        }

        private void SubmitClick()
        {
            string name = symmetricMethod.Encrypto(this.txtName.Text.Trim());
            string code = symmetricMethod.Encrypto(this.txtCode.Text.Trim());

            bool flag = xmlOperater.UpdateXmlNode("accountBox", selectedType, name, code);

            if (flag != true)
            {
                this.labMessage.Text = "更新失败！";
            }
            else
            {
                this.labMessage.Text = "更新成功！";
                //this.Close();
                QueryForm parentForm = (QueryForm)this.Owner;
                parentForm.Initialise();
            }
        }
    }
}
