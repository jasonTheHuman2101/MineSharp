using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSharp
{
    public partial class FunctionsForm : Form
    {
        public Main parentForm;
        public List<string> Players = new List<string>();

        public FunctionsForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += UpdateFormDetails;
            timer.Start();
        }

        private void UpdateFormDetails(object sender, EventArgs e)//runs every 1000ms to update the player list
        {
            PlayerListBox.Items.Clear();
            PlayerListBox.Items.Clear();
            for(int i = 0; i < Players.Count; i++)
            {
                PlayerListBox.Items.Add(Players[i]);
            }
        }

        private void PlayerSelected(object sender, EventArgs e)
        {
            string selectedPlayer = PlayerListBox.Items[PlayerListBox.SelectedIndex].ToString();
        }
    }
}
