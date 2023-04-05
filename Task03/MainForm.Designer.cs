namespace Task03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            msBook = new MenuStrip();
            tsmAdd = new ToolStripMenuItem();
            tsmEdit = new ToolStripMenuItem();
            tsBook = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            flpContainer = new FlowLayoutPanel();
            cmsContactOptions = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            msBook.SuspendLayout();
            tsBook.SuspendLayout();
            cmsContactOptions.SuspendLayout();
            SuspendLayout();
            // 
            // msBook
            // 
            msBook.ImageScalingSize = new Size(24, 24);
            msBook.Items.AddRange(new ToolStripItem[] { tsmAdd, tsmEdit });
            msBook.Location = new Point(0, 0);
            msBook.Name = "msBook";
            msBook.Size = new Size(800, 33);
            msBook.TabIndex = 0;
            msBook.Text = "menuStrip1";
            // 
            // tsmAdd
            // 
            tsmAdd.Name = "tsmAdd";
            tsmAdd.Size = new Size(62, 29);
            tsmAdd.Text = "Add";
            // 
            // tsmEdit
            // 
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(58, 29);
            tsmEdit.Text = "Edit";
            // 
            // tsBook
            // 
            tsBook.ImageScalingSize = new Size(24, 24);
            tsBook.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            tsBook.Location = new Point(0, 33);
            tsBook.Name = "tsBook";
            tsBook.Size = new Size(800, 33);
            tsBook.TabIndex = 1;
            tsBook.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "Add";
            toolStripButton1.Click += optionItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "Edit";
            toolStripButton2.Click += optionItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "Delete";
            toolStripButton3.Click += optionItem_Click;
            // 
            // flpContainer
            // 
            flpContainer.AutoScroll = true;
            flpContainer.Location = new Point(12, 82);
            flpContainer.Name = "flpContainer";
            flpContainer.Size = new Size(776, 356);
            flpContainer.TabIndex = 2;
            // 
            // cmsContactOptions
            // 
            cmsContactOptions.ImageScalingSize = new Size(24, 24);
            cmsContactOptions.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmsContactOptions.Name = "cmsContactOptions";
            cmsContactOptions.Size = new Size(135, 68);
            cmsContactOptions.Click += optionItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(134, 32);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += optionItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(134, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += optionItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpContainer);
            Controls.Add(tsBook);
            Controls.Add(msBook);
            MainMenuStrip = msBook;
            Name = "MainForm";
            Text = "MainForm";
            msBook.ResumeLayout(false);
            msBook.PerformLayout();
            tsBook.ResumeLayout(false);
            tsBook.PerformLayout();
            cmsContactOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msBook;
        private ToolStripMenuItem tsmAdd;
        private ToolStripMenuItem tsmEdit;
        private ToolStrip tsBook;
        private FlowLayoutPanel flpContainer;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ContextMenuStrip cmsContactOptions;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}