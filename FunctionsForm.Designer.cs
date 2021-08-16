
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
            this.SelectedPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.tpz = new System.Windows.Forms.TextBox();
            this.tpy = new System.Windows.Forms.TextBox();
            this.tpx = new System.Windows.Forms.TextBox();
            this.tp = new System.Windows.Forms.Button();
            this.gms = new System.Windows.Forms.Button();
            this.deop = new System.Windows.Forms.Button();
            this.whispertxt = new System.Windows.Forms.TextBox();
            this.whisper = new System.Windows.Forms.Button();
            this.gmc = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.Button();
            this.kick = new System.Windows.Forms.Button();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.SelectedPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedPlayerGroupBox
            // 
            this.SelectedPlayerGroupBox.Controls.Add(this.tpz);
            this.SelectedPlayerGroupBox.Controls.Add(this.tpy);
            this.SelectedPlayerGroupBox.Controls.Add(this.tpx);
            this.SelectedPlayerGroupBox.Controls.Add(this.tp);
            this.SelectedPlayerGroupBox.Controls.Add(this.gms);
            this.SelectedPlayerGroupBox.Controls.Add(this.deop);
            this.SelectedPlayerGroupBox.Controls.Add(this.whispertxt);
            this.SelectedPlayerGroupBox.Controls.Add(this.whisper);
            this.SelectedPlayerGroupBox.Controls.Add(this.gmc);
            this.SelectedPlayerGroupBox.Controls.Add(this.op);
            this.SelectedPlayerGroupBox.Controls.Add(this.kick);
            this.SelectedPlayerGroupBox.Location = new System.Drawing.Point(333, 7);
            this.SelectedPlayerGroupBox.Name = "SelectedPlayerGroupBox";
            this.SelectedPlayerGroupBox.Size = new System.Drawing.Size(247, 147);
            this.SelectedPlayerGroupBox.TabIndex = 2;
            this.SelectedPlayerGroupBox.TabStop = false;
            this.SelectedPlayerGroupBox.Text = "Selected Player: None";
            // 
            // tpz
            // 
            this.tpz.Location = new System.Drawing.Point(206, 79);
            this.tpz.Name = "tpz";
            this.tpz.Size = new System.Drawing.Size(35, 20);
            this.tpz.TabIndex = 10;
            // 
            // tpy
            // 
            this.tpy.Location = new System.Drawing.Point(165, 79);
            this.tpy.Name = "tpy";
            this.tpy.Size = new System.Drawing.Size(35, 20);
            this.tpy.TabIndex = 9;
            // 
            // tpx
            // 
            this.tpx.Location = new System.Drawing.Point(124, 79);
            this.tpx.Name = "tpx";
            this.tpx.Size = new System.Drawing.Size(35, 20);
            this.tpx.TabIndex = 8;
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(87, 77);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(31, 23);
            this.tp.TabIndex = 7;
            this.tp.Text = "TP";
            this.tp.UseVisualStyleBackColor = true;
            this.tp.Click += new System.EventHandler(this.tp_Click);
            // 
            // gms
            // 
            this.gms.Location = new System.Drawing.Point(43, 77);
            this.gms.Name = "gms";
            this.gms.Size = new System.Drawing.Size(38, 23);
            this.gms.TabIndex = 6;
            this.gms.Text = "S";
            this.gms.UseVisualStyleBackColor = true;
            this.gms.Click += new System.EventHandler(this.gms_Click);
            // 
            // deop
            // 
            this.deop.Location = new System.Drawing.Point(123, 48);
            this.deop.Name = "deop";
            this.deop.Size = new System.Drawing.Size(118, 23);
            this.deop.TabIndex = 5;
            this.deop.Text = "DEOP";
            this.deop.UseVisualStyleBackColor = true;
            this.deop.Click += new System.EventHandler(this.deop_Click);
            // 
            // whispertxt
            // 
            this.whispertxt.Location = new System.Drawing.Point(87, 108);
            this.whispertxt.Name = "whispertxt";
            this.whispertxt.Size = new System.Drawing.Size(154, 20);
            this.whispertxt.TabIndex = 4;
            // 
            // whisper
            // 
            this.whisper.Location = new System.Drawing.Point(6, 106);
            this.whisper.Name = "whisper";
            this.whisper.Size = new System.Drawing.Size(75, 23);
            this.whisper.TabIndex = 3;
            this.whisper.Text = "Whisper";
            this.whisper.UseVisualStyleBackColor = true;
            this.whisper.Click += new System.EventHandler(this.whisper_Click);
            // 
            // gmc
            // 
            this.gmc.Location = new System.Drawing.Point(6, 77);
            this.gmc.Name = "gmc";
            this.gmc.Size = new System.Drawing.Size(38, 23);
            this.gmc.TabIndex = 2;
            this.gmc.Text = "C";
            this.gmc.UseVisualStyleBackColor = true;
            this.gmc.Click += new System.EventHandler(this.gmc_Click);
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(6, 48);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(119, 23);
            this.op.TabIndex = 1;
            this.op.Text = "OP";
            this.op.UseVisualStyleBackColor = true;
            this.op.Click += new System.EventHandler(this.op_Click);
            // 
            // kick
            // 
            this.kick.Location = new System.Drawing.Point(6, 19);
            this.kick.Name = "kick";
            this.kick.Size = new System.Drawing.Size(235, 23);
            this.kick.TabIndex = 0;
            this.kick.Text = "Kick";
            this.kick.UseVisualStyleBackColor = true;
            this.kick.Click += new System.EventHandler(this.kick_Click);
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.Location = new System.Drawing.Point(12, 7);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(315, 147);
            this.PlayerListBox.TabIndex = 3;
            this.PlayerListBox.SelectedValueChanged += new System.EventHandler(this.PlayerSelected);
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 161);
            this.ControlBox = false;
            this.Controls.Add(this.PlayerListBox);
            this.Controls.Add(this.SelectedPlayerGroupBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FunctionsForm";
            this.Text = "MineSharp Server Toolbox";
            this.SelectedPlayerGroupBox.ResumeLayout(false);
            this.SelectedPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SelectedPlayerGroupBox;
        private System.Windows.Forms.TextBox tpz;
        private System.Windows.Forms.TextBox tpy;
        private System.Windows.Forms.TextBox tpx;
        private System.Windows.Forms.Button tp;
        private System.Windows.Forms.Button gms;
        private System.Windows.Forms.Button deop;
        private System.Windows.Forms.TextBox whispertxt;
        private System.Windows.Forms.Button whisper;
        private System.Windows.Forms.Button gmc;
        private System.Windows.Forms.Button op;
        private System.Windows.Forms.Button kick;
        private System.Windows.Forms.ListBox PlayerListBox;
    }
}