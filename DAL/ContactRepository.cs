using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContactRepository
    {
        private const string PATH = "data.txt";
        public List<Contact> GetAll()
            => File.ReadAllLines(PATH).Select(Contact.FromLine).ToList();

        public void SaveAll(List<Contact> list)
        {

        }
    }
}
