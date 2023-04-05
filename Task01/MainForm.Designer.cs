namespace Task01
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbMain = new PictureBox();
            msImage = new MenuStrip();
            tsmnChooseImage = new ToolStripMenuItem();
            tsmFox = new ToolStripMenuItem();
            tsmTiger = new ToolStripMenuItem();
            tsmMonkey = new ToolStripMenuItem();
            tsImage = new ToolStrip();
            tsbFox = new ToolStripButton();
            tsbTiger = new ToolStripButton();
            tsbMonkey = new ToolStripButton();
            cmsImage = new ContextMenuStrip(components);
            cmsFox = new ToolStripMenuItem();
            cmsTiger = new ToolStripMenuItem();
            cmsMonkey = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            msImage.SuspendLayout();
            tsImage.SuspendLayout();
            cmsImage.SuspendLayout();
            SuspendLayout();
            // 
            // pbMain
            // 
            pbMain.Image = Properties.Resources.start;
            pbMain.Location = new Point(0, 60);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(800, 392);
            pbMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMain.TabIndex = 2;
            pbMain.TabStop = false;
            // 
            // msImage
            // 
            msImage.ImageScalingSize = new Size(24, 24);
            msImage.Items.AddRange(new ToolStripItem[] { tsmnChooseImage });
            msImage.Location = new Point(0, 0);
            msImage.Name = "msImage";
            msImage.Size = new Size(800, 33);
            msImage.TabIndex = 3;
            msImage.Text = "menuStrip1";
            // 
            // tsmnChooseImage
            // 
            tsmnChooseImage.Checked = true;
            tsmnChooseImage.CheckState = CheckState.Checked;
            tsmnChooseImage.DropDownItems.AddRange(new ToolStripItem[] { tsmFox, tsmTiger, tsmMonkey });
            tsmnChooseImage.Name = "tsmnChooseImage";
            tsmnChooseImage.Size = new Size(143, 29);
            tsmnChooseImage.Text = "Choose Image";
            // 
            // tsmFox
            // 
            tsmFox.Image = Properties.Resources.fox;
            tsmFox.Name = "tsmFox";
            tsmFox.Size = new Size(270, 34);
            tsmFox.Text = "Fox";
            // 
            // tsmTiger
            // 
            tsmTiger.Image = Properties.Resources.tiger;
            tsmTiger.Name = "tsmTiger";
            tsmTiger.Size = new Size(270, 34);
            tsmTiger.Text = "Tiger";
            // 
            // tsmMonkey
            // 
            tsmMonkey.Image = Properties.Resources.monkey;
            tsmMonkey.Name = "tsmMonkey";
            tsmMonkey.Size = new Size(270, 34);
            tsmMonkey.Text = "Monkey";
            // 
            // tsImage
            // 
            tsImage.ImageScalingSize = new Size(24, 24);
            tsImage.Items.AddRange(new ToolStripItem[] { tsbFox, tsbTiger, tsbMonkey });
            tsImage.Location = new Point(0, 33);
            tsImage.Name = "tsImage";
            tsImage.Size = new Size(800, 33);
            tsImage.TabIndex = 4;
            tsImage.Text = "toolStrip1";
            // 
            // tsbFox
            // 
            tsbFox.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFox.Image = Properties.Resources.fox;
            tsbFox.ImageTransparentColor = Color.Magenta;
            tsbFox.Name = "tsbFox";
            tsbFox.Size = new Size(34, 28);
            tsbFox.Text = "toolStripButton1";
            // 
            // tsbTiger
            // 
            tsbTiger.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbTiger.Image = Properties.Resources.tiger;
            tsbTiger.ImageTransparentColor = Color.Magenta;
            tsbTiger.Name = "tsbTiger";
            tsbTiger.Size = new Size(34, 28);
            tsbTiger.Text = "toolStripButton2";
            // 
            // tsbMonkey
            // 
            tsbMonkey.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbMonkey.Image = Properties.Resources.monkey;
            tsbMonkey.ImageTransparentColor = Color.Magenta;
            tsbMonkey.Name = "tsbMonkey";
            tsbMonkey.Size = new Size(34, 28);
            tsbMonkey.Text = "toolStripButton3";
            // 
            // cmsImage
            // 
            cmsImage.ImageScalingSize = new Size(24, 24);
            cmsImage.Items.AddRange(new ToolStripItem[] { cmsFox, cmsTiger, cmsMonkey });
            cmsImage.Name = "contextMenuStrip1";
            cmsImage.Size = new Size(157, 100);
            // 
            // cmsFox
            // 
            cmsFox.Image = Properties.Resources.fox;
            cmsFox.Name = "cmsFox";
            cmsFox.Size = new Size(156, 32);
            cmsFox.Text = "Fox";
            // 
            // cmsTiger
            // 
            cmsTiger.Image = Properties.Resources.tiger;
            cmsTiger.Name = "cmsTiger";
            cmsTiger.Size = new Size(156, 32);
            cmsTiger.Text = "Tiger";
            // 
            // cmsMonkey
            // 
            cmsMonkey.Image = Properties.Resources.monkey;
            cmsMonkey.Name = "cmsMonkey";
            cmsMonkey.Size = new Size(156, 32);
            cmsMonkey.Text = "Monkey";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cmsImage;
            Controls.Add(tsImage);
            Controls.Add(pbMain);
            Controls.Add(msImage);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            msImage.ResumeLayout(false);
            msImage.PerformLayout();
            tsImage.ResumeLayout(false);
            tsImage.PerformLayout();
            cmsImage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMain;
        private MenuStrip msImage;
        private ToolStripMenuItem tsmnChooseImage;
        private ToolStripMenuItem tsmFox;
        private ToolStripMenuItem tsmTiger;
        private ToolStripMenuItem tsmMonkey;
        private ToolStrip tsImage;
        private ToolStripButton tsbFox;
        private ToolStripButton tsbTiger;
        private ToolStripButton tsbMonkey;
        private ContextMenuStrip cmsImage;
        private ToolStripMenuItem cmsFox;
        private ToolStripMenuItem cmsTiger;
        private ToolStripMenuItem cmsMonkey;
    }
}