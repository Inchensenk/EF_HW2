using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2
{
    public class Card
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; } = null!;

        public Student? Student { get; set; }
    }
}
