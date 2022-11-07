using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities
{
    public class Mark
    {
        //[Key]
        public int Id { get; set; }

        public double MarkValue { get; set; }
    }
}
