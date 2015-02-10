using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AccountBox
{
    public class XMLOperate
    {
        private static XmlDocument objXmlDoc = null;
        private static string XmlFilePath;

        public XMLOperate(string xmlFilePath)
        {
            objXmlDoc = new XmlDocument();
            XmlFilePath = xmlFilePath;
            //objXmlDoc.Load(_XmlFilePath);

            if (System.IO.File.Exists(xmlFilePath))
            {
                objXmlDoc.Load(xmlFilePath);
            }
            else
            {
                CreateXmlFile(XmlFilePath);
            }
        }
        /// <summary>
        /// 插入子节点
        /// </summary>
        /// <param name="parentNodeName"></param>
        /// <param name="childNodeName"></param>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool InsertSingleNode(string parentNodeName, string childNodeName, string accountType, string name, string code)
        {
            try
            {
                //objXmlDoc.Load(_XmlFilePath);
                //插入一节点
                XmlNode objRootNode = objXmlDoc.SelectSingleNode(parentNodeName);
                XmlElement childNode = objXmlDoc.CreateElement(childNodeName);
                childNode.SetAttribute("type", accountType);
                childNode.SetAttribute("name", name);
                childNode.SetAttribute("code", code);

                objRootNode.AppendChild(childNode);

                objXmlDoc.Save(XmlFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 获得自定根节点的子节点
        /// </summary>
        /// <param name="parentName"></param>
        /// <returns></returns>
        public XmlNodeList GetChildNodes(string parentName)
        {
            XmlNode rootNode = objXmlDoc.SelectSingleNode(parentName);
            XmlNodeList result = rootNode.ChildNodes;
            return result;
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="parentName"></param>
        /// <param name="node"></param>
        public void RemoveChildNode(string parentName, XmlNode node)
        {
            XmlNode rootNode = objXmlDoc.SelectSingleNode(parentName);
            rootNode.RemoveChild(node);
            objXmlDoc.Save(XmlFilePath);
        }
        /// <summary>
        /// 查找user节点
        /// </summary>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public XmlNode SelectNode(string parentName)
        {
            XmlNode rootNode = objXmlDoc.SelectSingleNode(parentName);
            XmlNodeList nodeList = rootNode.ChildNodes;

            return nodeList[0];
        }
        /// <summary>
        /// 根据用户类型获得节点
        /// </summary>
        /// <param name="parentName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public XmlNode GetNodeByType(string parentName, string type)
        {
            XmlNodeList list =  GetChildNodes(parentName);
            XmlNode result = list[0];

            foreach (XmlNode item in list)
            {
                string accountType = ((XmlElement)item).GetAttribute("type");
                if (accountType == type)
                {
                    result = (XmlElement)item;
                }
            }
            return result;
        }
        /// <summary>
        /// 更新用户名密码
        /// </summary>
        /// <param name="parentName"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool UpdateXmlNode(string parentName, string type, string name, string code)
        {
            //更新内容。
            try
            {
                XmlNode rootNode = objXmlDoc.SelectSingleNode(parentName);
                XmlNodeList nodeList = rootNode.ChildNodes;

                foreach (XmlNode item in nodeList)
                {
                    string accountType = ((XmlElement)item).GetAttribute("type");
                    if (type == accountType)
                    {
                        ((XmlElement)item).SetAttribute("name", name);
                        ((XmlElement)item).SetAttribute("code", code);
                    }
                }

                objXmlDoc.Save(XmlFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetNodeContent(string XmlNode)
        {
            return objXmlDoc.SelectSingleNode(XmlNode).InnerText;
        }
        /// <summary>
        /// 保存XML文件
        /// </summary>
        public void SaveXml()
        {
            try
            {
                objXmlDoc.Save(XmlFilePath);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// 创建XML文件
        /// </summary>
        /// <param name="xmlFilePath"></param>
        private void CreateXmlFile(string xmlFilePath)
        {
            try
            {
                XmlDeclaration xmldecl = objXmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                objXmlDoc.AppendChild(xmldecl);

                XmlElement rootElement = objXmlDoc.CreateElement("", "accountBox", "");
                objXmlDoc.AppendChild(rootElement);
                InsertSingleNode("accountBox", "user", "zcs", "yysjrKitlmxetrLb7xRHcA==", "1+YJfgTtEII+jsPGyGK2vg==");
                objXmlDoc.Save(XmlFilePath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
