using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp
{
    class xmlDemo2
    {
        static void Main123(String[] args)
        {
            String lang = "en";
            FileStream fs = new FileStream("c:\\Demo.xml", FileMode.Open, FileAccess.Read);
            XmlDocument doc = new XmlDocument();
            doc.Load(fs);
            XmlNodeList node = doc.GetElementsByTagName("lang");
            for (int i = 0; i < node.Count; i++)
            {                
                string langTemp = node[i].Attributes["id"].Value;              
                if (langTemp == lang)
                {
                    for (int j = 0; j < node[i].ChildNodes.Count; j++)
                    {
                        Console.WriteLine(node[i].ChildNodes[j].InnerText);
                    }                   
                }
                
            }  

        }
    }
}
