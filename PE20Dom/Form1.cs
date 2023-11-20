using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


            Console.WriteLine(webBrowser1.Document);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("h1");
            htmlElementCollection[0].InnerText = "My UFO Page";


            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("h2");
            htmlElementCollection[0].InnerText = "My UFO Info";
            htmlElementCollection[1].InnerText = "My UFO Pictures";
            htmlElementCollection[2].InnerText = "";


            htmlElement = webBrowser1.Document.Body;
            htmlElement.Style = "color: #FF0000;";
            htmlElement.Style = "font-family: sans-serif;";

            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("p");

            htmlElement = htmlElementCollection[0];
            htmlElement.Style = "color: green;";
            htmlElement.Style = "font-weight: bold;";
            htmlElement.Style = "font-size: 2em;";
            htmlElement.Style = "text-transform: uppercase;";
            htmlElement.Style = "text-shadow: 3px 2px #A44;";

            htmlElementCollection[0].InnerHtml = "REPORT YOUR UFO SIGHTINGS HERE: <a href = \"http://www.nuforc.org\"> WWW.NUFORC.ORG </a>";

            HtmlElement lastElement;

            lastElement = webBrowser1.Document.GetElementById("lastParagraph");
            lastElement.OuterHtml = "<img src = \"https://th.bing.com/th/id/R.1cf3dee491a4ff5107a4d0827ffb7fcc?rik=5EMb%2fFuULW28Wg&pid=ImgRaw&r=0\" width = 300 height = 300>";

            htmlElement = webBrowser1.Document.CreateElement("footer");
            htmlElement.InnerText = "@2023 N. Huber";

            lastElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterEnd, htmlElement);


        }

    }
}
