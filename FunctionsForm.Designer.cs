
namespace MineSharp
{
    partial class FunctionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(315, 134);
            this.PlayerListBox.TabIndex = 0;
            this.PlayerListBox.SelectedIndexChanged += new System.EventHandler(this.PlayerSelected);
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 161);
            this.ControlBox = false;
            this.Controls.Add(this.PlayerListBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FunctionsForm";
            this.Text = "MineSharp Server Toolbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PlayerListBox;
    }
}