using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSharp
{
    public partial class Main : Form
    {
        MinecraftServer server;
        List<string> PlayerList = new List<string>();

        public Main()
        {
            InitializeComponent();
            this.FormClosing += CloseCommandSent;
        }

        private void CloseCommandSent(object sender, FormClosingEventArgs e)
        {
            try { server.Stop(); } catch { }
        }

        private void FolderPicker(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                workingDirectoryDisplayBox.Text = dialog.FileName;
            }
        }

        private void StartServer(object sender, EventArgs e)
        {
            server = new MinecraftServer();
            server.OnOutputReceived += ReceivedServerOutput;
            server.Launch(workingDirectoryDisplayBox.Text);
            statusIndicator.BackColor = Color.YellowGreen;
        }

        private void ReceivedServerOutput(OutputEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)delegate { serverOutput.Text = serverOutput.Text + Environment.NewLine + e.Output; });
                if(e.Output.Contains("For help"))//
                {
                    Invoke((MethodInvoker)delegate{ statusIndicator.BackColor = Color.Green; });
                }
                if (e.Output.Contains("Stopping server"))//
                {
                    Invoke((MethodInvoker)delegate { statusIndicator.BackColor = Color.DarkRed; });
                }
            }
            catch { }
        }

        private void StopServer(object sender, EventArgs e)
        {
            server.Stop();
            server.OnOutputReceived -= ReceivedServerOutput;
            statusIndicator.BackColor = Color.DarkRed;
        }

        private void SendCommand(object sender, EventArgs e)
        {
            server.SendCommand(commandBox.Text);
            commandBox.Text = "";
        }
    }
}
