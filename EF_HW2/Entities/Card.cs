using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities
{
    public class Card
    {
        public int Id { get; set; }

        public int SerialNumber { get; set; } 

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
