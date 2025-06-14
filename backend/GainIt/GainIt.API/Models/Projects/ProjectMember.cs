﻿using GainIt.API.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace GainIt.API.Models.Projects
{
    public class ProjectMember
    {
        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }

        [Required]
        [StringLength(100)]
        public required string UserRole { get; set; }

        public bool IsAdmin { get; set; }

        [Required]
        public DateTime JoinedAtUtc { get; set; } = DateTime.UtcNow;

        public DateTime? LeftAtUtc { get; set; }

        // Navigation properties
        public required UserProject Project { get; set; }
        public required User User { get; set; }
    }
}