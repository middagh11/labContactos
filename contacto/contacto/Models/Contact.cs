﻿

namespace contacto.Models
{
    using System.ComponentModel.DataAnnotations;

   public enum TypeContact
    {
        telephone,
        email,
        facebook,
     }
    public class Contact
    {
        [key]
        public int ContactID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        [Display(Description ="Contact")]
        public string ContactValue { get; set; }

    }
}