namespace B32Machine
{
    partial class MainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRegisters = new System.Windows.Forms.Panel();
            this.lblRegisters = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.b32Screen1 = new B32Machine.B32Screen();
            this.msMainMenu.SuspendLayout();
            this.pnlRegisters.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblerToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(644, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // assemblerToolStripMenuItem
            // 
            this.assemblerToolStripMenuItem.Name = "assemblerToolStripMenuItem";
            this.assemblerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.assemblerToolStripMenuItem.Text = "Assembler";
            this.assemblerToolStripMenuItem.Click += new System.EventHandler(this.assemblerToolStripMenuItem_Click);
            // 
            // pnlRegisters
            // 
            this.pnlRegisters.Controls.Add(this.lblRegisters);
            this.pnlRegisters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRegisters.Location = new System.Drawing.Point(0, 450);
            this.pnlRegisters.Name = "pnlRegisters";
            this.pnlRegisters.Size = new System.Drawing.Size(644, 54);
            this.pnlRegisters.TabIndex = 2;
            // 
            // lblRegisters
            // 
            this.lblRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegisters.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisters.Location = new System.Drawing.Point(0, 0);
            this.lblRegisters.Name = "lblRegisters";
            this.lblRegisters.Size = new System.Drawing.Size(644, 54);
            this.lblRegisters.TabIndex = 0;
            this.lblRegisters.Text = "label1";
            this.lblRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "B32";
            this.openFileDialog1.Filter = "B32 Files | *.B32";
            // 
            // b32Screen1
            // 
            this.b32Screen1.BackColor = System.Drawing.Color.Black;
            this.b32Screen1.Location = new System.Drawing.Point(12, 30);
            this.b32Screen1.Name = "b32Screen1";
            this.b32Screen1.ScreenMemoryLocation = ((ushort)(40960));
            this.b32Screen1.Size = new System.Drawing.Size(429, 408);
            this.b32Screen1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 504);
            this.Controls.Add(this.pnlRegisters);
            this.Controls.Add(this.b32Screen1);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.pnlRegisters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private B32Screen b32Screen1;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblerToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRegisters;
        private System.Windows.Forms.Label lblRegisters;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

