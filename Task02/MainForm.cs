using DAL;
using DAL.Utils;

namespace Task02
{
    public partial class MainForm : Form
    {
        private Size panelSize = new Size(40, 40);
        Panel lastSelected = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmsFormitem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            //The number of panels to add is stored in the 'Tag' property
            var count = Int32.Parse((string)item.Tag);

            AddPanels(count);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            if (lastSelected is not null)
                lastSelected.BorderStyle = BorderStyle.None;

            var panel = sender as Panel;
            panel.BorderStyle = BorderStyle.FixedSingle;
            lastSelected = panel;
        }

        private void AddPanels(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Panel panel = new Panel
                {
                    Size = panelSize,
                    BackColor = BasicUtils.GetRandomColor(),
                    Location = BasicUtils.GetRandomPosition(ClientSize, panelSize),
                    ContextMenuStrip = cmsPanel
                };

                Controls.Add(panel);
                panel.Click += panel_Click;
            }
        }


        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            Controls.Remove(lastSelected);
            lastSelected = null;

        }

        private void removeAllPanelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}