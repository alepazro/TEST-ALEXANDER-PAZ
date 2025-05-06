using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmubles.Aplication.DTOs.Owners
{
    public class OwnerDto
    {
        public string Id { get; set; }
        public int IdOwner { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Photo { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }


    }
}
