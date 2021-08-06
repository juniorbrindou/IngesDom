using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngesDom.Models
{
    //public enum SexEnum { Masculin, Feminin}
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        [MaxLength(30), Required]
        public string FirstName { get; set; }
        public string Email { get; set; }
        [MaxLength(60), Required]
        public string Sex { get; set; }
    }
}
