﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tip4Trip_aka.Models
{
    public class House
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please, provide a title")]
        [StringLength(250)]
        public string Title { get; set; }
        public ApplicationUser Owner { get; set; }
        public string OwnerId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        //public DateTime Start_date { get; set; }
        //public DateTime End_date { get; set; }

        public Location Location { get; set; }

        [Display(Name = "Location")]
        [Required]
        public int LocationId { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        // public Reservation Reserve { get; set; }

        //[Display(Name = "Reservation")]
        // [Required]
        // public int ReserveId { get; set; }

        string image;
        [Required]
        [Range(0, 30, ErrorMessage = "Max occupancy must be between 0-30")]
        public int MaxOccupancy { get; set; }
        [Range(1, 10000, ErrorMessage = "Price per night must be between 1 and 10000")]
        public int PriceperNight { get; set; }

        public static implicit operator House(DbSet<House> v)
        {
            throw new NotImplementedException();
        }
    }
}