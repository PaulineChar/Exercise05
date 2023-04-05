namespace Task01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Menu Strip Items
            cmsFox.Click += ImageOptionMenusItem_Click;
            cmsMonkey.Click += ImageOptionMenusItem_Click;
            cmsTiger.Click += ImageOptionMenusItem_Click;
            //Context menu strip items
            tsmFox.Click += ImageOptionMenusItem_Click;
            tsmTiger.Click += ImageOptionMenusItem_Click;
            tsmMonkey.Click += ImageOptionMenusItem_Click;

            //tool strip items
            tsbFox.Click += ImageOptionMenusItem_Click;
            tsbTiger.Click += ImageOptionMenusItem_Click;
            tsbMonkey.Click += ImageOptionMenusItem_Click;
        }

        public void ImageOptionMenusItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem)
            {
                pbMain.Image = ((ToolStripItem)sender).Image;
            }

        }
    }
}