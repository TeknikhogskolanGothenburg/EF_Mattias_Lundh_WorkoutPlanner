﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutPlanner.Domain.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Minutes { get; set; }
        public Track Track { get; set; }
        public int TrackId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
