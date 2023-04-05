using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class ContactViewUtils
    {
        internal static Panel CreatePanel(Contact contact)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                BorderStyle = BorderStyle.FixedSingle,
                FlowDirection = FlowDirection.TopDown,
                Tag = contact.Id
            };
            
            panel.Controls.Add(CreateLabel(contact.FirstName));
            panel.Controls.Add(CreateLabel(contact.LastName));
            panel.Controls.Add(CreateLinkLabel(contact.Email));

            return panel;
        }

        private static Label CreateLabel(string text)
        => new Label 
        { 
            Text = text,
            Margin = new Padding(0,5,0,5),
            AutoSize = true
        };

        private static LinkLabel CreateLinkLabel(string text)
        {
            var label = new LinkLabel
            {
                Text = text,
                AutoSize = true
            };
            label.Click += (sender, e) =>
            {
                var lbl = sender as LinkLabel;
                Process.Start($"mailto:{lbl.Text}");
            };

            return label;
        }

        private static void Label_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
