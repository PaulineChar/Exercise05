using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Contact
    {
        public Contact(string firstname, string lastname, string email) 
        { 
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        => $"{FirstName} {LastName} {Email} {Id}";

        public static Contact FromLine(string line)
        {
            var details = line.Split(" ");
            return new Contact(details[0], details[1], details[2]);
            
                
        }
    }
}
