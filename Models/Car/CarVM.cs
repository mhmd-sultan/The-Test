﻿using MB.Taxi.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Test.Models
{
    public class CarVM
    {
        public CarVM()
        {
            Booking = new List<BookingVM>();
        }
        public int Id { get; set; }

        [Required]
        [Display(Name = "Plate Number")]
        public string PlateNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Make Year")]
        public DateTime MakeYear { get; set; }

        [Required]
        [Display(Name = "Fuel Type")]

        public FuelType FuelType { get; set; }

        [Required]
        [Display (Name = "Car Type")]
        public CarType CarType { get; set; }

        public List<BookingVM> Booking { get; set; }
    }
}
