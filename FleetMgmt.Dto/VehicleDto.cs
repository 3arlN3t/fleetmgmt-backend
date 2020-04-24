﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FleetMgmt.Dto
{
    public class VehicleDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Make { get; set; }

        [Required]
        [MaxLength(255)]
        public string Model { get; set; }

        [Required]
        [MaxLength(100)]
        public string Color { get; set; }

        [Required]
        [MaxLength(100)]
        public string PlateNumber { get; set; }

        [MaxLength(250)]
        public string EngineNumber { get; set; }

        [MaxLength(250)]
        public string ChassisNumber { get; set; }
        public bool IsActive { get; set; } = true;

        public long? KilometersDriven { get; set; }
    }
}
