using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace WCFWinForm
{
    public partial class WCF : Form
    {
        public WCF()
        {
            InitializeComponent();
        }

        public static void WCF_Load(object sender, EventArgs e)
        {
            //Establish connection with Service
            ServiceHost svc = new ServiceHost(typeof(ApplicationService));
            svc.Credentials.Peer.MeshPassword = "hehe";
            svc.Open();

            //Both Server and Client binding should match
            NetPeerTcpBinding np2p = new NetPeerTcpBinding();

            np2p.Security.Mode = SecurityMode.None;
        }
        
        private void WCF_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(500);
                    this.Hide();
                }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            #region default_browser

            // Create a registry key to read the default browser variable
            RegistryKey reader = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command");
            // Determine the default browser
            string DefaultBrowser = (string)reader.GetValue("");

            //If the path starts with a ", it will end with a "
            if (DefaultBrowser[0] == '"')
            {
                for (int count = 1; count < DefaultBrowser.Length; count++)
                {
                    if (DefaultBrowser[count] == '"')
                    {
                        DefaultBrowser = DefaultBrowser.Remove(count + 1);
                        count = DefaultBrowser.Length + 22;
                    }
                }
            }
            //Otherwise, the path will end with a ' '
            else
            {
                for (int count = 0; count < DefaultBrowser.Length; count++)
                {
                    if (DefaultBrowser[count] == ' ')
                    {
                        DefaultBrowser = DefaultBrowser.Remove(count + 1);
                        count = DefaultBrowser.Length + 22;
                    }
                }
            }

            #endregion default_browser

            #region new tab
            // Open URL in new tab
            if (listURL.SelectedItem == null)
            {
                MessageBox.Show("Select a URL");
            }
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = listURL.Text,
                    FileName = DefaultBrowser,
                    RedirectStandardInput = true,
                    UseShellExecute = false
                };

                System.Diagnostics.Process process = System.Diagnostics.Process.Start(startInfo);
            }
            #endregion new tab

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private static void btnSendURL_MouseClick(object sender, EventArgs e)
        {

            ApplicationService url = new ApplicationService();
            url.GetURL();
        }
    }
}

            
            