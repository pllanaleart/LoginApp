using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Entities
{
    public class IdentityEntity
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string NrTelefonit { get; set; }
        public string Email { get; set; }
        public DateTime Ditlindja { get; set; }
        public string Gjinia { get; set; }
        public string Password { get; set; }
        public string Adresa { get; set; }

    }
}
