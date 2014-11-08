﻿namespace PickMeUp.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Trip
    {
        public Trip()
        {
            this.Passengers = new HashSet<ApplicationUser>();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public int AvailableSeats { get; set; }

        public decimal Price { get; set; }

        public string DriverId { get; set; }

        public int VotePoints { get; set; }

        public virtual ApplicationUser Driver { get; set; }

        public int FromId { get; set; }

        public virtual City From { get; set; }

        public int ToId { get; set; }

        public virtual City To { get; set; }

        public virtual ICollection<ApplicationUser> Passengers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
