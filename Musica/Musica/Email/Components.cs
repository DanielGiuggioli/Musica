using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class Components
    {
        public Components(string user, string token)
        {
            User = user;
            Token = token;
        }
        public string NameSender { get => "Musica Developer"; }
        public string Sender { get => "musicabygiuggioli"; }
        public string Subject { get => "Email verification"; }
        public string User { get; set; }
        public string Token { get; set; }
        public string Body { get => $"Hi {User}, welcome on Musica!\nInsert this code into the verification page to verify your identity:\n{Token}"; }
    }
}
