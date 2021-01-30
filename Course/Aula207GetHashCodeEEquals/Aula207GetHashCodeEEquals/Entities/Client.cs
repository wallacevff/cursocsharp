using System;
using System.Collections.Generic;
using System.Text;

namespace Aula207GetHashCodeEEquals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }


        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                throw new ArgumentException("Wrong class!");
            }
            return Email.Equals((obj as Client).Email);
        }
    }
}
