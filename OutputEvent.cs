using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSharp
{
    public delegate void OutputEventHandler(OutputEventArgs e);
    public class OutputEventArgs : EventArgs
    {
        public string Output = "";

        public OutputEventArgs(string output)
            : base()
        {
            Output = output;
        }
    }
}
