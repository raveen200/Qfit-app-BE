﻿using MemberQfit.Services.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MemberQfit.Services.API.Models
{
    public class Members
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string NIC { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public DateOnly JoinDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        [Required]
        public StatusEnum Status { get; set; } = StatusEnum.Active;
        public string? DisplayPicture { get; set; }
        public string? Job { get; set; }
        public string? City { get; set; }
        public string? AboutMe { get; set; }
        public int? Age { get; set; }
        public GenderEnum? Gender { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }

    }
}
