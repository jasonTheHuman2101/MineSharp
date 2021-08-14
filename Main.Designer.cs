
namespace MineSharp
{
    partial class Main
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
            this.startServerButton = new System.Windows.Forms.Button();
            this.stopServerButton = new System.Windows.Forms.Button();
            this.workingDirectoryDisplayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(636, 12);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(73, 20);
            this.startServerButton.TabIndex = 0;
            this.startServerButton.Text = "Start";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.StartServer);
            // 
            // stopServerButton
            // 
            this.stopServerButton.Location = new System.Drawing.Point(715, 12);
            this.stopServerButton.Name = "stopServerButton";
            this.stopServerButton.Size = new System.Drawing.Size(73, 20);
            this.stopServerButton.TabIndex = 1;
            this.stopServerButton.Text = "Stop";
            this.stopServerButton.UseVisualStyleBackColor = true;
            this.stopServerButton.Click += new System.EventHandler(this.StopServer);
            // 
            // workingDirectoryDisplayBox
            // 
            this.workingDirectoryDisplayBox.Location = new System.Drawing.Point(202, 12);
            this.workingDirectoryDisplayBox.Name = "workingDirectoryDisplayBox";
            this.workingDirectoryDisplayBox.Size = new System.Drawing.Size(428, 20);
            this.workingDirectoryDisplayBox.TabIndex = 2;
            this.workingDirectoryDisplayBox.Text = "C:\\Users\\jason\\Desktop\\Code\\VS\\MineCraft_Controller_-_Source_V2\\MineCraft Control" +
    "ler\\bin\\Debug\\servere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to server folder";
            // 
            // serverOutput
            // 
            this.serverOutput.Location = new System.Drawing.Point(9, 51);
            this.serverOutput.Multiline = true;
            this.serverOutput.Name = "serverOutput";
            this.serverOutput.ReadOnly = true;
            this.serverOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serverOutput.ShortcutsEnabled = false;
            this.serverOutput.Size = new System.Drawing.Size(779, 352);
            this.serverOutput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Folder Picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FolderPicker);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(199, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note: Ensure the executable is called \"server.jar\" before running.";
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(12, 409);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(248, 20);
            this.commandBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendCommand);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workingDirectoryDisplayBox);
            this.Controls.Add(this.stopServerButton);
            this.Controls.Add(this.startServerButton);
            this.Name = "Main";
            this.Text = "MineSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.Button stopServerButton;
        private System.Windows.Forms.TextBox workingDirectoryDisplayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button button2;
    }
}

