using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Mental.Rumination.Models {
    public class User : IdentityUser {
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string SecondEmail { get; set; }
        [MaxLength(255)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Country { get; set; }
        [MaxLength(255)]
        public string City { get; set; }
        public DateTime? BirthDate { get; set; }
        [MaxLength(255)]
        public string Language { get; set; }
    }
}