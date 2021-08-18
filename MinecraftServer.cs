using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSharp
{
    class MinecraftServer
    {
        public event OutputEventHandler OnOutputReceived;
        private Process ServerProcess;
        bool serverRunning = false;
        private StreamWriter InputStreamWriter;
        private DataReceivedEventHandler TheDataReceievedEventHandler;

        public MinecraftServer()
        {
            OnOutputReceived = new OutputEventHandler(OnOutputReceived_method);
        }

        private void OnOutputReceived_method(OutputEventArgs e){}

        public bool Launch(string _serverPath, string jvmExePath, string ramAllocation)
        {
            bool ready = false;

            if (!serverRunning)
            {
                try
                {
                    string jarFile = _serverPath + "\\server.jar";

                    ProcessStartInfo ssi = new ProcessStartInfo(jvmExePath, ramAllocation+" -jar \"" + jarFile + "\" nogui -nojline")
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        WorkingDirectory = _serverPath
                    };

                    if((ServerProcess = Process.Start(ssi)) != null)
                    {
                        ready = true;
                        serverRunning = true;
                        ServerProcess.EnableRaisingEvents = true;
                        ServerProcess.Exited += new EventHandler(ServerProcess_Exited);
                        InputStreamWriter = ServerProcess.StandardInput;

                        TheDataReceievedEventHandler = new DataReceivedEventHandler(StandardOutputHandler); //todo
                        ServerProcess.OutputDataReceived += TheDataReceievedEventHandler;
                        ServerProcess.BeginOutputReadLine();
                        ServerProcess.ErrorDataReceived += TheDataReceievedEventHandler;
                        ServerProcess.BeginErrorReadLine();
                    }
                }
                catch
                {

                }
            }
            else
            {
                ready = true;     
            }

            return ready;
        }

        public bool Stop()
        {
            if (serverRunning)
            {
                try
                {
                    SendCommand("stop");
                    SendCommand("");

                    return ServerProcess.WaitForExit(20000);
                }
                catch
                {
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool SendCommand(string Command)
        {
            try
            {
                if (serverRunning)
                {
                    InputStreamWriter.WriteLine(Command);
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        private void StandardOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!(String.IsNullOrEmpty(outLine.Data)))
            {
                OnOutputReceived.Invoke(new OutputEventArgs(outLine.Data));
            }
        }

        private void ServerProcess_Exited(object sender, EventArgs e)
        {
            try
            {
                if (serverRunning)
                {
                    serverRunning = false;

                    ServerProcess.CancelOutputRead();
                    ServerProcess.CancelErrorRead();

                    ServerProcess.OutputDataReceived -= TheDataReceievedEventHandler;
                    ServerProcess.ErrorDataReceived -= TheDataReceievedEventHandler;

                    ServerProcess.Close();

                    ServerProcess.Dispose();
                    ServerProcess = null;
                }
            }
            catch
            {
            }
        }
    }
}
