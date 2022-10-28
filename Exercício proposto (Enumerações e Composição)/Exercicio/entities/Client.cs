using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder clientInfo = new StringBuilder();
            clientInfo.Append("Client: ");
            clientInfo.Append(this.Name);
            clientInfo.Append(" ");
            clientInfo.Append(this.BirthDate);
            clientInfo.Append(" - ");
            clientInfo.Append(this.Email);
            return clientInfo.ToString();
        }
    }
}