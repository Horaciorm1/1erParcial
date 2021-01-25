using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserMoralesHR.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 10)]
        public string Street { get; set; }
        [Required]
        public int Suite { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 3)]
        public string City { get; set; }
        [Required]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Codigo Invalido")]
        public int Zip { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }
        public string WebSite { get; set; }
        public string Company { get; set; }
        public string Phrase { get; set; }



    }
    
}