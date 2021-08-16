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
        string selectedPlayer;
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

            if (!Players.Contains(selectedPlayer))
            {
                SelectedPlayerGroupBox.Text = "Selected Player: None";
            }
        }

        private void PlayerSelected(object sender, EventArgs e)
        {
            if (PlayerListBox.SelectedItem != null)
            {
                selectedPlayer = PlayerListBox.SelectedItem.ToString();
                SelectedPlayerGroupBox.Text = "Selected Player: " + selectedPlayer;
            }
        }
        #region functions
        private void kick_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer("kick " + selectedPlayer);
        }

        private void op_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer("op " + selectedPlayer);
        }

        private void deop_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer("deop " + selectedPlayer);
        }

        private void gmc_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer("gamemode c " + selectedPlayer);
        }

        private void gms_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer("gamemode s " + selectedPlayer);
        }

        private void tp_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer(string.Format("tp {0} {1} {2} {3}", selectedPlayer, tpx.Text, tpy.Text, tpz.Text));
        }

        private void whisper_Click(object sender, EventArgs e)
        {
            parentForm.SendMessageToServer("w " + selectedPlayer + " " + whispertxt.Text);
        }
        #endregion
    }
}
