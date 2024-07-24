using System;
using System.ComponentModel.DataAnnotations;

namespace SigmaTest.Service.Controllers.Entities
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;


        public string? PhoneNumber { get; set; }

        [Required]
        public DateTimeOffset TimeIntervalStart { get; set; }

        [Required]
        public DateTimeOffset TimeInterValEnd { get; set; }


        public string LinkedInUrl { get; set; } = string.Empty;
    }
}

