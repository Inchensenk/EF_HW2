using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_HW2.Entities
{
    public class Student
    {
        //[Key]
        public int Id { get; set; }
        //[Required]
        public string FirstName { get; set; } = null!;
        //[Required]
        public string LastName { get; set; } = null!;
        //[Required]
        public DateTime BirthDate { get; set; }
        //[Required]
        public string PhoneNumber { get; set; } = null!;
        /// <summary>
        /// Навигационное свойство
        /// </summary>
        public Card? Card { get; set; }


    }
}
