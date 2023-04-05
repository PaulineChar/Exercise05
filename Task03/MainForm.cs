using DAL;
using DAL.Models;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Task03
{
    public partial class MainForm : Form
    {
        private ContactRepository contactRepo;
        private ObservableCollection<Contact> contacts;
        private FlowLayoutPanel lastSelected;
        public MainForm()
        {
            InitializeComponent();

            ShowMessageOnFail(() =>
                {
                    contacts = new(contactRepo.GetAll());
                    ShowContacts();
                });

            contacts.CollectionChanged += (sender, e) =>
            {
                contactRepo.SaveAll(contacts.ToList());
                ShowContacts();
            };
        }

        private void ShowContacts()
        {
            flpContainer.Controls.Clear();
            contacts.ToList().ForEach(contact =>
            {
                var panel = ContactViewUtils.CreatePanel(contact);
                panel.Click += (sender, ea) =>
                {
                    if (lastSelected != null)
                    {
                        lastSelected.BackColor = SystemColors.Control;
                    }
                    var panel = sender as Panel;

                    foreach (var control in panel.Parent.Controls.OfType<FlowLayoutPanel>())
                    {
                        control.BorderStyle = BorderStyle.None;
                        control.BackColor = SystemColors.Control;
                    }
                    panel.BackColor = Color.Aqua;
                    lastSelected = (FlowLayoutPanel)panel;
                };
            });

        }

        private void ShowMessageOnFail(Action value)
        {
            try
            {
                value.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void optionItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem item)
            {
                var option = item.Text.ToLower();
                switch (option)
                {
                    case "edit":
                        EditContact();
                        break;
                    case "add":
                        AddContact();
                        break;
                    case "delete":
                        DeleteContact();
                        break;
                }
            }
        }

        private void DeleteContact()
        {
            if (lastSelected is null)
            {
                return;
            }
            var id = new Guid(lastSelected.Tag.ToString());
            contacts.ToList().RemoveAll(c => c.Id == id);
            


        }

        private void AddContact()
        {
            var form = new ChangePerson();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var contact = form.GetContact();
                contacts.Add(contact);
                
            }
        }

        private void EditContact()
        {
            var id = new Guid(lastSelected.Tag.ToString());
            var contact = contacts.First(c => c.Id == id);
            var form = new ChangePerson();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var editedContact = form.GetContact();
                contact.Email = editedContact.Email;
                contact.FirstName = editedContact.FirstName;
                contact.LastName = editedContact.LastName;
                
            }

        }
    }
}