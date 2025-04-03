﻿using GainIt.API.Models.Enums.Users;
using GainIt.API.Models.Projects;
using System.ComponentModel.DataAnnotations;

namespace GainIt.API.Models.Users.Gainers
{
    public class Gainer : User
    {
        public Gainer()
        {
            this.UserRole = eUserRole.Gainer;  // Set as "Gainer" by default
        }

        [Required(ErrorMessage = "Education Status is required")]
        [StringLength(100, ErrorMessage = "Education Status cannot exceed 100 characters")]
        public string EducationStatus { get; set; }
        public List<string> AreasOfInterest { get; set; }

        public List<Project> ParticipatedProjects { get; set; } = new();
    }
}
