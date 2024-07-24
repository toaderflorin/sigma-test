using System;
using System.ComponentModel.DataAnnotations;

namespace SigmaTest.Api.Controllers.Entities
{
    public class Candidate
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public DateTimeOffset TimeIntervalStart { get; set; }

        public DateTimeOffset TimeInterValEnd { get; set; }

        public string LinkedInUrl { get; set; } = string.Empty;
    }
}

