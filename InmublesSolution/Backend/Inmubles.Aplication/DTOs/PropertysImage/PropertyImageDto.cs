using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmubles.Aplication.DTOs.PropertysImage
{
    public class PropertyImageDto
    {
        public string Id { get; set; }
        public int IdPropertyImage { get; set; }
        public int IdProperty { get; set; }
        public string File { get; set; }
        public bool Enable { get; set; }
    }
}
