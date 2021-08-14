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

        public Main()
        {
            InitializeComponent();
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
        }

        private void ReceivedServerOutput(OutputEventArgs e)
        {
            Invoke((MethodInvoker)delegate { serverOutput.Text = serverOutput.Text + Environment.NewLine + e.Output; });
        }

        private void StopServer(object sender, EventArgs e)
        {
            server.Stop();
            server.OnOutputReceived -= ReceivedServerOutput;
        }
    }
}
