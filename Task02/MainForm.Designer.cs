namespace Task02
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
            cmsForm = new ContextMenuStrip(components);
            addPanelToolStripMenuItem = new ToolStripMenuItem();
            tmsiOne = new ToolStripMenuItem();
            tsmiFive = new ToolStripMenuItem();
            tmsiTen = new ToolStripMenuItem();
            removeAllPanelsToolStripMenuItem = new ToolStripMenuItem();
            cmsPanel = new ContextMenuStrip(components);
            tsmiRemove = new ToolStripMenuItem();
            cmsForm.SuspendLayout();
            cmsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cmsForm
            // 
            cmsForm.ImageScalingSize = new Size(24, 24);
            cmsForm.Items.AddRange(new ToolStripItem[] { addPanelToolStripMenuItem, removeAllPanelsToolStripMenuItem });
            cmsForm.Name = "cmsForm";
            cmsForm.Size = new Size(241, 101);
            // 
            // addPanelToolStripMenuItem
            // 
            addPanelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tmsiOne, tsmiFive, tmsiTen });
            addPanelToolStripMenuItem.Name = "addPanelToolStripMenuItem";
            addPanelToolStripMenuItem.Size = new Size(240, 32);
            addPanelToolStripMenuItem.Text = "Add";
            // 
            // tmsiOne
            // 
            tmsiOne.Name = "tmsiOne";
            tmsiOne.Size = new Size(190, 34);
            tmsiOne.Tag = "1";
            tmsiOne.Text = "1 panel";
            tmsiOne.Click += cmsFormitem_Click;
            // 
            // tsmiFive
            // 
            tsmiFive.Name = "tsmiFive";
            tsmiFive.Size = new Size(190, 34);
            tsmiFive.Tag = "5";
            tsmiFive.Text = "5 panels";
            tsmiFive.Click += cmsFormitem_Click;
            // 
            // tmsiTen
            // 
            tmsiTen.Name = "tmsiTen";
            tmsiTen.Size = new Size(190, 34);
            tmsiTen.Tag = "10";
            tmsiTen.Text = "10 panels";
            tmsiTen.Click += cmsFormitem_Click;
            // 
            // removeAllPanelsToolStripMenuItem
            // 
            removeAllPanelsToolStripMenuItem.Name = "removeAllPanelsToolStripMenuItem";
            removeAllPanelsToolStripMenuItem.Size = new Size(240, 32);
            removeAllPanelsToolStripMenuItem.Text = "Remove all panels";
            removeAllPanelsToolStripMenuItem.Click += removeAllPanelsToolStripMenuItem_Click;
            // 
            // cmsPanel
            // 
            cmsPanel.ImageScalingSize = new Size(24, 24);
            cmsPanel.Items.AddRange(new ToolStripItem[] { tsmiRemove });
            cmsPanel.Name = "cmsPanel";
            cmsPanel.Size = new Size(149, 36);
            cmsPanel.Click += cmsFormitem_Click;
            // 
            // tsmiRemove
            // 
            tsmiRemove.Name = "tsmiRemove";
            tsmiRemove.Size = new Size(148, 32);
            tsmiRemove.Text = "Remove";
            tsmiRemove.Click += tsmiRemove_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cmsForm;
            Name = "MainForm";
            Text = "Task02";
            cmsForm.ResumeLayout(false);
            cmsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip cmsForm;
        private ToolStripMenuItem addPanelToolStripMenuItem;
        private ToolStripMenuItem tmsiOne;
        private ToolStripMenuItem tsmiFive;
        private ToolStripMenuItem tmsiTen;
        private ToolStripMenuItem removeAllPanelsToolStripMenuItem;
        private ContextMenuStrip cmsPanel;
        private ToolStripMenuItem tsmiRemove;
    }
}