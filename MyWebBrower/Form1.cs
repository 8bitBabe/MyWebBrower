using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWebBrower
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if enter is hit, check what's written
                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //to go back
            webBrowser1.GoBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            //to go forward
            webBrowser1.GoForward();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Bowser - " + webBrowser1.Document.Title;
        }
    }
}
